using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektWażnyMenu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int czas = rand.Next(10,30);
            string jd = textBox1.Text;
            if (jd != "" && jd.Length > 8)
            {
                label2.Text = "Wysłano zamówienie do: " + jd + ". \n Zamówienie przyjdzie w ciągu "+czas+" minut. Życzymy smacznego!" ;
            }
            else
            {
                label2.Text = "Błąd. Podano nieprawidłowe dane";
            }
        }
    }
}
