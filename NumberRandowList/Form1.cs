using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberRandowList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();
            string[] txt = textBox1.Text.Split(',');
            List<int> arrayNumber=new List<int>();
            string msg = "";
            int number = 0;
            if (txt.Length<12)
            {
                MessageBox.Show("კომბინაციისთვის აუცილებელია 12 რიცხვი იყოს შეტანილი!");
            }
            else
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    number = Convert.ToInt32(txt[random.Next(txt.Length)]);
                   

                    if (arrayNumber.Contains(number))
                    {
                        i--;
                        continue;
                    }
                    arrayNumber.Add(number);
                    msg += number.ToString() + ", ";
                    if (arrayNumber.Count==12)
                    {
                        dataGridView1.Rows.Add(msg);
                        break;
                    }
                }
            }
        }
    }
}
