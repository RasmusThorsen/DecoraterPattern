using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoraterPattern
{
    public abstract class DrinkDecorater : IDrink
    {
        private readonly IDrink decoratedDrink;

        protected DrinkDecorater(IDrink drink)
        {
            decoratedDrink = drink;
        }

        public virtual string getIngredients()
        {
            return decoratedDrink.getIngredients();
        }

        public virtual double getAlcoholPercent()
        {
            return decoratedDrink.getAlcoholPercent();
        }
    }
}
