using BusinessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LogIn : Form
    {
        private readonly ZaposlenBusiness zaposlenBusiness;
        public LogIn()
        {
            this.zaposlenBusiness = new ZaposlenBusiness();
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            List<Zaposlen> listaZaposlenih = this.zaposlenBusiness.GetAllEmployees();
            bool tacno = false;

            foreach (Zaposlen z in listaZaposlenih)
            {
                if (z.username == textBox_KorisnickoIme.Text && z.password == textBox_Sifra.Text)
                {
                    FormaDeca forma = new FormaDeca();
                    forma.Show();
                    tacno = true;
                }

            }

            if (tacno == false)
            {
                MessageBox.Show("Niste ispravno uneli podatke!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }    
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
