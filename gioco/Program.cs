// See https://aka.ms/new-console-template for more information
using gioco.Personaggi;

Cavaliere cav1=new Cavaliere(1000);

Cavaliere[] squadraRossa = new Cavaliere[100];

for (int i = 0; i < squadraRossa.Length; i++)
{
    squadraRossa[i] = new Cavaliere(1000);
    squadraRossa[i].Squadra = "squadra rossa";
}


