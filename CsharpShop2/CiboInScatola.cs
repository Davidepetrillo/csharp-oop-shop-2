using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop2
{
    internal class CiboInScatola : Prodotto
    {
        private double peso;
        private string scadenza;
        private int numeroScatole;

        // con 'base' stiamo chiamando il costruttore della classe prodotto (costruttore della classe base)
        public CiboInScatola(string nome, string descrizione,int numeroScatole, double peso, double prezzo, int iva, string scadenza) : base(nome, descrizione, prezzo, iva)
        {
            this.peso = peso;
            this.scadenza = scadenza;
            this.numeroScatole = numeroScatole;
        }

        public override void StampaProdotto()
        {
            Console.WriteLine("----- Prodotto -------");
            Console.WriteLine("Codice: " + codice);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Descrizione: " + descrizione);
            Console.WriteLine($"Numero scatole: {numeroScatole}");
            Console.WriteLine($"Peso: {peso}gr/scatola");
            Console.WriteLine($"Scadenza: {scadenza}");
            Console.WriteLine($"Prezzo: {prezzo} euro");
            Console.WriteLine($"IVA: {iva}%");
            Console.WriteLine($"Prezzo finale: {PrezzoPiuIva(prezzo, iva)} euro");
            Identificativo(codice, nome);
            PadLeft();
            Console.WriteLine("------------------");
        }
    }
}
