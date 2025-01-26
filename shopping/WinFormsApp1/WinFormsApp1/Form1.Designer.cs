namespace WinFormsApp1
{
    partial class POS
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
            button1 = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            PizzaQuantity = new TextBox();
            PizzaPrice = new TextBox();
            NoodleQuantity = new TextBox();
            NoodlePrice = new TextBox();
            chkpizza = new CheckBox();
            chkNooble = new CheckBox();
            tbdiscount = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            tbfood = new TextBox();
            chkFood = new CheckBox();
            tbbeverage = new TextBox();
            tball = new TextBox();
            chkBeverage = new CheckBox();
            chkall = new CheckBox();
            label4 = new Label();
            tbtotal = new TextBox();
            tbcash = new TextBox();
            tbchange = new TextBox();
            textBox1000 = new TextBox();
            textBox20 = new TextBox();
            textBox500 = new TextBox();
            textBox100 = new TextBox();
            textBox50 = new TextBox();
            textBox10 = new TextBox();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            textBox0_50 = new TextBox();
            textBox0_25 = new TextBox();
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
            chkCoffee = new CheckBox();
            chkGreentea = new CheckBox();
            CoffeePrice = new TextBox();
            CoffeeQuantity = new TextBox();
            GreenTeaPrice = new TextBox();
            GreeTeaQuantity = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            tbdiscount.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(340, 32);
            button1.Name = "button1";
            button1.Size = new Size(87, 356);
            button1.TabIndex = 0;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 95);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 2;
            label1.Text = "%";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PizzaQuantity);
            groupBox2.Controls.Add(PizzaPrice);
            groupBox2.Controls.Add(NoodleQuantity);
            groupBox2.Controls.Add(NoodlePrice);
            groupBox2.Controls.Add(chkpizza);
            groupBox2.Controls.Add(chkNooble);
            groupBox2.Location = new Point(12, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(322, 110);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Food";
            // 
            // PizzaQuantity
            // 
            PizzaQuantity.Location = new Point(214, 59);
            PizzaQuantity.Name = "PizzaQuantity";
            PizzaQuantity.Size = new Size(102, 27);
            PizzaQuantity.TabIndex = 7;
            // 
            // PizzaPrice
            // 
            PizzaPrice.Location = new Point(106, 57);
            PizzaPrice.Name = "PizzaPrice";
            PizzaPrice.Size = new Size(102, 27);
            PizzaPrice.TabIndex = 6;
            // 
            // NoodleQuantity
            // 
            NoodleQuantity.Location = new Point(214, 26);
            NoodleQuantity.Name = "NoodleQuantity";
            NoodleQuantity.Size = new Size(102, 27);
            NoodleQuantity.TabIndex = 5;
            // 
            // NoodlePrice
            // 
            NoodlePrice.Location = new Point(105, 24);
            NoodlePrice.Name = "NoodlePrice";
            NoodlePrice.Size = new Size(102, 27);
            NoodlePrice.TabIndex = 4;
            // 
            // chkpizza
            // 
            chkpizza.AutoSize = true;
            chkpizza.Location = new Point(6, 59);
            chkpizza.Name = "chkpizza";
            chkpizza.Size = new Size(65, 24);
            chkpizza.TabIndex = 2;
            chkpizza.Text = "Pizza";
            chkpizza.UseVisualStyleBackColor = true;
            // 
            // chkNooble
            // 
            chkNooble.AutoSize = true;
            chkNooble.Location = new Point(6, 26);
            chkNooble.Name = "chkNooble";
            chkNooble.Size = new Size(81, 24);
            chkNooble.TabIndex = 1;
            chkNooble.Text = "Noodle";
            chkNooble.UseVisualStyleBackColor = true;
            // 
            // tbdiscount
            // 
            tbdiscount.Controls.Add(label3);
            tbdiscount.Controls.Add(label2);
            tbdiscount.Controls.Add(tbfood);
            tbdiscount.Controls.Add(label1);
            tbdiscount.Controls.Add(chkFood);
            tbdiscount.Controls.Add(tbbeverage);
            tbdiscount.Controls.Add(tball);
            tbdiscount.Controls.Add(chkBeverage);
            tbdiscount.Controls.Add(chkall);
            tbdiscount.Location = new Point(12, 263);
            tbdiscount.Name = "tbdiscount";
            tbdiscount.Size = new Size(322, 125);
            tbdiscount.TabIndex = 9;
            tbdiscount.TabStop = false;
            tbdiscount.Text = "Discount";
            tbdiscount.Enter += groupBox3_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 63);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 10;
            label3.Text = "%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 30);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 10;
            label2.Text = "%";
            // 
            // tbfood
            // 
            tbfood.Location = new Point(190, 92);
            tbfood.Name = "tbfood";
            tbfood.Size = new Size(102, 27);
            tbfood.TabIndex = 9;
            // 
            // chkFood
            // 
            chkFood.AutoSize = true;
            chkFood.Location = new Point(6, 92);
            chkFood.Name = "chkFood";
            chkFood.Size = new Size(65, 24);
            chkFood.TabIndex = 8;
            chkFood.Text = "Food";
            chkFood.UseVisualStyleBackColor = true;
            // 
            // tbbeverage
            // 
            tbbeverage.Location = new Point(190, 59);
            tbbeverage.Name = "tbbeverage";
            tbbeverage.Size = new Size(102, 27);
            tbbeverage.TabIndex = 7;
            // 
            // tball
            // 
            tball.Location = new Point(190, 26);
            tball.Name = "tball";
            tball.Size = new Size(102, 27);
            tball.TabIndex = 5;
            tball.TextChanged += tball_TextChanged;
            // 
            // chkBeverage
            // 
            chkBeverage.AutoSize = true;
            chkBeverage.Location = new Point(6, 59);
            chkBeverage.Name = "chkBeverage";
            chkBeverage.Size = new Size(93, 24);
            chkBeverage.TabIndex = 2;
            chkBeverage.Text = "Beverage";
            chkBeverage.UseVisualStyleBackColor = true;
            // 
            // chkall
            // 
            chkall.AutoSize = true;
            chkall.Location = new Point(6, 26);
            chkall.Name = "chkall";
            chkall.Size = new Size(49, 24);
            chkall.TabIndex = 1;
            chkall.Text = "All";
            chkall.UseVisualStyleBackColor = true;
            chkall.CheckedChanged += chkall_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 33);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 11;
            label4.Text = "Total";
            // 
            // tbtotal
            // 
            tbtotal.Location = new Point(499, 29);
            tbtotal.Name = "tbtotal";
            tbtotal.Size = new Size(102, 27);
            tbtotal.TabIndex = 8;
            // 
            // tbcash
            // 
            tbcash.Location = new Point(499, 62);
            tbcash.Name = "tbcash";
            tbcash.Size = new Size(102, 27);
            tbcash.TabIndex = 12;
            // 
            // tbchange
            // 
            tbchange.Location = new Point(499, 95);
            tbchange.Name = "tbchange";
            tbchange.Size = new Size(102, 27);
            tbchange.TabIndex = 13;
            // 
            // textBox1000
            // 
            textBox1000.Location = new Point(499, 128);
            textBox1000.Name = "textBox1000";
            textBox1000.Size = new Size(102, 27);
            textBox1000.TabIndex = 14;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(499, 260);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(102, 27);
            textBox20.TabIndex = 15;
            // 
            // textBox500
            // 
            textBox500.Location = new Point(499, 161);
            textBox500.Name = "textBox500";
            textBox500.Size = new Size(102, 27);
            textBox500.TabIndex = 15;
            // 
            // textBox100
            // 
            textBox100.Location = new Point(499, 194);
            textBox100.Name = "textBox100";
            textBox100.Size = new Size(102, 27);
            textBox100.TabIndex = 16;
            // 
            // textBox50
            // 
            textBox50.Location = new Point(499, 227);
            textBox50.Name = "textBox50";
            textBox50.Size = new Size(102, 27);
            textBox50.TabIndex = 17;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(499, 293);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(102, 27);
            textBox10.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(499, 326);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(102, 27);
            textBox5.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(499, 359);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 27);
            textBox1.TabIndex = 20;
            // 
            // textBox0_50
            // 
            textBox0_50.Location = new Point(499, 392);
            textBox0_50.Name = "textBox0_50";
            textBox0_50.Size = new Size(102, 27);
            textBox0_50.TabIndex = 21;
            // 
            // textBox0_25
            // 
            textBox0_25.Location = new Point(499, 425);
            textBox0_25.Name = "textBox0_25";
            textBox0_25.Size = new Size(102, 27);
            textBox0_25.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(457, 66);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 23;
            label5.Text = "Cash";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(438, 99);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 24;
            label6.Text = "Change";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(456, 132);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 25;
            label7.Text = "1000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(464, 165);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 26;
            label8.Text = "500";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(464, 198);
            label9.Name = "label9";
            label9.Size = new Size(33, 20);
            label9.TabIndex = 27;
            label9.Text = "100";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(472, 231);
            label10.Name = "label10";
            label10.Size = new Size(25, 20);
            label10.TabIndex = 28;
            label10.Text = "50";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(472, 264);
            label11.Name = "label11";
            label11.Size = new Size(25, 20);
            label11.TabIndex = 29;
            label11.Text = "20";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(473, 297);
            label12.Name = "label12";
            label12.Size = new Size(25, 20);
            label12.TabIndex = 30;
            label12.Text = "10";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(480, 330);
            label13.Name = "label13";
            label13.Size = new Size(17, 20);
            label13.TabIndex = 31;
            label13.Text = "5";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(481, 363);
            label14.Name = "label14";
            label14.Size = new Size(17, 20);
            label14.TabIndex = 32;
            label14.Text = "1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(463, 396);
            label15.Name = "label15";
            label15.Size = new Size(36, 20);
            label15.TabIndex = 33;
            label15.Text = "0.50";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(462, 429);
            label16.Name = "label16";
            label16.Size = new Size(36, 20);
            label16.TabIndex = 34;
            label16.Text = "0.25";
            // 
            // chkCoffee
            // 
            chkCoffee.AutoSize = true;
            chkCoffee.Location = new Point(6, 26);
            chkCoffee.Name = "chkCoffee";
            chkCoffee.Size = new Size(75, 24);
            chkCoffee.TabIndex = 1;
            chkCoffee.Text = "Coffee";
            chkCoffee.UseVisualStyleBackColor = true;
            // 
            // chkGreentea
            // 
            chkGreentea.AutoSize = true;
            chkGreentea.Location = new Point(6, 59);
            chkGreentea.Name = "chkGreentea";
            chkGreentea.Size = new Size(97, 24);
            chkGreentea.TabIndex = 2;
            chkGreentea.Text = "Green Tea";
            chkGreentea.UseVisualStyleBackColor = true;
            // 
            // CoffeePrice
            // 
            CoffeePrice.Location = new Point(105, 24);
            CoffeePrice.Name = "CoffeePrice";
            CoffeePrice.Size = new Size(102, 27);
            CoffeePrice.TabIndex = 4;
            // 
            // CoffeeQuantity
            // 
            CoffeeQuantity.Location = new Point(214, 26);
            CoffeeQuantity.Name = "CoffeeQuantity";
            CoffeeQuantity.Size = new Size(102, 27);
            CoffeeQuantity.TabIndex = 5;
            // 
            // GreenTeaPrice
            // 
            GreenTeaPrice.Location = new Point(106, 57);
            GreenTeaPrice.Name = "GreenTeaPrice";
            GreenTeaPrice.Size = new Size(102, 27);
            GreenTeaPrice.TabIndex = 6;
            // 
            // GreeTeaQuantity
            // 
            GreeTeaQuantity.Location = new Point(214, 59);
            GreeTeaQuantity.Name = "GreeTeaQuantity";
            GreeTeaQuantity.Size = new Size(102, 27);
            GreeTeaQuantity.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GreeTeaQuantity);
            groupBox1.Controls.Add(GreenTeaPrice);
            groupBox1.Controls.Add(CoffeeQuantity);
            groupBox1.Controls.Add(CoffeePrice);
            groupBox1.Controls.Add(chkGreentea);
            groupBox1.Controls.Add(chkCoffee);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 110);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Beverage";
            // 
            // POS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 460);
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
            Controls.Add(textBox0_25);
            Controls.Add(textBox0_50);
            Controls.Add(textBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox10);
            Controls.Add(textBox50);
            Controls.Add(textBox100);
            Controls.Add(textBox500);
            Controls.Add(textBox20);
            Controls.Add(textBox1000);
            Controls.Add(tbchange);
            Controls.Add(tbcash);
            Controls.Add(tbtotal);
            Controls.Add(label4);
            Controls.Add(tbdiscount);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "POS";
            Text = "POS";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tbdiscount.ResumeLayout(false);
            tbdiscount.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox PizzaQuantity;
        private TextBox PizzaPrice;
        private TextBox NoodleQuantity;
        private TextBox NoodlePrice;
        private CheckBox chkpizza;
        private CheckBox chkNooble;
        private GroupBox tbdiscount;
        private TextBox tbfood;
        private CheckBox chkFood;
        private TextBox tbbeverage;
        private TextBox tball;
        private CheckBox chkBeverage;
        private CheckBox chkall;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox tbtotal;
        private TextBox tbcash;
        private TextBox tbchange;
        private TextBox textBox1000;
        private TextBox textBox20;
        private TextBox textBox500;
        private TextBox textBox100;
        private TextBox textBox50;
        private TextBox textBox10;
        private TextBox textBox5;
        private TextBox textBox1;
        private TextBox textBox0_50;
        private TextBox textBox0_25;
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
        private CheckBox chkCoffee;
        private CheckBox chkGreentea;
        private TextBox CoffeePrice;
        private TextBox CoffeeQuantity;
        private TextBox GreenTeaPrice;
        private TextBox GreeTeaQuantity;
        private GroupBox groupBox1;
    }
}
