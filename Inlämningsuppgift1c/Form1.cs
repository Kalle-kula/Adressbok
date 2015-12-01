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

namespace Inlämningsuppgift1c
{
    public partial class Form1 : Form
    {
        string path = @"C:\Users\Kalle\Desktop\Programmering\C#\Textfiler VS\Adressbok.txt";
        public Form1()
        {
            InitializeComponent();
        }
        void Spara (string Namn, string Adress, string Telefon, string Epost, string Postnummer, string Ort)
        {
            StreamWriter sw = new StreamWriter(path, true); //Skapar streamwriter till pathen som angivits ovan, true gör att den inte skriver över annan data
            sw.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", Namn, Adress, Telefon, Epost, Postnummer, Ort);
            sw.Close();
        }

        private void buttonSpara_Click(object sender, EventArgs e)
        {
            string namn = txtNamn.Text;
            string adress = txtAdress.Text;
            string telefon = txtTelefon.Text;
            string epost = txtEpost.Text;
            string postnummer = txtPostnummer.Text;
            string ort = txtOrt.Text;
            Spara(namn, adress, telefon, epost, postnummer, ort);
            txtNamn.Text = "";
            txtAdress.Text = "";
            txtTelefon.Text = "";
            txtEpost.Text = "";
            txtPostnummer.Text = "";
            txtOrt.Text = "";
        }       
        public List<string> Ladda()
        {
            List<string> adressbok = new List<string>();
            StreamReader sr = new StreamReader(path);
            string rad = "";
            while ((rad = sr.ReadLine()) != null)
            {
                adressbok.Add(rad);
            }
            sr.Close();
            return adressbok;
        }

        private void buttonVisa_Click(object sender, EventArgs e)
        {
            List<string> lista = Ladda();
            foreach (var rad in lista)
            {
                listBox1.Items.Add(rad);
            }
            //listBox1.DataSource = lista;
        }

        private void buttonRadera_Click(object sender, EventArgs e)
        {
            List<string> infoLista = Ladda();
            List<string> lista2 = new List<string>();
            if (listBox1.SelectedIndex >= 0)
            {
                string selectedLine = listBox1.SelectedItem.ToString();

                StreamWriter myWriter = new StreamWriter(path, false);

                foreach (string rad in infoLista)
	            {
                    if (rad != selectedLine)
                    {
                        lista2.Add(rad);
                        myWriter.WriteLine(rad);
                    }
	            }
                myWriter.Close();
                listBox1.Items.Remove(listBox1.SelectedItem);
                //listBox1.DataSource = lista2;
            }
        }

        private void buttonSok_Click(object sender, EventArgs e)
        {
            string line;
            listBox1.Items.Clear();
            StreamReader file = new StreamReader(path);

            while ((line=file.ReadLine()) != null)
            {
                if (line.Contains(txtSokRuta.Text.ToString()))
                {
                    listBox1.Items.Add(line);
                }
            }
            file.Close();
            txtSokRuta.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
