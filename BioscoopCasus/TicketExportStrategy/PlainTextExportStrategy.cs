namespace BioscoopCasus.TicketExportStrategy {
    internal class PlainTextExportStrategy : ITicketExportStrategy {
        public void export(Order order) {
            var fileName = "order-output.txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
            File.WriteAllText(filePath, order.ToString());
            Console.WriteLine($"Plain Text output saved at: {filePath}");
        }
    }
}
