namespace Bai_Thi.Entity
{
    public class entity
    {
        public string ProductId;
        public string ProductName;
        public string Price;

        public entity(string productId, string productName, string price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }

        public entity()
        {
        }

        public string ProductId1
        {
            get => ProductId;
            set => ProductId = value;
        }

        public string ProductName1
        {
            get => ProductName;
            set => ProductName = value;
        }

        public string Price1
        {
            get => Price;
            set => Price = value;
        }
    }
}