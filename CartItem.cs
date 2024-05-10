namespace shopapp.entity
{
    public class CartItem
    {
        public int Id { get; set; }

        public string CartId { get; set; }
        public Cart Cart { get; set; }

        public string ProductId { get; set; }
        public Product Product { get; set; }
        
        public int Quantity { get; set; }
    }
}