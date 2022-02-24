namespace TallerPOO1
{
    class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public ICollection<Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal amount = 0;
            foreach(Product product in Products)
            {
                amount += product.ValueToPay();
            }
            return amount - (amount * (decimal)Discount);
        }

        public override string ToString()
        {
            string[] productArray = new string[4];
            int i = 0;
            foreach(Product product in Products)
            {
                productArray[i] = product.Description;
                i++;
            }
            return $"   {Id} {Description}" +
                $"\n\tProducts...: {productArray[0]}, {productArray[1]}, {productArray[2]}, {productArray[3]}" +
                $"\n\tDiscount...:{$"{Discount:P2}",16}" +
                $"\n\tValue......:{$"{ValueToPay():C2}",15}";
        }
    }
}
