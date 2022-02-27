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
using System.Diagnostics;

namespace KalkulatorAdvanced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            Broj b = Operacije.PretvoriUBroj("VIII");
            Debug.WriteLine(b.PretvoriUString());

        }
        public void Ispisi(Broj num)
        {
            rt3.Text = "";
            if (num.pozitivan == false) rt3.Text = "-";
            rt3.Text = rt3.Text + num.PretvoriUString();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Debug.WriteLine(saveFileDialog1.FileName);

                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                
                Debug.WriteLine(saveFileDialog1.FileName);  

                sw.WriteLine(rt1.Text);
                sw.WriteLine(rt2.Text);

                sw.Close();
            }

        }

        private void ImportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "*.txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamReader sr = new StreamReader(openFileDialog1.FileName);


                rt1.Text = sr.ReadLine();
                rt2.Text = sr.ReadLine();
            }
        }

        private void buttonSaberi_Click(object sender, EventArgs e)
        {
            Broj a = new Broj(rt1.Text);
            a.pozitivan = broj1Plus.Checked;

            Broj b = new Broj(rt2.Text);
            b.pozitivan = broj2Plus.Checked;

            Broj rezultat = new Broj();

            if(a.pozitivan == true)
            {
                if (b.pozitivan == true) rezultat = Operacije.Sabiranje(a, b);
                else rezultat = Operacije.Oduzimanje(a, b);
            }
            else
            {
                if (b.pozitivan == true) rezultat = Operacije.Oduzimanje(b, a);
                else
                {
                    rezultat = Operacije.Sabiranje(a, b);
                    rezultat.pozitivan = false;
                }
            }

            Ispisi(rezultat);

        }

        private void buttonOduzmi_Click(object sender, EventArgs e)
        {
            Broj a = new Broj(rt1.Text);
            a.pozitivan = broj1Plus.Checked;

            Broj b = new Broj(rt2.Text);
            b.pozitivan = broj2Plus.Checked;

            Broj rezultat = new Broj();


            if (a.pozitivan == true)
            {
                if (b.pozitivan == true) rezultat = Operacije.Oduzimanje(a, b);
                else rezultat = Operacije.Sabiranje(a, b);
            }
            else
            {
                if (b.pozitivan == true)
                {
                    rezultat = Operacije.Sabiranje(a, b);
                    rezultat.pozitivan = false;
                }
                else
                {
                    rezultat = Operacije.Oduzimanje(b, a);
                }
            }

            Ispisi(rezultat);
        }

        private void buttonPomnozi_Click(object sender, EventArgs e)
        {
            Broj a = new Broj(rt1.Text);
            a.pozitivan = broj1Plus.Checked;

            Broj b = new Broj(rt2.Text);
            b.pozitivan = broj2Plus.Checked;

            Broj rezultat = Operacije.Mnozenje(a, b);
            Ispisi(rezultat);
        }

        private void buttonPodeli_Click(object sender, EventArgs e)
        {
            Broj a = new Broj(rt1.Text);
            a.pozitivan = broj1Plus.Checked;

            Broj b = new Broj(rt2.Text);
            b.pozitivan = broj2Plus.Checked;

            Broj rezultat = Operacije.Deljenje(a, b);
            Ispisi(rezultat);
        }

        private void rimskiSaberi_Click(object sender, EventArgs e)
        {

        }

        private void rimskiMinus_Click(object sender, EventArgs e)
        {

        }

        private void rimskiPomnozi_Click(object sender, EventArgs e)
        {

        }

        private void rimskiPodeli_Click(object sender, EventArgs e)
        {

        }
    }
}
