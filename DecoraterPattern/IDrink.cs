using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoraterPattern
{
    public interface IDrink
    {
        string getIngredients();
        double getAlcoholPercent();
    }
}
