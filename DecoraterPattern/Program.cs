using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoraterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vælg ingredienser vha. tal på tastaturet \n" +
                              "1. Vodka \n" +
                              "2. Rom \n" +
                              "3. Gin \n" +
                              "4. Juice \n" +
                              "5. Cola \n" +
                              "6. Tonic \n" +
                              "0. Afslut \n");

            IDrink drink = new BasicDrink();

            var input = new ConsoleKeyInfo();
            while (input.KeyChar != '0')
            {
                input = Console.ReadKey();
                Console.WriteLine();
                switch (input.KeyChar)
                {
                    case '1':
                        Console.WriteLine("Tilføjer vodka");
                        drink = new DrinkWithVodka(drink);
                        break;
                    case '2':
                        Console.WriteLine("Tilføjer Rom");
                        drink = new DrinkWithRom(drink);
                        break;
                    case '3':
                        Console.WriteLine("Tilføjer Gin");
                        drink = new DrinkWithGin(drink);
                        break;
                    case '4':
                        Console.WriteLine("Tilføjer Juice");
                        drink = new DrinkWithJuice(drink);
                        break;
                    case '5':
                        Console.WriteLine("Tilføjer Cola");
                        drink = new DrinkWithCola(drink);
                        break;
                    case '6':
                        Console.WriteLine("Tilføjer Tonic");
                        drink = new DrinkWithTonic(drink);
                        break;
                    case '0':
                        Console.WriteLine(drink.getIngredients() + " med procenten " + drink.getAlcoholPercent());
                        break;
                    default: 
                        Console.WriteLine("Indtast et tal mellem 0-6");
                        break;
                }
            }
        }
    }

}
