namespace BioscoopCasus.CalculatePriceStrategy;

public interface ICalculatePriceStrategy
{
    public double CalculatePrice(List<MovieTicket> tickets);
}