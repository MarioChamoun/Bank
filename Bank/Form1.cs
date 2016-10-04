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
            if (txtPersonmr.Text == "")
            {
                MessageBox.Show("Skriv in ett personnummer.");
            }
            else
            {

                try
                {
                    nyperson.Personnummer = txtPersonmr.Text;
                    nyperson.getpersonuppgifter(this);

                }
                catch (Exception b)
                {
                    MessageBox.Show(b.Message);
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\Mario\Desktop\Github\Bank\error.txt", true))
                    {
                        writer.WriteLine("Message: " + b.Message  + Environment.NewLine + "Date: " + DateTime.Now.ToString());
                        writer.WriteLine(Environment.NewLine + "----------------------------------");
                    }
                }
                txtNamn.Text = Namn;
                txtMail.Text = Mail;
                txtPersonnummer.Text = Personnummer;
                txtSaldo.Text = Saldo;
                txtAdress.Text = Adress;
            }
        }
    }
}
