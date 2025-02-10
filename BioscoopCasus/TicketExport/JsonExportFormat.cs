﻿using System.Text;
using System.Text.Json;

namespace BioscoopCasus.TicketExport {
    internal class JsonExportFormat : ITicketExportFormat {
        public void export(Order order) {
            var json = JsonSerializer.Serialize(order, new JsonSerializerOptions { WriteIndented = true });
            var fileName = "order-output.json";
            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
            File.WriteAllBytes(filePath, Encoding.UTF8.GetBytes(json));
            Console.WriteLine($"JSON output saved at: {filePath}");
        }
    }
}
