namespace GPACalculator
{
    public partial class Form1 : Form
    {
        private List<string> subjects = new List<string> { "Elglish", "Object-oriented Programing", "Data Structures and Algorithms", "Calculus", "User Interface and User Experience Development" };
        private int currentSubjectIndex = 0;

        private Dictionary<string, double> gradeMapping = new Dictionary<string, double>
    {
        { "A", 4.00 },
        { "B+", 3.50 }, { "B", 3.00 }, { "B-", 2.75 },
        { "C+", 2.50 }, { "C", 2.00 }, { "C-", 1.75 },
        { "D+", 1.50 }, { "D", 1.00 }, { "F", 0.00 }
    };

        public Form1()
        {
            InitializeComponent();
            UpdateSubjectLabel();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentSubjectIndex >= subjects.Count)
            {
                MessageBox.Show("�س���͹�ô�ú�ء�Ԫ�����!");
                return;
            }
            string inputGrade = txtGrade.Text.Trim().ToUpper();
            if (gradeMapping.ContainsKey(inputGrade))
            {
                double gradeValue = gradeMapping[inputGrade];
                string subject = subjects[currentSubjectIndex];
                new Item(subject, gradeValue);
                lstGrades.Items.Add($"{subject}: {inputGrade} ({gradeValue:F2})");
                UpdateResults();
                txtGrade.Clear();
                currentSubjectIndex++;
                if (currentSubjectIndex < subjects.Count)
                {
                    UpdateSubjectLabel();
                }
                else
                {
                    lblSubject.Text = "�������!";
                    btnNext.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("�ô���١��ͧ�� A B B- B+ C C- C+ D D- D+ F ");
            }
        }
        private void UpdateSubjectLabel()
        {
            lblSubject.Text = $"��سҡ�͡�ô����Ѻ: {subjects[currentSubjectIndex]}";
        }
        private void UpdateResults()
        {
            lblResult.Text = $"GPA ��ǹ���: {Item.GetGPA():F2}";
            lblTotalStudents.Text = $"�ӹǹ�Ԫҷ���͹������: {Item.GetTotalStudents()}";
            lblGPAx.Text = $"GPAx �����: {Item.GetGPA():F2}";
            lblMaxScore.Text = $"��ṹ�٧�ش: {Item.GetMaxScore():F2}";
            lblMinScore.Text = $"��ṹ����ش: {Item.GetMinScore():F2}";
        }
    }
}
