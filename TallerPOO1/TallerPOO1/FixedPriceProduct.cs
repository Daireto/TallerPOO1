namespace TallerPOO1
{
    class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return Price + (Price * (decimal)Tax);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
