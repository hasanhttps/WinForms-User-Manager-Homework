namespace Anket
{
    partial class Form1
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            Female = new RadioButton();
            Male = new RadioButton();
            label8 = new Label();
            Birthday = new DateTimePicker();
            label7 = new Label();
            phoneBox = new TextBox();
            label6 = new Label();
            cityBox = new TextBox();
            label5 = new Label();
            countryBox = new TextBox();
            label4 = new Label();
            fathernameBox = new TextBox();
            label3 = new Label();
            surnameBox = new TextBox();
            label2 = new Label();
            nameBox = new TextBox();
            name = new Label();
            SaveButton = new Button();
            label1 = new Label();
            loadBox = new TextBox();
            LoadButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Female);
            groupBox1.Controls.Add(Male);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(Birthday);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(phoneBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cityBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(countryBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(fathernameBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(surnameBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameBox);
            groupBox1.Controls.Add(name);
            groupBox1.Location = new Point(12, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 368);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anket";
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Location = new Point(187, 322);
            Female.Name = "Female";
            Female.Size = new Size(63, 19);
            Female.TabIndex = 16;
            Female.TabStop = true;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Location = new Point(108, 320);
            Male.Name = "Male";
            Male.Size = new Size(51, 19);
            Male.TabIndex = 15;
            Male.TabStop = true;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 322);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 14;
            label8.Text = "Gender";
            // 
            // Birthday
            // 
            Birthday.Location = new Point(108, 285);
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(235, 23);
            Birthday.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 285);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 12;
            label7.Text = "Birthday";
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(108, 218);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(235, 23);
            phoneBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 221);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 10;
            label6.Text = "Phone ";
            // 
            // cityBox
            // 
            cityBox.Location = new Point(108, 189);
            cityBox.Name = "cityBox";
            cityBox.Size = new Size(235, 23);
            cityBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 192);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 8;
            label5.Text = "City";
            // 
            // countryBox
            // 
            countryBox.Location = new Point(108, 160);
            countryBox.Name = "countryBox";
            countryBox.Size = new Size(235, 23);
            countryBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 163);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 6;
            label4.Text = "Country";
            // 
            // fathernameBox
            // 
            fathernameBox.Location = new Point(108, 97);
            fathernameBox.Name = "fathernameBox";
            fathernameBox.Size = new Size(235, 23);
            fathernameBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 100);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Fathername";
            // 
            // surnameBox
            // 
            surnameBox.Location = new Point(108, 68);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(235, 23);
            surnameBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 71);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Surname";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(108, 39);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(235, 23);
            nameBox.TabIndex = 1;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(18, 42);
            name.Name = "name";
            name.Size = new Size(39, 15);
            name.TabIndex = 0;
            name.Text = "Name";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 426);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(349, 29);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 2;
            label1.Text = "Name : ";
            // 
            // loadBox
            // 
            loadBox.Location = new Point(74, 5);
            loadBox.Name = "loadBox";
            loadBox.Size = new Size(188, 23);
            loadBox.TabIndex = 3;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(268, 5);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(93, 25);
            LoadButton.TabIndex = 4;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 461);
            Controls.Add(LoadButton);
            Controls.Add(loadBox);
            Controls.Add(label1);
            Controls.Add(SaveButton);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Anket";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button SaveButton;
        private Label label1;
        private TextBox loadBox;
        private Button LoadButton;
        private Label name;
        private TextBox nameBox;
        private TextBox surnameBox;
        private Label label2;
        private TextBox fathernameBox;
        private Label label3;
        private TextBox cityBox;
        private Label label5;
        private TextBox countryBox;
        private Label label4;
        private TextBox phoneBox;
        private Label label6;
        private RadioButton Female;
        private RadioButton Male;
        private Label label8;
        private DateTimePicker Birthday;
        private Label label7;
    }
}