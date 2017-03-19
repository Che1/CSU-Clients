namespace Clients
{
    public struct Product
    {
        public string name;
        public float price;

        public Product(string item, float f)
        {
            name = item;
            price = f;
        }
    }
}