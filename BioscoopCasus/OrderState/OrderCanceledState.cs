namespace BioscoopCasus.OrderState;

public class OrderCanceledState(Order order) : IOrderState
{
    public void SubmitOrder()
    {
        Console.WriteLine("Order can not be submitted since order is cancelled");
    }

    public void ChangeOrder()
    {
        Console.WriteLine("Order can not be changed since order is cancelled");
    }

    public void CancelOrder()
    {
        Console.WriteLine("Order can not be canceled since order is cancelled");
    }

    public void PayOrder()
    {
        Console.WriteLine("Order can not be payed since order is cancelled");
    }

    public void MakeProvisional()
    {
        Console.WriteLine("Order can not be made provisional since order is cancelled");
    }
}