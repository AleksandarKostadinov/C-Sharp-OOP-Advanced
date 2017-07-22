namespace _03.Ferrari
{
    public class Ferrari : ICar
    {
        public Ferrari( string driver)
        {
            this.Model = "488-Spider";
            this.Driver = driver;
        }
        public string Model { get; }
        public string Driver { get; }

        public string HitTheBreaks()
        {
            return "Brakes!";
        }

        public string GasPedal()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.HitTheBreaks()}/{this.GasPedal()}/{this.Driver}";
        }
    }
}
