using CsharpShop2;

Prodotto Cereali = new Prodotto("Cereali", "Cereali a base di miele e cannella ", 1.99, 17);
Frutta Banana = new Frutta("Banana", "Banane coltivate in Brasile e prodotte in Guatemala", 1.69, 19);
Acqua Lete = new Acqua("Lete", "L’acqua che il tuo corpo vuole", 2.19, 18, 6, 1.5, "plastica", 6.30, "Appennino meridionale");
Elettrodomestico Lavatrice = new Elettrodomestico("Lavatrice", "Samsung Elettrodomestici WD10T534DBW/S3", 70, 10.5, 1400, 60, 60, 85, "bianco", 679.00, 22);
CiboInScatola Tonno = new CiboInScatola("Tonno", "Nostromo - Tonno Leggero all'Olio di Oliva con -60% di Grassi, Qualità Pinne Gialle, Senza Conservanti", 6, 60, 2.99, 8, "12/09/2023");

Cereali.StampaProdotto();
Banana.StampaProdotto();
Lete.StampaProdotto();
Lavatrice.StampaProdotto();
Tonno.StampaProdotto();
