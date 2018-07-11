using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decimal2anything
{
    public partial class Form1 : Form
    {
        string convertedtext;
        public Form1()
        {
            InitializeComponent();
            value.Text = "0";
            comboBox1.SelectedIndex = 0;
            
        }

        public void convert()
        {
            convertedtext = "";
            int sayi = 0;
            sayi = Convert.ToInt32(value.Text);
            string def;
            def = "";
            if (comboBox1.SelectedIndex == 0)
            {
                while (sayi > 0)
                {
                    if (sayi % 2 == 0)
                    {
                        def += "0";
                    }
                    else if (sayi % 2 == 1)
                    {
                        def += "1";
                    }
                    sayi = sayi / 2;
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                while(sayi > 0)
                {
                    if (sayi % 8 == 0)
                    {
                        def += "0";
                    }
                    else if (sayi % 8 == 1)
                    {
                        def += "1";
                    }
                    else if (sayi % 8 == 2)
                    {
                        def += "2";
                    }
                    else if (sayi % 8 == 3)
                    {
                        def += "3";
                    }
                    else if (sayi % 8 == 4)
                    {
                        def += "4";
                    }
                    else if (sayi % 8 == 5)
                    {
                        def += "5";
                    }
                    else if (sayi % 8 == 6)
                    {
                        def += "6";
                    }
                    else if (sayi % 8 == 7)
                    {
                        def += "7";
                    }
                    sayi = sayi / 8;
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                while (sayi > 0)
                {
                    if (sayi % 16 == 0)
                    {
                        def += "0";
                    }
                    if (sayi % 16 == 1)
                    {
                        def += "1";
                    }
                    if (sayi % 16 == 2)
                    {
                        def += "2";
                    }
                    if (sayi % 16 == 3)
                    {
                        def += "3";
                    }
                    if (sayi % 16 == 4)
                    {
                        def += "4";
                    }
                    if (sayi % 16 == 5)
                    {
                        def += "5";
                    }
                    if (sayi % 16 == 6)
                    {
                        def += "6";
                    }
                    if (sayi % 16 == 7)
                    {
                        def += "7";
                    }
                    if (sayi % 16 == 8)
                    {
                        def += "8";
                    }
                    if (sayi % 16 == 9)
                    {
                        def += "9";
                    }
                    if (sayi % 16 == 10)
                    {
                        def += "A";
                    }
                    if (sayi % 16 == 11)
                    {
                        def += "B";
                    }
                    if (sayi % 16 == 12)
                    {
                        def += "C";
                    }
                    if (sayi % 16 == 13)
                    {
                        def += "D";
                    }
                    if (sayi % 16 == 14)
                    {
                        def += "E";
                    }
                    if (sayi % 16 == 15)
                    {
                        def += "F";
                    }
                    sayi = sayi / 16;
                }
            }

            for (int i = def.Length - 1; i >= 0; i--)
            {
                convertedtext += def[i];
            }
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            convert();
            sonuc.Clear();
            sonuc.Text = convertedtext;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            convert();
            sonuc.Clear();
            sonuc.Text = convertedtext;
        }
    }

}
