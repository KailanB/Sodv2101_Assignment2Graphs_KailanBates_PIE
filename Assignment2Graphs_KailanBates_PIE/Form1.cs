using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2Graphs_KailanBates_PIE
{
    public partial class Form1 : Form
    {


        private List<Label> labels = new List<Label>();


        public Form1()
        {

            

            InitializeComponent();

            this.DoubleBuffered = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            string inputName = txtDataName.Text;
            string inputValue = txtDataValue.Text;
            if ((inputName != "") && (inputValue != ""))
            {
                if (float.TryParse(inputValue, out float value))
                {
                    if(value >= 0)
                    {
                        DataInput input = new DataInput(inputName, value);
                        Pie.AddNewData(input);
                        lblMessages.Text = input.Name + input.Value.ToString();
                        lstData.Items.Clear();
                        foreach (DataInput data in Pie.DataInputs)
                        {
                            lstData.Items.Add(data.Name + ": " + data.Value.ToString());
                        }
                        txtDataName.Text = "";
                        txtDataValue.Text = "";

                        // lstData.Items.Add(input.Name + ": " + input.Value.ToString());
                    }
                    else
                    {
                        lblMessages.Text = "Please do not input negative values!";
                    }


                }
                else
                {
                    lblMessages.Text = "Please input only number values in Data Value field!";
                }
            }
            else
            {
                lblMessages.Text = "Please Enter a Name and Value!";
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {

            // check that user has item selected
            if (lstData.SelectedIndex > -1)
            {
                Pie.RemoveData(lstData.SelectedIndex);

                lstData.Items.RemoveAt(lstData.SelectedIndex);
            }
        }


        private void btnMakePie_Click(object sender, EventArgs e)
        {


            foreach (Label lab in labels)
            {
                this.Controls.Remove(lab);
            }

            Random rnd = new Random();

            int red = 0;
            int green = 0;
            int blue = 0;

            float percentOfPie = 0;
            float pieStartingDegrees = 0;
            float pieDegreesFilled = 0;
            float piePieceDegrees = 0;

            // counter is used for labeling pie pieces
            int counter = 0;

            Rectangle pieRectangle = new Rectangle(0, 0, 200, 200);

            // learning bitmaps because OnPaint was overwriting previous pie pieces
            // https://stackoverflow.com/questions/8294045/c-sharp-draw-a-pie-chart-to-a-tab
            Bitmap B = new Bitmap(200, 200);

            using (Graphics g = Graphics.FromImage(B))
            {

                int labelLocation = 0;
                foreach (DataInput data in Pie.DataInputs)
                {
                    // percentOfPie is referring to % of the pie chart that this piece of data takes
                    percentOfPie = data.Value / Pie.TotalPieValues;
                    // degree value of single piece
                    piePieceDegrees = percentOfPie * 360;
                    // starting degrees tracks the point that the last data value left at
                    pieStartingDegrees = pieDegreesFilled;
                    // degrees of all pieces that have been included so far
                    pieDegreesFilled += percentOfPie * 360;                   

 
                    red = rnd.Next(0, 255);
                    blue = rnd.Next(0, 255);
                    green = rnd.Next(0, 255);



                    double midAngle = pieStartingDegrees + piePieceDegrees / 2;
                    double radians = midAngle * Math.PI / 180;

                    // cos and sin issues resolved. C# uses radians. 
                    // https://stackoverflow.com/questions/11166034/c-sharp-math-cosdouble-returns-wrong-value
                    // these are the x y variables for the pie piece labels
                    double x = (100 + 0.7 * 100 * Math.Cos(radians));
                    double y = (100 + 0.7 * 100 * Math.Sin(radians));


                    // these variables are used to draw the separator line for the pie pieces
                    double segmentAngle = pieDegreesFilled;
                    double lineRadians = segmentAngle * Math.PI / 180;
                    double xLine = (100 + 100 * Math.Cos(lineRadians));
                    double yLine = (100 + 100 * Math.Sin(lineRadians));


                    // draw pie pieces
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(red, green, blue)))
                    {
                        // fill pie piece starting where last piece left off and filling appropriate number of degrees according to piece size
                        g.FillPie(brush, pieRectangle, pieStartingDegrees, piePieceDegrees);

                    }
                    // draw separator lines
                    using (Pen pen = new Pen(Brushes.Black))
                    {
                        pen.Width = 2;
                        g.DrawLine(pen, new Point(100, 100), new Point((int)xLine, (int)yLine));
                    }

                    // create data label with % value and matching color to corresponding pie piece
                    Label label = new Label();
                    label.ForeColor = Color.FromArgb(red, green, blue);
                    label.Text = (counter + 1) + ". " + data.Name + " " + (percentOfPie * 100).ToString("0.00") + "%";
                    label.Location = new Point(500, (200 + labelLocation));
                    label.AutoSize = true;

                    // increase label Y location 
                    labelLocation += 15;
                    this.Controls.Add(label);
                    labels.Add(label);

                    // Draw number on each pie piece
                    g.DrawString((counter + 1).ToString(), new Font("Arial", 12), Brushes.Black, new Point((int)x, (int)y));
                    

                    counter++;
                }

                picBoxPie.Image = B;

            }


            

    }

    }



    static class Pie
    { 
        public static List<DataInput> DataInputs = new List<DataInput>();

        public static float TotalPieValues { get; set; } = 0;

        public static void AddNewData(DataInput data)
        {
            DataInputs.Add(data);

            TotalPieValues += data.Value;
        }

        public static void RemoveData(int index)
        {
            TotalPieValues -= DataInputs[index].Value;
            DataInputs.RemoveAt(index);
        }
        



    }


    class DataInput
    {
        public string Name { get; set; }
        public float Value { get; set; }



        public DataInput(string name, float value)
        {
            this.Name = name;
            this.Value = value;
        }

    }





}
