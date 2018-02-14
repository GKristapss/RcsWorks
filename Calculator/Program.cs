using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleArea();
            //kaa sakartot ctrl + K D ar starplaiku w/o risk.
        }
              
    
        static void CircleArea()
        { 
        // Kur Glabat Radiusu, taisam kalkulatoru
            int radius;
        //izveidosim mainigo, kur glabat rezultatu
        double result;
        //iedosim radiusam mainigajam vertibu
        radius = GetNumberFromUser("Ievadi radiusu");
            // veicam apreikinashanu
            result = radius* radius * 3.14;
        //paradit rezultatu lietotajam
        Console.WriteLine("Rezultats:" + result);
            Console.ReadLine();
        }
        static int GetNumberFromUser(string msg)// <- Saucaas arguments. Viens arguments kas ir teksts 
        {
            //izvadam funkcijai iedoto pazinojumu
            Console.WriteLine(msg);
            //Nolasam lietotaja ievadi no ekrana un ierakstam tekssta mainigo
            string textInput = Console.ReadLine();
            // izveidojam mainigo, kur glabat apalo skaitli
            int parsedNumber; //Kas ir parsed number????
            // parveidojam ievadito tekstu par  skaitli un ierakstsam mainigo
            parsedNumber = int.Parse(textInput);// Check Yourself the definition...
            // errors jo getnumber neiet. samainam "32Linija" static void uz "static int"
            return parsedNumber;//luddzu atgriez to sapreseeto numuru.
            //Tgd vnk ar mainigajiem vnk saskaitishana.
        }
        

        static void Counting() // funk, nosaukums, apallaas iekavas un tad figuriekavas. 
        {
            firstNumber = //
        }

    }
}
