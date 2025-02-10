namespace BioscoopCasus.CalculatePriceStrategy;

public class CalculateStudentPriceStrategy : ICalculatePriceStrategy
{
    public double CalculatePrice(List<MovieTicket> tickets) => CalculateSecondTicketOff(tickets);

    /**
     * Calculate the price with a second ticket off discount.
     * The tickets are sorted from most to least expensive.
     * The price of every second ticket is removed.
     */
    private double CalculateSecondTicketOff(List<MovieTicket> tickets)
    {
        var numberOfTickets = tickets.Count;
        double price = 0.0;

        tickets = tickets.OrderByDescending(t => t.GetPrice()).ToList();
        
        int i = 0;
        while (i < numberOfTickets)
        {
            var ticket = tickets[i];
            price += CalculateSeatPrice(ticket);
            i += 2;
        }

        return price;
    }

    /**
     * Calculate the price of a single seat based on the fact that is a premium seat or not.
     * Premium seat is €2 extra.
     */
    private double CalculateSeatPrice(MovieTicket ticket) =>
        ticket.IsPremiumTicket() ? ticket.GetPrice() + 2 : ticket.GetPrice();
}