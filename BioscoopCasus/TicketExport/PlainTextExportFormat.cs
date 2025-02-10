namespace BioscoopCasus.TicketExport {
    internal class PlainTextExportFormat : ITicketExportFormat {
        public void export(Order order) {
            var fileName = "order-output.txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
            File.WriteAllText(filePath, order.ToString());
            Console.WriteLine($"Plain Text output saved at: {filePath}");
        }
    }
}
