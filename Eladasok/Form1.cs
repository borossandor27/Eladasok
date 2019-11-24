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

namespace Eladasok
{
    public partial class Form1 : Form
    {
        string filter = "Minden fájl (*.*)|*.*|Szövegfájl (*.txt)|*.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Listahozad_Click(object sender, EventArgs e)
        {
            string nev = textBox_Vevo_neve.Text.Trim();
            try
            {
                if (checkBox_Maganszemely.Checked)
                {
                    listBox_Vasarlasok.Items.Add(new Maganszemely(nev, textBox_Adoazonosito.Text.Trim(), dateTimePicker_Szuletett.Value, numeric_Vasarlas_osszege.Value));
                }
                else
                {
                    listBox_Vasarlasok.Items.Add(new Vallalkozas(nev, textBox_Adoazonosito.Text.Trim(), numeric_Vasarlas_osszege.Value));
                }
                textBox_Vevo_neve.Text = "";
                textBox_Adoazonosito.Text = "";
                checkBox_Maganszemely.Checked = false;
            }
            catch (AdatbeviteliHiba ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_Adoazonosito_TextChanged(object sender, EventArgs e)
        {
            string input = new string(textBox_Adoazonosito.Text.Where(c => char.IsDigit(c) || c.Equals('-')).ToArray());
        }

        private void checkBox_Maganszemely_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Maganszemely.Checked)
            {
                dateTimePicker_Szuletett.Enabled = true;
            }
            else
            {
                dateTimePicker_Szuletett.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker_Szuletett.Value = DateTime.Today.AddYears(-30);
            dateTimePicker_Szuletett.MinDate = DateTime.Today.AddYears(-150);
            dateTimePicker_Szuletett.MaxDate = DateTime.Today.AddYears(-14);
            saveFileDialog1.Filter = openFileDialog1.Filter = filter;
            saveFileDialog1.FilterIndex = openFileDialog1.FilterIndex = 2;
            saveFileDialog1.FileName = openFileDialog1.FileName = "Vasarlasok.txt";
            saveFileDialog1.InitialDirectory = openFileDialog1.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
        }

        private void button_Kiir_fajlba_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        if (listBox_Vasarlasok.Items.Count > 0)
                        {
                            foreach (var item in listBox_Vasarlasok.Items)
                            {
                                if (item.GetType() == typeof(Maganszemely))
                                {
                                    Maganszemely o = (Maganszemely)item;
                                    sw.WriteLine(o.toTXT());
                                }
                                else
                                {
                                    Vallalkozas o = (Vallalkozas)item;
                                    sw.WriteLine(o.toTXT());
                                }
                            }
                        }
                        listBox_Vasarlasok.Items.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void button_Beolvas_fajlbol_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        listBox_Vasarlasok.Items.Clear();
                        while (!sr.EndOfStream)
                        {
                            string[] sor = sr.ReadLine().Split(';');
                            if (sor[0].Equals("m"))
                            {
                                string nev = sor[2];
                                DateTime szuletett = DateTime.Parse(sor[3]);
                                string adoszam = sor[4];
                                decimal osszeg = decimal.Parse(sor[5]);
                                listBox_Vasarlasok.Items.Add(new Maganszemely(nev, adoszam, szuletett, osszeg));
                            }
                            else
                            {
                                string nev = sor[2];
                                string adoszam = sor[3];
                                decimal osszeg = decimal.Parse(sor[4]);
                                listBox_Vasarlasok.Items.Add(new Vallalkozas(nev, adoszam, osszeg));
                            }
                        }
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message);
                }
            }
        }

        private void button_Listabol_torol_Click(object sender, EventArgs e)
        {
            if (listBox_Vasarlasok.SelectedIndex >= 0)
            {
                listBox_Vasarlasok.Items.RemoveAt(listBox_Vasarlasok.SelectedIndex);
            }
        }
    }
}
