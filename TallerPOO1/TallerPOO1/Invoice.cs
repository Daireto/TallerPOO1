namespace TallerPOO1
{
    class Invoice : IPay
    {
        public ICollection<Product> _products;

        public Invoice()
        {
            _products = new List<Product>();
        }
        
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal ValueToPay()
        {
            decimal amount = 0;
            foreach(Product product in _products)
            {
                amount += product.ValueToPay();
            }
            return amount;
        }

        public override string ToString()
        {
            Product[] productArray = new Product[3];
            int i = 0;
            foreach (Product product in _products)
            {
                productArray[i] = product;
                i++;
            }
            return $"RECEIPT" +
                $"\n-------------------------------------------------" +
                $"\n{productArray[0].ToString()}\n{productArray[1].ToString()}\n{productArray[2].ToString()}" +
                $"\n\t            ===============" +
                $"\nTOTAL:\t\t    {$"{ValueToPay():C2}",15}";
        }
    }
}
