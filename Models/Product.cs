namespace BasicOOPSRevise.Models
{
    public class Product
    {
        private string name;
        private decimal price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
            }
        }
    }
}
