using OrderMicroService.Enum;

namespace OrderMicroService.Domain;

public class Order
{
    public Guid Id { get; set; }
    public string UserId { get; private set; }
    public DateTime OrderPlaced { get; private set; }
    public bool OrderPaid { get; private set; }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Address { get; private set; }
    public string PhoneNumber { get; private set; }
    public int TotalPrice { get; set; }

    public ICollection<OrderLine> OrderLines { get; private set; }
    public PaymentStatus PaymentStatus { get; private set; }

    public Order(string userId,
        string firstName,
        string lastName,
        string address,
        string phoneNumber,
        int totalPrice,
        List<OrderLine> orderLines)
    {
        UserId = userId;
        OrderPaid = false;
        OrderPlaced = DateTime.Now;
        OrderLines = orderLines;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        PhoneNumber = phoneNumber;
        TotalPrice = totalPrice;
        PaymentStatus = PaymentStatus.UnPaid;
    }
    public Order() { }

    public void RequestPayment()
    {
        PaymentStatus = PaymentStatus.RequestPayment;
    }

    public void PaymentIsDone()
    {
        OrderPaid = true;
        PaymentStatus = PaymentStatus.IsPaid;
    }
}