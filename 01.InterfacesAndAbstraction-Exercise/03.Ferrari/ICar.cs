namespace _03.Ferrari
{
    public interface ICar
    {
        string Model { get; }
        string Driver { get; }

        string HitTheBreaks();
        string GasPedal();
    }
}
