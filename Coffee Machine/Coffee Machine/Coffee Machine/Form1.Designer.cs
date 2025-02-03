namespace Coffee_Machine
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
            label1 = new Label();
            สูตร = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            refill = new Button();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            check = new Button();
            button1 = new Button();
            สูตร.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 19);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 3;
            label1.Text = "Coffee Machine";
            // 
            // สูตร
            // 
            สูตร.Controls.Add(label2);
            สูตร.Location = new Point(538, 49);
            สูตร.Name = "สูตร";
            สูตร.Size = new Size(357, 138);
            สูตร.TabIndex = 4;
            สูตร.TabStop = false;
            สูตร.Text = "สูตร";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(346, 80);
            label2.TabIndex = 20;
            label2.Text = "กาแฟดำ ประกอบด้วย น้ำ 300g, กาแฟ 20g\r\nมอคค่า ประกอบด้วย น้ำ 300g, กาแฟ 20g, ช๊อคโกเล็ด 10g\r\nลาเต้ ประกอบด้วย น้ำ 300g, กาแฟ 20g, นม 10g\r\nช๊อคโกเล็ต ประกอบด้วย น้ำ 300g, ช๊อคโกเล็ด 20g";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(404, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(238, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(404, 117);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 43);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 20;
            label4.Text = "water";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(404, 43);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 21;
            label5.Text = "coffee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(240, 96);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 22;
            label6.Text = "milk";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(407, 96);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 23;
            label7.Text = "chocolate";
            // 
            // refill
            // 
            refill.Location = new Point(544, 203);
            refill.Name = "refill";
            refill.Size = new Size(132, 50);
            refill.TabIndex = 42;
            refill.Text = "buttonRefill ";
            refill.UseVisualStyleBackColor = true;
            refill.Click += refill_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 24);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(114, 24);
            checkBox1.TabIndex = 45;
            checkBox1.Text = "Black Coffee";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 150);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 114);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(98, 24);
            checkBox4.TabIndex = 48;
            checkBox4.Text = "Chocolate";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 84);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(64, 24);
            checkBox3.TabIndex = 47;
            checkBox3.Text = "Latte";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 54);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(76, 24);
            checkBox2.TabIndex = 46;
            checkBox2.Text = "Mocha";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // check
            // 
            check.Location = new Point(544, 259);
            check.Name = "check";
            check.Size = new Size(132, 50);
            check.TabIndex = 47;
            check.Text = "Check Stock";
            check.UseVisualStyleBackColor = true;
            check.Click += check_Click;
            // 
            // button1
            // 
            button1.Location = new Point(404, 163);
            button1.Name = "button1";
            button1.Size = new Size(125, 146);
            button1.TabIndex = 48;
            button1.Text = "MakeDrink";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 450);
            Controls.Add(button1);
            Controls.Add(check);
            Controls.Add(groupBox1);
            Controls.Add(refill);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(สูตร);
            Controls.Add(label1);
            Name = "Form1";
            Text = "x";
            สูตร.ResumeLayout(false);
            สูตร.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox สูตร;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox14;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button labelStock;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox chocolatest;
        private TextBox milkst;
        private TextBox coffeest;
        private TextBox waterst;
        private Button refill;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private Button check;
        private Button button1;
    }
}
