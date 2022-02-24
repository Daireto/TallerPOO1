namespace TallerPOO1
{
    abstract class Product : IPay
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public float Tax { get; set; }

        public override string ToString()
        {
            return $"   {Id} {Description}" +
                $"\n\tPrice......:{$"{Price:C2}",15}" +
                $"\n\tTax........:{$"{Tax:P2}",16}" +
                $"\n\tValue......:{$"{ValueToPay():C2}",15}";
        }

        public abstract decimal ValueToPay();
    }
}
