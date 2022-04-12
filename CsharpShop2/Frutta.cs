using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop2
{
    internal class Frutta : Prodotto
    {

        private double peso;

        public Frutta(string nome, string descrizione, double peso, double prezzo, int iva) : base(nome, descrizione, prezzo, iva)
        {
           
        }

        public override void StampaProdotto()
        {
            Console.WriteLine("----- Prodotto -------");
            Console.WriteLine("Codice: " + codice);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Descrizione: " + descrizione);
            Console.WriteLine($"Peso: {prezzo}kg");
            Console.WriteLine($"Prezzo: {prezzo} euro");
            Console.WriteLine($"IVA: {iva}%");
            Console.WriteLine($"Prezzo finale: {PrezzoPiuIva(prezzo, iva)} euro");
            Identificativo(codice, nome);
            PadLeft();
            Console.WriteLine("------------------");

        }


    }
}

