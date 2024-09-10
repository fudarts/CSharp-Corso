using System.Text;
using CSharpCorso; // Userà le nostre librerie
// Dichiarazione di variabile di tipo intero + assegnazione
int a = 5; 
int c = 1;
// char d = 'a';
string nome = "pluto";
string cognome = "paperino";
// "b" sarà vero solo se "a" è diverso da 10 OPPURE se "c" è uguale a 5
bool b = a != 10 || c == 10;

// ESEMPIO WriteLine:
Console.WriteLine(b); // Sarà true

// ESEMPIO SWITCH:
switch (b)
{
    case true:
        Console.WriteLine("True!"); //<-- Uscirà true
        break;
    case false:
        Console.WriteLine("False!");
        break;
}

// ESEMPIO WHILE
int i = 0;
while (i < 10)
{
    if(i % 2 != 0)
    {
        i++;
        continue;
    }
    Console.WriteLine(i); //Printerà solo numeri pari fino all'8
    i++;
}

string valori = "1,2,3,4,5";
// Separatore, in questo caso da ogni virgola
string[] result = valori.Split(','); 
// Printerà il valore 4, che in questo caso è 5
Console.WriteLine(result[4]); 

// Stessa cosa ma con il nome pluto
string[] resultNome = nome.Split('u');
// Printerà "pl" essendo diviso dalla u, ma se metto 1 printerà "to"
Console.WriteLine(resultNome[0]); 

// Sempre un metodo per creare un array ma con "ToArray()"
string caratteri = "a b c d e";
// Sostituisce il primo valore (che sarebbe lo spazio) con il secondo valore (che sarebbe nulla, quindi cancellando gli spazi)
string carPulizia = caratteri.Replace(" ", ""); 
char[] caratteriArray = carPulizia.ToArray();
// Viene divisa automanticamente ogni lettera, in questo caso printerà "c"
Console.WriteLine(caratteriArray[2]);

// ESEMPIO FOR
// Printerà ogni lettera di "caratteriArray", assegnandogli un valore numerico
for (int j = 0; j < caratteriArray.Length; j++)
{
    Console.WriteLine("Il valore di [" + j + "] è: " + caratteriArray[j]);
}

// ESEMPIO FOREACH
foreach (string item in result)
{
    Console.WriteLine("Il valore dell'elemento corrente è: " + item);
}

// Metodo per creare una serie di stringhe
StringBuilder myBuilder = new StringBuilder(); //Dichiarazione di una variabile
myBuilder.Append(nome);
myBuilder.Append(" - ");
myBuilder.Append(cognome);
Console.WriteLine(myBuilder.ToString());

// typeof ci dice il corso della determinata classe, in questo caso creata da me
Console.WriteLine(typeof(Persona));

// Creo l'oggetto e gli assegno dei dati
Persona persona1 = new Persona("Massimo", "Dolore", new DateOnly(2001, 7, 23));
// In questo caso lo sto assegnando manualmente
persona1.CF = "AF3FS3SCNG54HI5";
persona1.Email = "gianmarchini82@gmail.com";

// Adesso printo tutto, con un metodo scritto in person.cs
persona1.DisplayBasicInfo();

/* Una volta creata la funzione sarà possibile usarla per
 * calcolare l'età della persona, tuttavia ho scelto di
 * rendere la funzione privata e di trasformarla in
 * una proprietà dell'oggetto.
 */
// Così è come sarebbe con la funzione
// Console.WriteLine(persona1.GetAge());

// Così invece chiamiamo la funzione attraverso la proprietà
Console.WriteLine(persona1.Age);

// Andiamo a definire un employee
Employee employee1 = new Employee("Samuele", "Pescatore", new DateOnly(2002, 11, 18), 1, "Spy Agency", 100000.00M);

// Questo comando triggera l'ArgumentException come prova
// employee.CompanyName = "";

// Andiamo a stampare tutto
employee1.DisplayBasicInfo();
Console.WriteLine("Età: " + employee1.Age);


