using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCorso
{
    internal class Persona
    {
        internal Persona(string Nome, string Cognome, DateOnly DataDiNascita)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.DataDiNascita = DataDiNascita;
        }

        internal string Nome { get; set; } // Proprietà, permettere di leggere e scrivere (get e set)
        internal string Cognome { get; set; }
        internal string CF { get; set; }
        internal string Email { get; set; }
        internal string Indirizzo { get; set; }
        internal DateOnly DataDiNascita { get; set; }

        // Useremo questa funzione per printare le 3 info principali
        public void DisplayBasicInfo()
        {
            Console.WriteLine("Nome: " + this.Nome + "\n" + "Cognome: " + this.Cognome + "\n" + "Data di Nascita: " + this.DataDiNascita);
        }
    }
}
