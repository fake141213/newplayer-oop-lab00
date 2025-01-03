namespace Newproject
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
            Check_out = new Button();
            tbccoffee = new CheckBox();
            CoffeePrice = new TextBox();
            GreenTeaPrice = new TextBox();
            CoffeeQuantity = new TextBox();
            GreeTeaQuantity = new TextBox();
            tbgreentea = new CheckBox();
            total = new TextBox();
            label1 = new Label();
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
            cash = new TextBox();
            change = new TextBox();
            textBox1000 = new TextBox();
            textBox500 = new TextBox();
            textBox100 = new TextBox();
            textBox50 = new TextBox();
            textBox20 = new TextBox();
            textBox10 = new TextBox();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Check_out
            // 
            Check_out.Location = new Point(393, 35);
            Check_out.Name = "Check_out";
            Check_out.Size = new Size(105, 354);
            Check_out.TabIndex = 0;
            Check_out.Text = "Check Out";
            Check_out.UseVisualStyleBackColor = true;
            Check_out.Click += Check_out_Click;
            // 
            // tbccoffee
            // 
            tbccoffee.AutoSize = true;
            tbccoffee.Location = new Point(24, 35);
            tbccoffee.Name = "tbccoffee";
            tbccoffee.Size = new Size(75, 24);
            tbccoffee.TabIndex = 1;
            tbccoffee.Text = "Coffee";
            tbccoffee.UseVisualStyleBackColor = true;
            tbccoffee.CheckedChanged += tbccoffee_CheckedChanged;
            // 
            // CoffeePrice
            // 
            CoffeePrice.Location = new Point(131, 35);
            CoffeePrice.Name = "CoffeePrice";
            CoffeePrice.Size = new Size(125, 27);
            CoffeePrice.TabIndex = 2;
            // 
            // GreenTeaPrice
            // 
            GreenTeaPrice.Location = new Point(131, 68);
            GreenTeaPrice.Name = "GreenTeaPrice";
            GreenTeaPrice.Size = new Size(125, 27);
            GreenTeaPrice.TabIndex = 3;
            // 
            // CoffeeQuantity
            // 
            CoffeeQuantity.Location = new Point(262, 35);
            CoffeeQuantity.Name = "CoffeeQuantity";
            CoffeeQuantity.Size = new Size(125, 27);
            CoffeeQuantity.TabIndex = 4;
            // 
            // GreeTeaQuantity
            // 
            GreeTeaQuantity.Location = new Point(262, 68);
            GreeTeaQuantity.Name = "GreeTeaQuantity";
            GreeTeaQuantity.Size = new Size(125, 27);
            GreeTeaQuantity.TabIndex = 5;
            // 
            // tbgreentea
            // 
            tbgreentea.AutoSize = true;
            tbgreentea.Location = new Point(24, 65);
            tbgreentea.Name = "tbgreentea";
            tbgreentea.Size = new Size(97, 24);
            tbgreentea.TabIndex = 6;
            tbgreentea.Text = "Green Tea";
            tbgreentea.UseVisualStyleBackColor = true;
            // 
            // total
            // 
            total.Location = new Point(582, 35);
            total.Name = "total";
            total.Size = new Size(125, 27);
            total.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(531, 39);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 8;
            label1.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(531, 74);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 9;
            label2.Text = "Cash";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 108);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 10;
            label3.Text = "Change";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(532, 141);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 11;
            label4.Text = "1000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(539, 173);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 12;
            label5.Text = "500";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(539, 210);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 13;
            label6.Text = "100";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(544, 242);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 14;
            label7.Text = "50";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(546, 274);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 15;
            label8.Text = "20";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(545, 308);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 16;
            label9.Text = "10";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(555, 342);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 17;
            label10.Text = "5";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(552, 369);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 18;
            label11.Text = "1";
            // 
            // cash
            // 
            cash.Location = new Point(582, 71);
            cash.Name = "cash";
            cash.Size = new Size(125, 27);
            cash.TabIndex = 19;
            // 
            // change
            // 
            change.Location = new Point(582, 104);
            change.Name = "change";
            change.Size = new Size(125, 27);
            change.TabIndex = 20;
            // 
            // textBox1000
            // 
            textBox1000.Location = new Point(582, 137);
            textBox1000.Name = "textBox1000";
            textBox1000.Size = new Size(125, 27);
            textBox1000.TabIndex = 21;
            // 
            // textBox500
            // 
            textBox500.Location = new Point(582, 170);
            textBox500.Name = "textBox500";
            textBox500.Size = new Size(125, 27);
            textBox500.TabIndex = 22;
            // 
            // textBox100
            // 
            textBox100.Location = new Point(582, 205);
            textBox100.Name = "textBox100";
            textBox100.Size = new Size(125, 27);
            textBox100.TabIndex = 23;
            // 
            // textBox50
            // 
            textBox50.Location = new Point(582, 238);
            textBox50.Name = "textBox50";
            textBox50.Size = new Size(125, 27);
            textBox50.TabIndex = 24;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(582, 271);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(125, 27);
            textBox20.TabIndex = 25;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(582, 304);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 27);
            textBox10.TabIndex = 26;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(582, 337);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(582, 370);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox10);
            Controls.Add(textBox20);
            Controls.Add(textBox50);
            Controls.Add(textBox100);
            Controls.Add(textBox500);
            Controls.Add(textBox1000);
            Controls.Add(change);
            Controls.Add(cash);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(total);
            Controls.Add(tbgreentea);
            Controls.Add(GreeTeaQuantity);
            Controls.Add(CoffeeQuantity);
            Controls.Add(GreenTeaPrice);
            Controls.Add(CoffeePrice);
            Controls.Add(tbccoffee);
            Controls.Add(Check_out);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Check_out;
        private CheckBox tbccoffee;
        private TextBox CoffeePrice;
        private TextBox GreenTeaPrice;
        private TextBox CoffeeQuantity;
        private TextBox GreeTeaQuantity;
        private CheckBox tbgreentea;
        private TextBox total;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox cash;
        private TextBox change;
        private TextBox textBox1000;
        private TextBox textBox500;
        private TextBox textBox100;
        private TextBox textBox50;
        private TextBox textBox20;
        private TextBox textBox10;
        private TextBox textBox5;
        private TextBox textBox1;
    }
}
