using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace Bank
{
  public class personuppgifter
    {
        public string Personnummer { get; set; }

        public void getpersonuppgifter(Bank bank)
        {
            string[] person = File.ReadAllLines(@"C:\Users\Mario\Desktop\bank.txt");

            string personuppgift = (from pers in person
                                    where pers.Contains(Personnummer)
                                    select pers).First();


            string[] info = personuppgift.Split(':');
            bank.Namn = info[0];
            bank.Personnummer = info[1];
            bank.Mail = info[2];
            bank.Adress = info[3];
            bank.Saldo = info[4];

        }  
        }
    }
