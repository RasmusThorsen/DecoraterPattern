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
            var drink = new DrinkWithGin(new DrinkWithTonic(new BasicDrink()));

            Console.WriteLine(drink.getIngredients());
            Console.WriteLine(drink.getAlcoholPercent());
        }
    }

    public interface IDrink
    {
        string getIngredients();
        double getAlcoholPercent();
    }

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

    public class DrinkWithGin : DrinkDecorater
    {
        public DrinkWithGin(IDrink decorater) : base(decorater)
        {}

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
        {}

        public override string getIngredients()
        {
            return base.getIngredients() + " Tonic, ";
        }

        public override double getAlcoholPercent()
        {
            return base.getAlcoholPercent() - 20;
        }
    }

}
