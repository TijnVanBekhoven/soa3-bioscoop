using System.Text;
using System.Text.Json.Serialization;
using BioscoopCasus.CalculatePriceStrategy;
using BioscoopCasus.TicketExportStrategy;

namespace BioscoopCasus
{
    public class Order
    {
        [JsonInclude]
        [JsonPropertyName("orderNr")]
        private int _orderNr { get; set; }

        [JsonInclude]
        [JsonPropertyName("isStudent")]
        private bool _isStudent { get; set; }

        [JsonInclude]
        [JsonPropertyName("tickets")]
        private List<MovieTicket> _tickets { get; set; }

        private ITicketExportStrategy? _exportStrategy;

        private ICalculatePriceStrategy _calculatePriceStrategy;

        public Order(int orderNr, bool isStudentOrder)
        {
            this._orderNr = orderNr;
            this._isStudent = isStudentOrder;

            _tickets = new List<MovieTicket>();
            
            // Set CalculatePriceStrategy
            if (isStudentOrder) _calculatePriceStrategy = new CalculateStudentPriceStrategy();
            else _calculatePriceStrategy = new CalculateRegularPriceStrategy();
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
            return _calculatePriceStrategy.CalculatePrice(this._tickets);
        }

        public void Export()
        {
            if (_exportStrategy == null) throw new Exception("Export format not set");
            _exportStrategy.Export(this);
        }

        public void SetExportFormat(ITicketExportStrategy exportStrategy) {
            _exportStrategy = exportStrategy;
        }

        public override string ToString() {
            var builder = new StringBuilder();
            builder.AppendLine($"Order number: {this._orderNr}");
            builder.AppendLine($"Is student: {this._isStudent}");
            builder.AppendLine("Tickets:");

            for(int i = 0; i < _tickets.Count; i++) {
                builder.AppendLine($"{i + 1}. {this._tickets[i].ToString()}");
            }
            return builder.ToString();
        }
    }
}
