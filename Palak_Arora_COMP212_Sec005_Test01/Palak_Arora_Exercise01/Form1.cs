using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;

namespace Palak_Arora_Exercise01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int inputNumber = Int32.Parse(textBox3.Text);
            if (inputNumber % 2 == 0)
            {
                MessageBox.Show(inputNumber + " is an Even Number");

            }
            else
            {
                MessageBox.Show(inputNumber + " is a Odd Number");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            result.Text = "Getting all the primes number till " + input.Text;
            string s = " ";
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
                int i, num, enno, ctr;
                enno = Int32.Parse(input.Text);
                int range = Int32.Parse(input.Text);
                for (num = 1; num <= enno; num++)
                {
                    ctr = 0;

                    for (i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            ctr++;
                            break;
                        }
                    }
                    if (ctr == 0 && num != 1)
                        s = s + " \n " + num;
                }

            });
            result.Text = s;
        }
    }
    }

