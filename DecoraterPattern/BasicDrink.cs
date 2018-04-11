using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoraterPattern
{
    public class BasicDrink : IDrink
    {
        public string getIngredients()
        {
            return "Du har valgt følgende: ";
        }

        public double getAlcoholPercent()
        {
            return 0;
        }
    }
}
