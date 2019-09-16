using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Majasdarbs1
{
      
    public partial class Form1 : Form
    {
        public decimal degreesCelsius = 0;
        public decimal degreesFarenheit = 0;
        public void CalculateFromCelsius()
        {
            textBox2.TextChanged -= TextBox2_TextChanged;
            degreesFarenheit = (degreesCelsius * 9) / 5 + 32;
            textBox2.Text = degreesFarenheit.ToString("F");
            label3.Text = $"{degreesCelsius:F} pēc Celsija ir {degreesFarenheit:F} pēc Fārenheita";
            textBox2.TextChanged += TextBox2_TextChanged;

        }

        public void CalculateFromFarenheit()
        {
            textBox1.TextChanged -= TextBox1_TextChanged_1;
            degreesCelsius = Decimal.Divide(5,9) * (degreesFarenheit - 32);
            textBox1.Text = degreesCelsius.ToString("F");
            label3.Text = $"{degreesFarenheit:F} pēc Fārenheita ir {degreesCelsius:F} pēc Celsija";
            textBox1.TextChanged += TextBox1_TextChanged_1;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox2.Text, out degreesFarenheit))
            {
                CalculateFromFarenheit();
            }
            else
            {
                label3.Text = "Lūdzu ievadiet skaitli";
            }
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out degreesCelsius))
            {
               CalculateFromCelsius();
            }
            else
            {
                label3.Text = "Lūdzu ievadiet skaitli";
            }
        }
    }
}
