namespace GPACalculator
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
            lblSubject = new Label();
            txtGrade = new TextBox();
            btnNext = new Button();
            lstGrades = new ListBox();
            lblResult = new Label();
            lblTotalStudents = new Label();
            lblGPAx = new Label();
            lblMaxScore = new Label();
            lblMinScore = new Label();
            ข้อมูลส่วนตัว = new GroupBox();
            ข้อมูลส่วนตัว.SuspendLayout();
            SuspendLayout();
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(162, 50);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(56, 20);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "subject";
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(260, 47);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(125, 27);
            txtGrade.TabIndex = 1;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(403, 47);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(97, 27);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lstGrades
            // 
            lstGrades.FormattingEnabled = true;
            lstGrades.Location = new Point(162, 90);
            lstGrades.Name = "lstGrades";
            lstGrades.Size = new Size(347, 104);
            lstGrades.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(6, 23);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result";
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.AutoSize = true;
            lblTotalStudents.Location = new Point(6, 53);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(49, 20);
            lblTotalStudents.TabIndex = 5;
            lblTotalStudents.Text = "Result";
            // 
            // lblGPAx
            // 
            lblGPAx.AutoSize = true;
            lblGPAx.Location = new Point(6, 83);
            lblGPAx.Name = "lblGPAx";
            lblGPAx.Size = new Size(49, 20);
            lblGPAx.TabIndex = 6;
            lblGPAx.Text = "Result";
            // 
            // lblMaxScore
            // 
            lblMaxScore.AutoSize = true;
            lblMaxScore.Location = new Point(6, 114);
            lblMaxScore.Name = "lblMaxScore";
            lblMaxScore.Size = new Size(49, 20);
            lblMaxScore.TabIndex = 7;
            lblMaxScore.Text = "Result";
            // 
            // lblMinScore
            // 
            lblMinScore.AutoSize = true;
            lblMinScore.Location = new Point(6, 144);
            lblMinScore.Name = "lblMinScore";
            lblMinScore.Size = new Size(49, 20);
            lblMinScore.TabIndex = 8;
            lblMinScore.Text = "Result";
            // 
            // ข้อมูลส่วนตัว
            // 
            ข้อมูลส่วนตัว.Controls.Add(lblResult);
            ข้อมูลส่วนตัว.Controls.Add(lblMinScore);
            ข้อมูลส่วนตัว.Controls.Add(lblTotalStudents);
            ข้อมูลส่วนตัว.Controls.Add(lblMaxScore);
            ข้อมูลส่วนตัว.Controls.Add(lblGPAx);
            ข้อมูลส่วนตัว.Location = new Point(162, 225);
            ข้อมูลส่วนตัว.Name = "ข้อมูลส่วนตัว";
            ข้อมูลส่วนตัว.Size = new Size(347, 189);
            ข้อมูลส่วนตัว.TabIndex = 9;
            ข้อมูลส่วนตัว.TabStop = false;
            ข้อมูลส่วนตัว.Text = "ข้อมูลนักศึกษา";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ข้อมูลส่วนตัว);
            Controls.Add(lstGrades);
            Controls.Add(btnNext);
            Controls.Add(txtGrade);
            Controls.Add(lblSubject);
            Name = "Form1";
            Text = "Form1";
            ข้อมูลส่วนตัว.ResumeLayout(false);
            ข้อมูลส่วนตัว.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubject;
        private TextBox txtGrade;
        private Button btnNext;
        private ListBox lstGrades;
        private Label lblResult;
        private Label lblTotalStudents;
        private Label lblGPAx;
        private Label lblMaxScore;
        private Label lblMinScore;
        private GroupBox ข้อมูลส่วนตัว;
    }
}
