using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace iskola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        public class diak
        {

            public int kezdetev { get; set; }
            public string osztaly { get; set; }
            public string nev { get; set; }
            public diak(string sor)
            {
            string[] sorelemek = sor.Split(';');
                kezdetev = int.Parse(sorelemek[0]);
                osztaly = sorelemek[1];
                nev = sorelemek[2];


            }
        }

        public static List<diak> diaks = new List<diak>();
        static void Main(string[] args)
        {

            StreamReader olvas = new StreamReader("nevek.txt", Encoding.UTF8);
            string fejlec = olvas.ReadLine();//ha van fejléc
            while (!olvas.EndOfStream)
            {
                diaks.Add(new diak(olvas.ReadLine()));
            }

        }

            class JelszóGeneráló
        {
            private Random Rnd;

            public JelszóGeneráló(Random r)
            {
                Rnd = r;
            }

            public string Jelszó(int jelszóHossz)
            {
                string jelszó = "";
                while (jelszó.Length < jelszóHossz)
                {
                    char c = (char)Rnd.Next(48, 123);
                    if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'z'))
                    {
                        jelszó += c;
                    }
                }
                return jelszó;




            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            {

                StreamReader olvas = new StreamReader("nevek.txt", Encoding.UTF8);
                string fejlec = olvas.ReadLine();//ha van fejléc
                while (!olvas.EndOfStream)
                {
                    diaks.Add(new diak(olvas.ReadLine()));
                }

            }
        }
    }
    
}
