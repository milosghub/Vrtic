using BusinessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormaDeca : Form
    {
        private readonly DecaBusiness decaBusiness;
        public FormaDeca()
        {
            this.decaBusiness = new DecaBusiness();
            InitializeComponent();
        }

        private void FormaDeca_Load(object sender, EventArgs e)
        {
            RefreshData();  
        }

        private void RefreshData()
        {
            List<Deca> listaDece = this.decaBusiness.GetAllChildren();
            dataGridView_Deca.DataSource = listaDece;
        }

        private void button_Dodaj_Click(object sender, EventArgs e)
        {
            if (textBox_ime.Text == "" || textBox_prezime.Text == "" || textBox_ime_majke.Text == "" || textBox_ime_oca.Text == "" || textBox_datum_rodjenja.Text == "" || textBox_mesto_rodjenja.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!Regex.Match(textBox_ime.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("Naziv nije pravilno unet!", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.Match(textBox_prezime.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("Prezime nije pravilno uneto!", "Message",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.Match(textBox_ime_majke.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("Ime majke nije pravilno uneto!", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.Match(textBox_ime_oca.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("Ime oca nije pravilno uneto!", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!Regex.Match(textBox_mesto_rodjenja.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("Mesto rodjenja nije pravilno uneto!", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Deca d = new Deca();
            d.ime = textBox_ime.Text;
            d.prezime = textBox_prezime.Text;
            d.ime_majke = textBox_ime_majke.Text;
            d.ime_oca = textBox_ime_oca.Text;
            d.datum_rodjenja = textBox_datum_rodjenja.Text;
            d.mesto_rodjenja = textBox_mesto_rodjenja.Text;



            if (this.decaBusiness.InsertChildren(d))
            {
                RefreshData();
                MessageBox.Show("Uspesno ste uneli podatke! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_ime.Clear();
                textBox_prezime.Clear();
                textBox_ime_majke.Clear();
                textBox_ime_oca.Clear();
                textBox_datum_rodjenja.Clear();
                textBox_mesto_rodjenja.Clear();
            }
            else
            {
                MessageBox.Show("Neuspesan unos podataka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int ID; 
        private void dataGridView_Deca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView_Deca.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox_ime.Text = dataGridView_Deca.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_prezime.Text = dataGridView_Deca.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_ime_majke.Text = dataGridView_Deca.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox_ime_oca.Text = dataGridView_Deca.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox_datum_rodjenja.Text = dataGridView_Deca.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox_mesto_rodjenja.Text = dataGridView_Deca.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button_Izmeni_Click(object sender, EventArgs e)
        {
            if (textBox_ime.Text == "" || textBox_prezime.Text == "" || textBox_ime_majke.Text == "" || textBox_ime_oca.Text == "" || textBox_datum_rodjenja.Text == "" || textBox_mesto_rodjenja.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_ime.Focus();
                return;
            }

            if (!Regex.Match(textBox_ime.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("Naziv nije pravilno unet!", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.Match(textBox_prezime.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("Prezime nije pravilno uneto!", "Message",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Deca d = new Deca();
            d.ime = textBox_ime.Text;
            d.prezime = textBox_prezime.Text;
            d.ime_majke = textBox_ime_majke.Text;
            d.ime_oca = textBox_ime_oca.Text;
            d.datum_rodjenja = textBox_datum_rodjenja.Text;
            d.mesto_rodjenja = textBox_mesto_rodjenja.Text;

            d.id_deteta = ID;

            if (this.decaBusiness.UpdateChildren(d))
            {
                RefreshData();
                MessageBox.Show("Uspesno ste izmenili podatke! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_ime.Clear();
                textBox_prezime.Clear();
                textBox_ime_majke.Clear();
                textBox_ime_oca.Clear();
                textBox_datum_rodjenja.Clear();
                textBox_mesto_rodjenja.Clear();
            }
            else
            {
                MessageBox.Show("Neuspesna izmena podataka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Obrisi_Click(object sender, EventArgs e)
        {
            if (textBox_delete.Text == "")
            {
                MessageBox.Show("Morate uneti ID deteta koje zelite da obrisete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Deca d = new Deca();

            d.id_deteta = Convert.ToInt32(textBox_delete.Text);

            if (this.decaBusiness.DeleteChildren(d))
            {
                RefreshData();
                MessageBox.Show("Uspesno ste obrisali podatak! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Niste obrisali podatak!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sign_out_Click(object sender, EventArgs e)
        {
            FormaDeca formadeca = new FormaDeca();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
