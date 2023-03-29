namespace BasketMicroService.Domain;

public class Basket
{
    public Basket(Guid userId)
    {
        UserId = userId;
    }
    public Basket()
    {
    }
    public Guid Id { get; set; }
    public Guid UserId { get; private set; }
    public Guid? DiscountId { get; set; }
    public List<BasketItem> Items { get; set; } = new List<BasketItem>();
}