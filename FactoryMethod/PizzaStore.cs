namespace FactoryMethod
{
    public abstract class PizzaStore
    {
        public void OrderPizza(PizzaType type)
        {
            IPizza pizza = CreatePizza(type);
            pizza.Bake();
            pizza.Box();
            pizza.Deliver();
        }

       protected abstract IPizza CreatePizza(PizzaType type);
    }
}
