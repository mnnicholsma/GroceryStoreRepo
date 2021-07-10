namespace GroceryStoreAPI.Data
{
    public class Product
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string ItemName { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
