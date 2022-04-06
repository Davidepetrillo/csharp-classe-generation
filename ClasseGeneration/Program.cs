int numeroPartecipantiAlMomento = 0;
int maxPartecipantiAlCorso = 10;
string[] nomiPartecipantiAlCorso = new string[maxPartecipantiAlCorso];
string[] cognomiPartecipantiAlCorso = new string[maxPartecipantiAlCorso];
int[] etaPartecipantiAlCorso = new int[maxPartecipantiAlCorso];


// ---------- Funzioni ----------

/*
void StampaInfoAlunni(string[] array)
{
    int ultimoIndiceArray = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}
*/

void aggiungiAlunno(string nome, string cognome, int eta)
{
    if (numeroPartecipantiAlMomento < maxPartecipantiAlCorso)
    {
        nomiPartecipantiAlCorso[numeroPartecipantiAlMomento] = nome;
        cognomiPartecipantiAlCorso[numeroPartecipantiAlMomento] = cognome;
        etaPartecipantiAlCorso[numeroPartecipantiAlMomento] = eta;
        numeroPartecipantiAlMomento++;
    }
    else
    {
        Console.WriteLine("Mi dispiace ma non abbiamo più posti disponibili in qusto corso");
    }
}

void rimuoviAlunno()
{
    if(numeroPartecipantiAlMomento > 0)
    {
        numeroPartecipantiAlMomento--;
        nomiPartecipantiAlCorso[numeroPartecipantiAlMomento] = "";
        cognomiPartecipantiAlCorso[numeroPartecipantiAlMomento] = "";
       
    } else
    {
        Console.WriteLine("Mi dispiace ma al momento non abbiamo nessun partecipante iscritto al corso");
    }
}



// -------------- Programma ---------------------


while (true)
{
    Console.Write("Vuoi aggiungerti in questa classe [si/no] ? ");
    string rispostaPrimaDomanda = Console.ReadLine();
    switch (rispostaPrimaDomanda) { 


        case "si":
        Console.Write("Inserisci il tuo nome: ");
        string rispostaNome = Console.ReadLine();
            Console.Write("Inserisci il tuo cognome: ");
            string rispostaCognome = Console.ReadLine();
            Console.Write("Inserisci la tua età: ");
            string rispostaEta = Console.ReadLine();
            int rispostaEtaConvertita = int.Parse(rispostaEta);
            aggiungiAlunno(rispostaNome, rispostaCognome, rispostaEtaConvertita);
        break;

        case "no":

        Console.Write("Vuoi rimuovere il tuo identificativo da questa classe [si/no] ? ");
        string rispostaSecondaDomanda = Console.ReadLine();

            if (rispostaSecondaDomanda == "si")
            {
                rimuoviAlunno();
            }
            else if (rispostaSecondaDomanda == "no")
            {
                Console.Write("Grazie per il tuo tempo");
                break;
            }
        break;
    
        default:
    
        Console.WriteLine("Mi dispiace ma la tua risposta non può essere interpretata.");
        break;
    }

    Console.WriteLine($"Al momento il numero di partecipanti al corso è {numeroPartecipantiAlMomento}");
    Console.Write($"I nomi dei partecipanti al momento sono: ");
    Console.WriteLine();

    for (int i = 0; i < nomiPartecipantiAlCorso.Length; i++)
    {
        Console.Write($"{nomiPartecipantiAlCorso[i]} - ");  
    }
    Console.WriteLine();
    Console.Write("I cognomi dei partecipanti al momento sono: ");
    Console.WriteLine();

    for (int i = 0; i < nomiPartecipantiAlCorso.Length; i++)

    {
        Console.Write($"{cognomiPartecipantiAlCorso[i]} - ");
    }
    Console.WriteLine();
    Console.Write("L'età dei partecipanti al momento è: ");
    Console.WriteLine();

    for (int i = 0; i < etaPartecipantiAlCorso.Length; i++)
    {
        Console.Write($"{etaPartecipantiAlCorso[i]} - ");
    }
    Console.WriteLine();



}
