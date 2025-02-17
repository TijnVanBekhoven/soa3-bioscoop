namespace BioscoopCasus.OrderState;

public interface IOrderState
{
    public void SubmitOrder();
    public void ChangeOrder();
    public void CancelOrder();
    public void PayOrder();
    public void MakeProvisional();
}