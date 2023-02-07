using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NG_11_Saldumini
{
    public partial class Form1 : Form
    {
        private object rezultats;
        private object daudzums_kg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                double naudas_daudzums = Convert.ToDouble(sk1.Text);
                double nauda = naudas_daudzums;
                double cena = 9.88;
                double kilogramu_daudzums = naudas_daudzums / cena;
                    sk2.Text = kilogramu_daudzums.ToString();
            }
        }

        private void sk3_Click(object sender, EventArgs e)
        {

        }
    }
}
