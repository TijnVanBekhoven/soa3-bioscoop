namespace BioscoopCasus.CalculatePriceStrategy;

public class CalculateRegularPriceStrategy : ICalculatePriceStrategy
{
    public double CalculatePrice(List<MovieTicket> tickets)
    {
        double price = 0.0;
        var ticketsDict = SortTicketsByDate(tickets);

        ticketsDict.Keys.ToList().ForEach(key =>
        {
            var ticketsByDay = ticketsDict[key];
            
            if (IsInWeekend(ticketsByDay[0]) && ticketsByDay.Count() >= 6) price += CalculateTenPercentOff(ticketsByDay);
            else if (IsInWeekend(ticketsByDay[0])) price += CalculateRegularPrice(ticketsByDay);
            else price += CalculateSecondTicketOff(ticketsByDay);
        });
        
        return price;
    }

    private double CalculateRegularPrice(List<MovieTicket> tickets)
    {
        double price = 0;
        tickets.ForEach(t => price += CalculateSeatPrice(t));
        return price;
    }

    /**
     * Calculate the price with a ten percent discount.
     */
    private double CalculateTenPercentOff(List<MovieTicket> tickets)
    {
        double price = 0.0;
        tickets.ForEach(ticket => price += CalculateSeatPrice(ticket));
        return price * .9;
    }
    
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
     * Premium seat is €3 extra.
     */
    private double CalculateSeatPrice(MovieTicket ticket) =>
        ticket.IsPremiumTicket() ? ticket.GetPrice() + 3 : ticket.GetPrice();

    /**
     * Put tickets in a Dictionary<string, List<MovieTicket>> with buckets sorted by DayTime.
     */
    private Dictionary<string, List<MovieTicket>> SortTicketsByDate(List<MovieTicket> tickets)
    {
        Dictionary<string, List<MovieTicket>> ticketsByDay = new();
        
        tickets.ForEach(ticket =>
        {
            string key = ticket.GetDateAndTime().ToString();

            if (ticketsByDay.ContainsKey(key))
            {
                var list = ticketsByDay[key];
                list.Add(ticket);
            } else {
                var list = new List<MovieTicket> { ticket };
                ticketsByDay.Add(key, list);
            }
        });
        
        return ticketsByDay;
    }

    /**
     * Checks if ticket is for screening in a weekend.
     * Weekend is Friday, Saturday or Sunday.
     */
    private bool IsInWeekend(MovieTicket ticket)
    {
        DayOfWeek[] weekendDays = [DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday];
        var dateAndTime = ticket.GetDateAndTime();
        return weekendDays.Contains(dateAndTime.DayOfWeek);
    }
}