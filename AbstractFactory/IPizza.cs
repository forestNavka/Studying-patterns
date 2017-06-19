using AbstractFactory.Chicago;

namespace AbstractFactory
{
    public interface IPizza
    {
        void Bake();
        void Box();
        void Deliver();

    }
}