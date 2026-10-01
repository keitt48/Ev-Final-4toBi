using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class Form2 : Form
    {
        private int n3;

        public Form2()
        {
            InitializeComponent();
        }

        public object TextBB1 { get; private set; }
        public object TextBB2 { get; private set; }
        public object TexVar1 { get; private set; }
        public object TexVar2 { get; private set; }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int producto = num1 * num2;
            MessageBox.Show("el resultao del producto es + producto");
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int suma = num1 + num2;
            MessageBox.Show("el resultado de la suma es + suma");

        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int n3 = 1;
            int Potencia = 1;

            while (n3 != num2)
            {
                Potencia = Potencia * num1;
                n3 = n3 + 1;
            }
            MessageBox.Show("el resultado de la potencia es" + Potencia);
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float num1 = int.Parse(TextVar1.Text);
            float num2 = int.Parse(TextVar1.Text);

            if (num2 > 0)
                {
                float Division = num1 / num2;
                MessageBox.Show("el resultado es " + Division);
            }
            else
            {

            }
        }
    }
}