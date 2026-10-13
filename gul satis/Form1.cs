using System;
using System.Windows.Forms;

namespace gul_satis
{
    public partial class Form1 : Form
    {
        double toplamGelir = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(maskedTextBox1.Text) ||
                string.IsNullOrEmpty(maskedTextBox2.Text))
            {
                MessageBox.Show("xanalar boş ola bilməz", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int count = int.Parse(maskedTextBox1.Text);
                double price = double.Parse(maskedTextBox2.Text);

                if (count <= 0 || price <= 0)
                {
                    MessageBox.Show("Say və qiymət sıfırdan böyük olmalıdır!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double result = count * price;

                    dataGridView1.Rows.Add(textBox1.Text, count.ToString(), price.ToString(), result.ToString("F2"));

                    toplamGelir += result;
                    label4.Text = "Toplam gəlir: " + toplamGelir.ToString("F2");

                    textBox1.Text = "";
                    maskedTextBox1.Text = "";
                    maskedTextBox2.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show("Çıxış edilsinmi?", "Çıxış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}