namespace BioscoopCasus.OrderState;

public class OrderCreatedState(Order order) : IOrderState
{
    public void SubmitOrder()
    {
        order.orderState = order.orderSubmittedState;
    }

    public void ChangeOrder()
    {
        Console.WriteLine("Order has not been submitted yet!");
    }

    public void CancelOrder()
    {
        order.orderState = order.orderCancelledState;
    }

    public void PayOrder()
    {
        Console.WriteLine("Order has not been submitted yet!");
    }

    public void MakeProvisional()
    {
        Console.WriteLine("Order can not be made provisional!");
    }
}