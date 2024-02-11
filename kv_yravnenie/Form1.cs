using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kv_yravnenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                double discriminant = b * b - 4 * a * c;

                if (discriminant < 0)
                {
                    MessageBox.Show("Дискримінант менше нуля. Розв'язків немає.");
                }
                else if (discriminant == 0)
                {
                    double x = -b / (2 * a);
                    MessageBox.Show($"Дискримінант дорівнює нулю. Розв'язок: x = {x}.");
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    MessageBox.Show($"Дискримінант дорівнює {discriminant}. Розв'язки: x1 = {x1}, x2 = {x2}.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка у форматі введених даних. Будь ласка, введіть числа.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}