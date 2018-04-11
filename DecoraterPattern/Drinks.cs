using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoraterPattern
{
    public class DrinkWithGin : DrinkDecorater
    {
        public DrinkWithGin(IDrink decorater) : base(decorater)
        { }

        public override string getIngredients()
        {
            return base.getIngredients() + " Gin, ";
        }

        public override double getAlcoholPercent()
        {
            return base.getAlcoholPercent() + 40;
        }
    }

    public class DrinkWithTonic : DrinkDecorater
    {
        public DrinkWithTonic(IDrink decorater) : base(decorater)
        { }

        public override string getIngredients()
        {
            return base.getIngredients() + " Tonic, ";
        }

        public override double getAlcoholPercent()
        {
            return base.getAlcoholPercent() - 20;
        }
    }

    public class DrinkWithCola : DrinkDecorater
    {
        public DrinkWithCola(IDrink decorater) : base(decorater)
        { }

        public override string getIngredients()
        {
            return base.getIngredients() + " Cola, ";
        }

        public override double getAlcoholPercent()
        {
            return base.getAlcoholPercent() - 20;
        }
    }

    public class DrinkWithRom : DrinkDecorater
    {
        public DrinkWithRom(IDrink decorater) : base(decorater)
        { }

        public override string getIngredients()
        {
            return base.getIngredients() + " Rom, ";
        }

        public override double getAlcoholPercent()
        {
            return base.getAlcoholPercent() + 20;
        }
    }

    public class DrinkWithVodka : DrinkDecorater
    {
        public DrinkWithVodka(IDrink decorater) : base(decorater)
        { }

        public override string getIngredients()
        {
            return base.getIngredients() + " Vodka, ";
        }

        public override double getAlcoholPercent()
        {
            return base.getAlcoholPercent() + 20;
        }
    }

    public class DrinkWithJuice : DrinkDecorater
    {
        public DrinkWithJuice(IDrink decorater) : base(decorater)
        { }

        public override string getIngredients()
        {
            return base.getIngredients() + " Juice, ";
        }

        public override double getAlcoholPercent()
        {
            return base.getAlcoholPercent() - 20;
        }
    }
}
