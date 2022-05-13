namespace CoffeeMaker
{
    public class StarBucks : IMakeACoffee
    {
        public bool CheckingIngredientsAvailability()
        {
            throw new NotImplementedException();
        }

        public string CoffeeMaking(int sugerPerSpoon, int coffeePack)
        {
            throw new NotImplementedException();
        }
    }
    public class StubStarBuks : IMakeACoffee
    {
        public bool CheckingIngredientsAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugerPerSpoon, int coffeePack)
        {
            return "Your Coffee is Recieve";
        }
    }
    public class FakeStarBuks : IMakeACoffee
    {
        public bool CheckingIngredientsAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugerPerSpoon, int coffeePack)
        {
            return "Your Coffee is Recieve";
        }
    }

}

