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
        int nm = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();
            string[] txt = textBox1.Text.Split(',');
            List<int> arrayNumber=new List<int>();
            string msg = "";
            int number = 0;
            List<string> AddCollection = new List<string>();
            List<string> duplicate = new List<string>();
            int dupl = 0;
            if (txt.Length<12)
            {
                MessageBox.Show("კომბინაციისთვის აუცილებელია 12 რიცხვი იყოს შეტანილი!");
            }
            else
            {
                for (int g = 0; g < txt.Length; g++)
                {
                    if (duplicate.Contains(txt[g]))
                    {
                        dupl++;
                        break;
                    }
                    else
                    {
                        duplicate.Add(txt[g]);
                    }
                }
                if (dupl==0)
                {
                    nm = 0;
                    dataGridView1.Rows.Clear();
                    for (int j = 0; j < 50; j++)
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
                            if (arrayNumber.Count == 12)
                            {
                                if (AddCollection.Contains(msg))
                                {
                                    j--;
                                    i=0;
                                    break;
                                }
                                else
                                {
                                    arrayNumber = new List<int>();
                                    AddCollection.Add(msg);
                                    nm++;
                                    dataGridView1.Rows.Add(nm, msg);
                                    msg = "";
                                    break;
                                }

                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("სიაში ერთნაირი რიცხვებია მითითება არ შეიძლება!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    dupl = 0;
                    duplicate = new List<string>();
                    dataGridView1.Rows.Clear();
                }
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
