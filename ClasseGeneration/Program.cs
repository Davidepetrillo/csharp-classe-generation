int numeroPartecipantiAlMomento = 0;
int maxPartecipantiAlCorso = 10;
string[] nomiPartecipantiAlCorso = new string[maxPartecipantiAlCorso];
/*
string[] cognomiPartecipantiAlCorso = new string[maxPartecipantiAlCorso];
int[] etaPartecipantiAlCorso = new int[maxPartecipantiAlCorso];
*/

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

void aggiungiAlunno(string nome)
{
    if (numeroPartecipantiAlMomento < maxPartecipantiAlCorso)
    {
        nomiPartecipantiAlCorso[numeroPartecipantiAlMomento] = nome;
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
        aggiungiAlunno(rispostaNome);
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
    
        Console.Write("Mi dispiace ma la tua risposta non può essere interpretata");
        break;
    }

    Console.WriteLine($"Al momento il numero di partecipanti al corso è {numeroPartecipantiAlMomento}");
    for(int i = 0; i < nomiPartecipantiAlCorso.Length; i++) 
    {
    Console.WriteLine(nomiPartecipantiAlCorso[i]);
    }


}
