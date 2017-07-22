namespace _05.BorderControl
{
    public interface IBuyer : IPerson
    {
        int Food { get; }
        void BuyFood();
    }
}
