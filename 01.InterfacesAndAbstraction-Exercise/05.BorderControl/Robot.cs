namespace _05.BorderControl
{
    public class Robot : IIdentifiable
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        private string Model { get; }
        public string Id { get; }
    }
}
