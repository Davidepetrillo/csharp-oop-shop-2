﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop2
{
    internal class Acqua : Prodotto
    {
        private int numeroBottiglie;
        private double litri;
        public string materialeBottiglie;
        public double ph;
        public string sorgente;
        public double litriDisponibili;

        public Acqua(string nome, string descrizione, double prezzo, int iva, int numeroBottiglie, double litri, string materiale, double ph, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            this.numeroBottiglie = numeroBottiglie;
            this.litri = litri;
            this.materialeBottiglie = materiale;
            this.ph = ph;
            this.sorgente = sorgente;
            this.litriDisponibili = 0;
            
        }

        public void Bevi(double litriDaBere)
        {
            if (this.litri - litriDaBere > 0)
            {
                this.litri = this.litri - litriDaBere;
                Console.WriteLine($"Ho bevuto {litriDaBere} litri");
                Console.WriteLine($"Mi restano {this.litri} litri da bere");

            }
            else
            {
                Console.WriteLine("Mi dispiace ma la bottiglia è finita");
                this.litri = 0;
            }
        }


        
        public void Riempi(double litriCheRiempio)
        {
            double bottigliaDopoEssereStataRiempita = litriDisponibili + litriCheRiempio;
            if (litriCheRiempio < 0)
            { 
                Console.WriteLine($"Nope");
                return;

            }
            if(bottigliaDopoEssereStataRiempita < litri)
            {
                litriDisponibili = bottigliaDopoEssereStataRiempita;
                Console.WriteLine($"Ho riempito la bottiglia con : {bottigliaDopoEssereStataRiempita} litri");
            }
            else
            {
                Console.WriteLine("Mi dispiace ma hai traboccato");
                litriDisponibili = litri;
            }
        }
        
        public void Svuota(double litriCheSvuoto)
        {
            if(litriCheSvuoto >= litri)
            {
                Console.WriteLine("Hai svuotato tutta la bottiglia");
            } else
            {
                litriDisponibili = litri - litriCheSvuoto;
                Console.WriteLine($"Ho svuotato {litriCheSvuoto} litri");
                Console.WriteLine($"Mi restano {litriDisponibili} litri");
            }
        }

        public static void ConvertiInGalloni(double litri)
        {
            const double CostanteDiConversione = 3.785;
            double ConversioneLitriInGalloni = litri * CostanteDiConversione;
            Console.WriteLine($"Galloni: {ConversioneLitriInGalloni} galloni");
        }


        public override void StampaProdotto()
        {
            Console.WriteLine("----- Prodotto -------");
            Console.WriteLine("Codice: " + codice);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Descrizione: " + descrizione);
            Console.WriteLine($"Numero bottiglie: {numeroBottiglie}");
            Console.WriteLine($"Litri: {litri}/bottiglia");
            ConvertiInGalloni(litri);
            Console.WriteLine($"Materiale bottiglie: {materialeBottiglie}");
            Console.WriteLine($"Prezzo: {prezzo} euro");
            Console.WriteLine($"IVA: {iva}%");
            Console.WriteLine($"Prezzo finale: {PrezzoPiuIva(prezzo, iva)} euro");
            Identificativo(codice, nome);
            PadLeft();
            Console.WriteLine("------------------");
        }



    }
}
