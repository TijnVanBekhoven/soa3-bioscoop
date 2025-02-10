namespace BioscoopCasus.TicketExport {
    public interface ITicketExportFormat {
        void export(Order order);
    }
}
