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
    if (numeroPartecipantiAlMomento > 0)
    {
        numeroPartecipantiAlMomento--;
        nomiPartecipantiAlCorso[numeroPartecipantiAlMomento] = "";
        cognomiPartecipantiAlCorso[numeroPartecipantiAlMomento] = "";

    }
    else
    {
        Console.WriteLine("Mi dispiace ma al momento non abbiamo nessun partecipante iscritto al corso");
    }
}


int SommaEtaPartecipanti(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma = somma + array[i];
    }
    return somma;
}

double calcolaEtaMediaClasse(int [] array)
{
    int sommaEta = SommaEtaPartecipanti(array);
    double media = (double)sommaEta / array.Length;
    return media;
}



// -------------- Programma ---------------------


while (true)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Vuoi aggiungerti in questa classe [si/no] ? ");
    string rispostaPrimaDomanda = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine();
    switch (rispostaPrimaDomanda)
    {


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

            Console.Write("Vuoi rimuovere l'ultimo partecipante da questa classe [si/no] ? ");
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
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Al momento il numero di partecipanti al corso è {numeroPartecipantiAlMomento}");
    Console.WriteLine();
    Console.WriteLine();
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
    Console.WriteLine();

    double etaMedia = calcolaEtaMediaClasse(etaPartecipantiAlCorso);

    Console.WriteLine($"L'età media della classe in questo momento è {etaMedia}");

}