using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }
        personuppgifter nyperson = new personuppgifter();
        public string Personnummer { get; set; }
        public string Namn { get; set; }
        public string Adress { get; set; }
        public string Mail { get; set; }
        public string Saldo { get; set; }

        private void Bank_Load(object sender, EventArgs e)
        {
            

        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            nyperson.Personnummer = txtPersonmr.Text;
            nyperson.getpersonuppgifter(this);

            txtNamn.Text = Namn;
            txtMail.Text = Mail;
            txtPersonnummer.Text = Personnummer;
            txtSaldo.Text = Saldo;
            txtAdress.Text = Adress;
        }
    }
}
