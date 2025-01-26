namespace Shopping
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Check_out = new Button();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            CoffeePrice = new TextBox();
            checkBox2 = new CheckBox();
            textBox2 = new TextBox();
            GreeTeaQuantity = new TextBox();
            CoffeeQuantity = new TextBox();
            groupBox2 = new GroupBox();
            NoodleQuantity = new TextBox();
            PizzaQuantity = new TextBox();
            PizzaPrice = new TextBox();
            NoodlePrice = new TextBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            groupBox3 = new GroupBox();
            tball = new TextBox();
            tbbe = new TextBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            tbfood = new TextBox();
            checkBox7 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            tbtotal = new TextBox();
            tbcash = new TextBox();
            tbchange = new TextBox();
            textBox1000 = new TextBox();
            textBox500 = new TextBox();
            textBox100 = new TextBox();
            textBox50 = new TextBox();
            textBox20 = new TextBox();
            textBox10 = new TextBox();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            textBox0_50 = new TextBox();
            textBox0_25 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // Check_out
            // 
            Check_out.Location = new Point(361, 26);
            Check_out.Name = "Check_out";
            Check_out.Size = new Size(106, 345);
            Check_out.TabIndex = 0;
            Check_out.Text = "Check out";
            Check_out.UseVisualStyleBackColor = true;
            Check_out.Click += Check_out_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Coffee";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CoffeeQuantity);
            groupBox1.Controls.Add(GreeTeaQuantity);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(CoffeePrice);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(23, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 104);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Beverge";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 30);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 3;
            label1.Text = "%";
            // 
            // CoffeePrice
            // 
            CoffeePrice.Location = new Point(96, 26);
            CoffeePrice.Name = "CoffeePrice";
            CoffeePrice.Size = new Size(108, 27);
            CoffeePrice.TabIndex = 4;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 62);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(93, 24);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "GreenTea";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 27);
            textBox2.TabIndex = 5;
            // 
            // GreeTeaQuantity
            // 
            GreeTeaQuantity.Location = new Point(210, 59);
            GreeTeaQuantity.Name = "GreeTeaQuantity";
            GreeTeaQuantity.Size = new Size(108, 27);
            GreeTeaQuantity.TabIndex = 6;
            // 
            // CoffeeQuantity
            // 
            CoffeeQuantity.Location = new Point(210, 26);
            CoffeeQuantity.Name = "CoffeeQuantity";
            CoffeeQuantity.Size = new Size(108, 27);
            CoffeeQuantity.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(NoodleQuantity);
            groupBox2.Controls.Add(PizzaQuantity);
            groupBox2.Controls.Add(PizzaPrice);
            groupBox2.Controls.Add(NoodlePrice);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Location = new Point(23, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 104);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Food";
            // 
            // NoodleQuantity
            // 
            NoodleQuantity.Location = new Point(210, 26);
            NoodleQuantity.Name = "NoodleQuantity";
            NoodleQuantity.Size = new Size(108, 27);
            NoodleQuantity.TabIndex = 7;
            // 
            // PizzaQuantity
            // 
            PizzaQuantity.Location = new Point(210, 59);
            PizzaQuantity.Name = "PizzaQuantity";
            PizzaQuantity.Size = new Size(108, 27);
            PizzaQuantity.TabIndex = 6;
            // 
            // PizzaPrice
            // 
            PizzaPrice.Location = new Point(96, 59);
            PizzaPrice.Name = "PizzaPrice";
            PizzaPrice.Size = new Size(108, 27);
            PizzaPrice.TabIndex = 5;
            // 
            // NoodlePrice
            // 
            NoodlePrice.Location = new Point(96, 26);
            NoodlePrice.Name = "NoodlePrice";
            NoodlePrice.Size = new Size(108, 27);
            NoodlePrice.TabIndex = 4;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 62);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(65, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Pizza";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 26);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(81, 24);
            checkBox4.TabIndex = 1;
            checkBox4.Text = "Noodle";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(tbfood);
            groupBox3.Controls.Add(checkBox7);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(tball);
            groupBox3.Controls.Add(tbbe);
            groupBox3.Controls.Add(checkBox5);
            groupBox3.Controls.Add(checkBox6);
            groupBox3.Location = new Point(23, 236);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(332, 135);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Food";
            // 
            // tball
            // 
            tball.Location = new Point(187, 26);
            tball.Name = "tball";
            tball.Size = new Size(108, 27);
            tball.TabIndex = 7;
            tball.TextChanged += textBox9_TextChanged;
            // 
            // tbbe
            // 
            tbbe.Location = new Point(187, 59);
            tbbe.Name = "tbbe";
            tbbe.Size = new Size(108, 27);
            tbbe.TabIndex = 6;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 62);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(85, 24);
            checkBox5.TabIndex = 2;
            checkBox5.Text = "Beverge";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(6, 26);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(49, 24);
            checkBox6.TabIndex = 1;
            checkBox6.Text = "All";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // tbfood
            // 
            tbfood.Location = new Point(187, 92);
            tbfood.Name = "tbfood";
            tbfood.Size = new Size(108, 27);
            tbfood.TabIndex = 9;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(6, 95);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(65, 24);
            checkBox7.TabIndex = 8;
            checkBox7.Text = "Food";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 62);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 10;
            label2.Text = "%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 95);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 10;
            label3.Text = "%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(490, 29);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 11;
            label4.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(492, 59);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 12;
            label5.Text = "Cash";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 92);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 13;
            label6.Text = "Change";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(491, 129);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 14;
            label7.Text = "1000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(499, 158);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 15;
            label8.Text = "500";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(499, 191);
            label9.Name = "label9";
            label9.Size = new Size(33, 20);
            label9.TabIndex = 16;
            label9.Text = "100";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(504, 224);
            label10.Name = "label10";
            label10.Size = new Size(25, 20);
            label10.TabIndex = 17;
            label10.Text = "50";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(504, 257);
            label11.Name = "label11";
            label11.Size = new Size(25, 20);
            label11.TabIndex = 18;
            label11.Text = "20";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(507, 290);
            label12.Name = "label12";
            label12.Size = new Size(25, 20);
            label12.TabIndex = 19;
            label12.Text = "10";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(512, 323);
            label13.Name = "label13";
            label13.Size = new Size(17, 20);
            label13.TabIndex = 20;
            label13.Text = "5";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(512, 356);
            label14.Name = "label14";
            label14.Size = new Size(17, 20);
            label14.TabIndex = 21;
            label14.Text = "1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(499, 389);
            label15.Name = "label15";
            label15.Size = new Size(36, 20);
            label15.TabIndex = 22;
            label15.Text = "0.50";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(496, 422);
            label16.Name = "label16";
            label16.Size = new Size(36, 20);
            label16.TabIndex = 23;
            label16.Text = "0.25";
            // 
            // tbtotal
            // 
            tbtotal.Location = new Point(538, 23);
            tbtotal.Name = "tbtotal";
            tbtotal.Size = new Size(108, 27);
            tbtotal.TabIndex = 8;
            // 
            // tbcash
            // 
            tbcash.Location = new Point(538, 56);
            tbcash.Name = "tbcash";
            tbcash.Size = new Size(108, 27);
            tbcash.TabIndex = 24;
            // 
            // tbchange
            // 
            tbchange.Location = new Point(538, 89);
            tbchange.Name = "tbchange";
            tbchange.Size = new Size(108, 27);
            tbchange.TabIndex = 25;
            // 
            // textBox1000
            // 
            textBox1000.Location = new Point(538, 122);
            textBox1000.Name = "textBox1000";
            textBox1000.Size = new Size(108, 27);
            textBox1000.TabIndex = 26;
            // 
            // textBox500
            // 
            textBox500.Location = new Point(538, 155);
            textBox500.Name = "textBox500";
            textBox500.Size = new Size(108, 27);
            textBox500.TabIndex = 27;
            // 
            // textBox100
            // 
            textBox100.Location = new Point(538, 188);
            textBox100.Name = "textBox100";
            textBox100.Size = new Size(108, 27);
            textBox100.TabIndex = 28;
            // 
            // textBox50
            // 
            textBox50.Location = new Point(538, 221);
            textBox50.Name = "textBox50";
            textBox50.Size = new Size(108, 27);
            textBox50.TabIndex = 29;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(538, 254);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(108, 27);
            textBox20.TabIndex = 30;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(538, 287);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(108, 27);
            textBox10.TabIndex = 31;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(538, 320);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(108, 27);
            textBox5.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(538, 353);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 27);
            textBox1.TabIndex = 33;
            // 
            // textBox0_50
            // 
            textBox0_50.Location = new Point(538, 386);
            textBox0_50.Name = "textBox0_50";
            textBox0_50.Size = new Size(108, 27);
            textBox0_50.TabIndex = 34;
            // 
            // textBox0_25
            // 
            textBox0_25.Location = new Point(538, 419);
            textBox0_25.Name = "textBox0_25";
            textBox0_25.Size = new Size(108, 27);
            textBox0_25.TabIndex = 34;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox0_25);
            Controls.Add(textBox0_50);
            Controls.Add(textBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox10);
            Controls.Add(textBox20);
            Controls.Add(textBox50);
            Controls.Add(textBox100);
            Controls.Add(textBox500);
            Controls.Add(textBox1000);
            Controls.Add(tbchange);
            Controls.Add(tbcash);
            Controls.Add(tbtotal);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Check_out);
            Name = "Form1";
            Text = "POS";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Check_out;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox CoffeePrice;
        private TextBox CoffeeQuantity;
        private TextBox GreeTeaQuantity;
        private TextBox textBox2;
        private CheckBox checkBox2;
        private GroupBox groupBox2;
        private TextBox NoodleQuantity;
        private TextBox PizzaQuantity;
        private TextBox PizzaPrice;
        private TextBox NoodlePrice;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private GroupBox groupBox3;
        private TextBox tball;
        private TextBox tbbe;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Label label3;
        private Label label2;
        private TextBox tbfood;
        private CheckBox checkBox7;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox tbtotal;
        private TextBox tbcash;
        private TextBox tbchange;
        private TextBox textBox1000;
        private TextBox textBox500;
        private TextBox textBox100;
        private TextBox textBox50;
        private TextBox textBox20;
        private TextBox textBox10;
        private TextBox textBox5;
        private TextBox textBox1;
        private TextBox textBox0_50;
        private TextBox textBox0_25;
    }
}
