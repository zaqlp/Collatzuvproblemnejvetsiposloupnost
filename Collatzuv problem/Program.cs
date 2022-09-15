// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string zadanecislo;
long i;
long count = 0;
long start =1;
long startulozeni = 0;
long pocet =0;
long pocetulozeni =0;
//zadanecislo =Console.ReadLine();
long cil = 1;
//cil= long.Parse(zadanecislo);
while (true)
{
    cil++;
    pocetulozeni = 0;
    start = 1;
    count = 0;
    while (true)
    {

        if (pocet == pocetulozeni)
        {
            count++;

            if (count == cil) break;

            startulozeni = start;
        }
        else
        {
            count = 0;
        }
        pocetulozeni = pocet;
        start++;

        i = start;


        pocet = 0;
        while (i > 1)
        {

            if (i % 2 == 0)
            {

                i = i / 2;

                pocet++;
            }
            else
            {

                i = i * 3;
                i++;

                pocet++;
            }
        }


    }
    Console.WriteLine(pocetulozeni);
    Console.WriteLine(start);
    Console.WriteLine(cil);

}
