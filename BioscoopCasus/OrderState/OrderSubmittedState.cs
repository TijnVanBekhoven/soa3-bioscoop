namespace BioscoopCasus.OrderState;

public class OrderSubmittedState(Order order) : IOrderState
{
    public void SubmitOrder()
    {
        Console.WriteLine("Order has already been submitted");
    }

    public void ChangeOrder()
    {
        order.orderState = order.orderCreatedState;
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
        order.orderState = order.orderProvisionalState;
    }
}