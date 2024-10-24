namespace Assignment2Graphs_KailanBates_PIE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddData = new Button();
            txtDataName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnMakePie = new Button();
            lstData = new ListBox();
            label3 = new Label();
            btnRemoveItem = new Button();
            txtDataValue = new TextBox();
            lblMessages = new Label();
            picBoxPie = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBoxPie).BeginInit();
            SuspendLayout();
            // 
            // btnAddData
            // 
            btnAddData.Location = new Point(304, 57);
            btnAddData.Name = "btnAddData";
            btnAddData.Size = new Size(75, 23);
            btnAddData.TabIndex = 0;
            btnAddData.Text = "Add Data";
            btnAddData.UseVisualStyleBackColor = true;
            btnAddData.Click += btnAddData_Click;
            // 
            // txtDataName
            // 
            txtDataName.Location = new Point(37, 57);
            txtDataName.Name = "txtDataName";
            txtDataName.Size = new Size(143, 23);
            txtDataName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 39);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 3;
            label1.Text = "Data Name / Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 39);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Data Value";
            // 
            // btnMakePie
            // 
            btnMakePie.Location = new Point(453, 57);
            btnMakePie.Name = "btnMakePie";
            btnMakePie.Size = new Size(75, 23);
            btnMakePie.TabIndex = 5;
            btnMakePie.Text = "MAKE PIE";
            btnMakePie.UseVisualStyleBackColor = true;
            btnMakePie.Click += btnMakePie_Click;
            // 
            // lstData
            // 
            lstData.FormattingEnabled = true;
            lstData.ItemHeight = 15;
            lstData.Location = new Point(37, 136);
            lstData.Name = "lstData";
            lstData.Size = new Size(125, 214);
            lstData.TabIndex = 6;
            lstData.SelectedIndexChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 118);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Your Data";
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(37, 356);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(91, 23);
            btnRemoveItem.TabIndex = 8;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // txtDataValue
            // 
            txtDataValue.Location = new Point(188, 57);
            txtDataValue.Name = "txtDataValue";
            txtDataValue.Size = new Size(60, 23);
            txtDataValue.TabIndex = 9;
            // 
            // lblMessages
            // 
            lblMessages.AutoSize = true;
            lblMessages.Location = new Point(37, 93);
            lblMessages.Name = "lblMessages";
            lblMessages.Size = new Size(0, 15);
            lblMessages.TabIndex = 10;
            // 
            // picBoxPie
            // 
            picBoxPie.Location = new Point(227, 136);
            picBoxPie.Name = "picBoxPie";
            picBoxPie.Size = new Size(237, 214);
            picBoxPie.TabIndex = 11;
            picBoxPie.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 450);
            Controls.Add(picBoxPie);
            Controls.Add(lblMessages);
            Controls.Add(txtDataValue);
            Controls.Add(btnRemoveItem);
            Controls.Add(label3);
            Controls.Add(lstData);
            Controls.Add(btnMakePie);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDataName);
            Controls.Add(btnAddData);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBoxPie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddData;
        private TextBox txtDataName;
        private Label label1;
        private Label label2;
        private Button btnMakePie;
        private ListBox lstData;
        private Label label3;
        private Button btnRemoveItem;
        private TextBox txtDataValue;
        private Label lblMessages;
        private PictureBox picBoxPie;
    }
}
