namespace Coffee_Machine
{
    public partial class Form1 : Form
    {
        Stock stock = new Stock();

        public Form1()
        {
            InitializeComponent();
        }
        private void refill_Click(object sender, EventArgs e)
        {
            stock.RefillStock();
            MessageBox.Show("เติมวัตถุดิบเรียบร้อยแล้ว!");
            UpdateStockStatus();
        }

        private void check_Click(object sender, EventArgs e)
        {
            UpdateStockStatus();
        }
        private void UpdateStockStatus()
        {
            string stockStatus = stock.GetStockStatus();
            MessageBox.Show(stockStatus, "สถานะของวัตถุดิบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private IngredientItem GetSelectedRecipe()
        {
            if (checkBox1.Checked)
                return new IngredientItem("Black Coffee", 300, 20, 0, 0);
            if (checkBox2.Checked)
                return new IngredientItem("Mocha", 300, 20, 0, 10);
            if (checkBox3.Checked)
                return new IngredientItem("Latte", 300, 20, 10, 0);
            if (checkBox4.Checked)
                return new IngredientItem("Chocolate", 300, 0, 0, 20);

            return null;
        }
        private void ResetCheckBoxes()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngredientItem selectedRecipe = GetSelectedRecipe();

            if (selectedRecipe != null)
            {
                if (stock.CheckStock(selectedRecipe))
                {
                    stock.UseIngredients(selectedRecipe);
                    MessageBox.Show($"เครื่องดื่ม {selectedRecipe.Name} พร้อมเสิร์ฟแล้ว!", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetCheckBoxes();
                    UpdateStockStatus();
                }
                else
                {
                    MessageBox.Show($"วัตถุดิบไม่พอสำหรับ {selectedRecipe.Name}\nกรุณากดเติมสต็อก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกเครื่องดื่มก่อน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox1.Text = "300";
                textBox2.Text = "20";
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox4.ReadOnly = true;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = false;
                textBox4.Enabled = true;
                textBox1.Text = "300";
                textBox2.Text = "20";
                textBox4.Text = "10";
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox4.ReadOnly = true;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = false;
                textBox1.Text = "300";
                textBox2.Text = "20";
                textBox3.Text = "10";
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = true;
                textBox1.Text = "300";
                textBox4.Text = "20";
                textBox1.ReadOnly = true;
                textBox4.ReadOnly = true;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
        }
    }
}

