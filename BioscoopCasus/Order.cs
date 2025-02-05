﻿using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BioscoopCasus
{
    internal class Order
    {
        [JsonInclude]
        [JsonPropertyName("orderNr")]
        private int _orderNr { get; set; }

        [JsonInclude]
        [JsonPropertyName("isStudent")]
        private bool _isStudent { get; set; }

        [JsonInclude]
        [JsonPropertyName("tickets")]
        private List<MovieTicket> _tickets;

        public Order(int orderNr, bool isStudentOrder)
        {
            this._orderNr = orderNr;
            this._isStudent = isStudentOrder;

            _tickets = new List<MovieTicket>();
        }

        public int GetOrderNr()
        {
            return this._orderNr;
        }

        public void AddSeatReservation(MovieTicket ticket)
        {
            this._tickets.Add(ticket);
        }

        public double CalculatePrice()
        {
            if (!_tickets.Any()) return 0;

            double price = 0;
            Dictionary<string, List<MovieTicket>> ticketsDict = new();
            List<string> days = new();

            // Add tickets to ticketsDict with key of DateTime
            _tickets.ForEach(ticket =>
            {
                string key = ticket.GetDateAndTime().ToString();

                if (ticketsDict.ContainsKey(key))
                {
                    var list = ticketsDict[key];
                    list.Add(ticket);
                } else
                {
                    List<MovieTicket> list = new();
                    list.Add(ticket);
                    ticketsDict.Add(key, list);
                    days.Add(key);
                }
            });

            if (_isStudent)
            {
                /**
                 * Calculate student price
                 * - Second ticket off
                 */
                List<MovieTicket> tickets = new List<MovieTicket>();

                days.ForEach(key =>
                {
                    ticketsDict[key].ForEach(ticket =>
                    {
                        tickets.Add(ticket);
                    });
                });

                price = CalculateSecondTicketOff(tickets);
            }
            else
            {
                /**
                 * Calculate non-student prices
                 * - On weekday (mon/tue/wed/thu) 10% off
                 * - On weekenday 10% when more than 6 tickets
                 */
                days.ForEach(day =>
                {
                    if (IsOnWeekDay(ticketsDict[day][0].GetDateAndTime()))
                    {
                        List<MovieTicket> tickets = ticketsDict[day];
                        ticketsDict.Remove(day);
                        price += CalculateSecondTicketOff(tickets);
                    }
                    else
                    {
                        List<MovieTicket> tickets = ticketsDict[day];
                        ticketsDict.Remove(day);
                        price += CalculateTenPercentOff(tickets);
                    }
                });
            }

            return price;
        }

        public void Export(TicketExportFormat exportFormat)
        {
            switch (exportFormat) {
                case TicketExportFormat.PLAINTEXT:
                    ExportToPlainText();
                    break;
                case TicketExportFormat.JSON:
                    ExportToJson();
                    break;
            }
        }

        private void ExportToPlainText() {
           
        }  
        
        private void ExportToJson() {
            var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            string filePath = Path.Combine(Environment.CurrentDirectory, "order-output.json");
            File.WriteAllBytes(filePath, Encoding.UTF8.GetBytes(json));
            Console.WriteLine($"Output saved at: {filePath}");
        }

        private double CalculateSecondTicketOff(List<MovieTicket> tickets)
        {
            int numberOfTickets = tickets.Count; ;
            double price = 0;

            tickets.ForEach(ticket =>
            {
                price += CalculateSeatPrice(ticket);
            });

            if (numberOfTickets % 2 == 0)
            {
                return price / 2;
            }
            else
            {
                return ((price - (price / numberOfTickets)) / 2) + (price / numberOfTickets);
            }
        }

        private bool IsOnWeekDay(DateTime dateTime)
        {
            string[] weekDays = ["Monday", "Tuesday", "Wednesday", "Thursday"];

            foreach (var day in weekDays)
            {
                if (dateTime.DayOfWeek.Equals(day)) return true;
            }
            return false;
        }

        private double CalculateTenPercentOff(List<MovieTicket> tickets)
        {
            double price = 0;

            tickets.ForEach(ticket =>
            {
                price += CalculateSeatPrice(ticket);
            });

            if (tickets.Count >= 6)
            {
                price -= (price / 10);
            }

            return price;
        }

        private double CalculateSeatPrice(MovieTicket ticket)
        {
            if (_isStudent)
                return ticket.IsPremiumTicket() ? ticket.GetPrice() + 2 : ticket.GetPrice();
            return ticket.IsPremiumTicket() ? ticket.GetPrice() + 3 : ticket.GetPrice();
        }

    }
}
