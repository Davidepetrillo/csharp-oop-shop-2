using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop2
{
    internal class Elettrodomestico : Prodotto
    {
        private double peso;
        private double capacità;
        private int giri;
        private double larghezza;
        private double altezza;
        private double profondità;
        private string colore;



        public Elettrodomestico(string nome, string descrizione, double peso, double capacità, int giri, double larghezza, double altezza, double profondità, string colore, double prezzo, int iva) : base(nome, descrizione, prezzo, iva)
        {
            this.peso = peso;
            this.capacità = capacità;
            this.giri = giri;
            this.larghezza = larghezza;
            this.altezza = altezza;
            this.profondità = profondità;
            this.colore = colore;
        }
        public override void StampaProdotto()
        {
            Console.WriteLine("----- Prodotto -------");
            Console.WriteLine("Codice: " + codice);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Descrizione: " + descrizione);
            Console.WriteLine($"Peso: {peso} kg");
            Console.WriteLine($"Capacità: {capacità} kg");
            Console.WriteLine($"Giri: {giri} giri");
            Console.WriteLine($"Dimensioni: {larghezza} x {altezza} x {profondità} cm");
            Console.WriteLine($"Colore: {colore}");
            Console.WriteLine($"Prezzo: {prezzo} euro");
            Console.WriteLine($"IVA: {iva}%");
            Console.WriteLine($"Prezzo finale: {PrezzoPiuIva(prezzo, iva)} euro");
            Identificativo(codice, nome);
            PadLeft();
            Console.WriteLine("------------------");
        }



    }
}

