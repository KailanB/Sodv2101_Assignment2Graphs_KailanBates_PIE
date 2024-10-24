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

                    DataInput input = new DataInput(inputName, value);
                    Pie.AddNewData(input);
                    lblMessages.Text = input.Name + input.Value.ToString();
                    lstData.Items.Clear();
                    foreach(DataInput data in Pie.DataInputs)
                    {
                        lstData.Items.Add(data.Name + ": " + data.Value.ToString());
                    }
                    txtDataName.Text = "";
                    txtDataValue.Text = "";

                    // lstData.Items.Add(input.Name + ": " + input.Value.ToString());

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


            if (lstData.SelectedItems != null)
            {
                Pie.RemoveData(lstData.SelectedIndex);

                lstData.Items.RemoveAt(lstData.SelectedIndex);
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            // 
            // Pen pen = new Pen(Color.FromArgb(red, green, blue), 3)
            // g.DrawLine(pen, 0, 10 * (i + 1), 100, 10 * (i + 1));
            // g.DrawRectangle(pen, pieRectangle);

            

            //Graphics g = e.Graphics;

            //g.DrawPie(Pens.Black, _pieRectangle, _pieStartingDegrees, _percentOfPie * 360);

            //g.FillEllipse(Brushes.BlueViolet, 120, 100, 5 + _pieDegrees, 30);

            //SolidBrush brush = new SolidBrush(Color.FromArgb(_red, _green, _blue));
            //g.FillPie(brush, _pieRectangle, _pieStartingDegrees, _percentOfPie * 360);
            // g.FillPie(brush, _pieRectangle, 0, 45);

            // Region region = new Region(new );
            //using (SolidBrush brush = new SolidBrush(Color.FromArgb(_red, _green, _blue)))
            //{
            //    // g.FillPie(brush, pieRectangle, 0, 50);

            //    g.FillPie(brush, _pieRectangle, _pieStartingDegrees, _percentOfPie / 360);
            //}


            //foreach (DataInput data in Pie.DataInputs)
            //{

            //    float percentOfPie = data.Value / Pie.TotalPieValues;
            //    MessageBox.Show(percentOfPie.ToString());
            //    float pieStartingDegrees = pieDegrees;

            //    _red = rnd.Next(0, 255);
            //    _blue = rnd.Next(0, 255);
            //    _green = rnd.Next(0, 255);



            //using (SolidBrush brush = new SolidBrush(Color.FromArgb(red, green, blue)))
            //    {
            //        // g.FillPie(brush, pieRectangle, 0, 50);

            //        g.FillPie(brush, pieRectangle, pieStartingDegrees, percentOfPie / 360);
            //    }

            //    pieDegrees += percentOfPie / 360;

            //}

            /*            for (int i = 0; i < 5; i++)
                        {


                        }*/





        }

        private void btnMakePie_Click(object sender, EventArgs e)
        {

            foreach(Label lab in labels)
            {
                this.Controls.Remove(lab);
            }

            Random rnd = new Random();

            int red = 0;
            int green = 0;
            int blue = 0;

            float percentOfPie = 0;
            float pieStartingDegrees = 0;
            float pieDegrees = 0;

            Rectangle pieRectangle = new Rectangle(0, 0, 200, 200);

            // learning bitmaps because OnPaint was overwriting previous pie pieces
            // https://stackoverflow.com/questions/8294045/c-sharp-draw-a-pie-chart-to-a-tab
            Bitmap B = new Bitmap(200, 200);

            using (Graphics g = Graphics.FromImage(B))
            {
                int num = 0;
                foreach (DataInput data in Pie.DataInputs)
                {
                    

                    percentOfPie = data.Value / Pie.TotalPieValues;
                    pieStartingDegrees = pieDegrees;
                    pieDegrees += percentOfPie * 360;

                    // double degrees = 0;
                    // double degreesToGo = percentOfPie * 360;

                    red = rnd.Next(0, 255);
                    blue = rnd.Next(0, 255);
                    green = rnd.Next(0, 255);

                    //double xChange = 0;
                    //double yChange = 0;
                    //if(pieStartingDegrees <= 90)
                    //{
                    //    xChange = Math.Cos(degrees);
                    //    yChange = Math.Sin(degrees);
                    //}

                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(red, green, blue)))
                    {
                        g.FillPie(brush, pieRectangle, pieStartingDegrees, percentOfPie * 360);

                        // g.DrawString(data.Name + " %" + (percentOfPie * 100).ToString("0.00"), new Font("Arial", 10), Brushes.Black, new Point((100 + (int)xChange), (100 + (int)yChange)));
                    }

                    Label label = new Label();
                    label.ForeColor = Color.FromArgb(red, green, blue);
                    label.Text = data.Name + " " + (percentOfPie * 100).ToString("0.00") + "%";
                    label.Location = new Point(500, (200 + num));
                    label.AutoSize = true;

                    num += 15;
                    this.Controls.Add(label);

                    labels.Add(label);

                }
                picBoxPie.Image = B;


            }


            

    }

        private void MakePie(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            //_pieDegrees = 0;

            //foreach (DataInput data in Pie.DataInputs)
            //{
            //    //MessageBox.Show(_pieStartingDegrees.ToString());
            //    _percentOfPie = data.Value / Pie.TotalPieValues;
            //    //MessageBox.Show(_percentOfPie.ToString());
            //    _pieStartingDegrees = _pieDegrees;
                
            //    _red = rnd.Next(0, 255);
            //    _blue = rnd.Next(0, 255);
            //    _green = rnd.Next(0, 255);    

            //    _pieDegrees += _percentOfPie * 360;
            //    //MessageBox.Show(_pieDegrees.ToString());

            //    Graphics g = e.Graphics;


            //    using (SolidBrush brush = new SolidBrush(Color.FromArgb(_red, _green, _blue)))
            //    {
            //        // g.FillPie(brush, pieRectangle, 0, 50);

            //        //g.FillPie(brush, pieRectangle, _pieStartingDegrees, _percentOfPie / 360);
            //    }

            //    // this.Invalidate();

            //}


            /*
            foreach (DataInput data in Pie.DataInputs)
            {

               
                //MessageBox.Show(_pieStartingDegrees.ToString());
                _percentOfPie = data.Value / Pie.TotalPieValues;
                //MessageBox.Show(_percentOfPie.ToString());
                _pieStartingDegrees = _pieDegrees;

                _red = rnd.Next(0, 255);
                _blue = rnd.Next(0, 255);
                _green = rnd.Next(0, 255);

                _pieDegrees += _percentOfPie * 360;
                //MessageBox.Show(_pieDegrees.ToString());

                //g.FillPie(brush, _pieRectangle, _pieStartingDegrees, _percentOfPie * 360);

                Rectangle rect = new Rectangle(0, 0, 0, 0);


                this.Invalidate();
                
            } 
            */
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
