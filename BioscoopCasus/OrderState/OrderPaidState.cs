namespace BioscoopCasus.OrderState;

public class OrderPaidState(Order order) : IOrderState
{
    private readonly Order _order = order;
    
    public void SubmitOrder()
    {
        Console.WriteLine("Order has already been paid and can therefore not be submitted again.");
    }

    public void ChangeOrder()
    {
        Console.WriteLine("Order has already been paid and can therefore not be changed again.");
    }

    public void CancelOrder()
    {
        Console.WriteLine("Order has already been paid and can therefore not be cancelled.");
    }

    public void PayOrder()
    {
        Console.WriteLine("Order has already been paid.");
    }

    public void MakeProvisional()
    {
        Console.WriteLine("Order has already been paid and can therefore not be provisional.");
    }
}