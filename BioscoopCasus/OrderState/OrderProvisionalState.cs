namespace BioscoopCasus.OrderState;

public class OrderProvisionalState(Order order) : IOrderState
{
    public void SubmitOrder()
    {
        Console.WriteLine("Order can not be submitted since it has already been submitted");
    }

    public void ChangeOrder()
    {
        Console.WriteLine("Order can not be changed since it has already been submitted");
    }

    public void CancelOrder()
    {
        order.orderState = order.orderCancelledState;
    }

    public void PayOrder()
    {
        order.orderState = order.orderPaidState;
    }

    public void MakeProvisional()
    {
        Console.WriteLine("Order is already provisional");
    }
}