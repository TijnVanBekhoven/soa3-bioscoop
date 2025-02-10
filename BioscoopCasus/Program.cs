using BioscoopCasus;
using BioscoopCasus.TicketExport;

Movie movie = new Movie("Jurassic Park");
MovieScreening movieScreening1 = new MovieScreening(movie, new DateTime(2025, 1, 1), 5.5);
MovieScreening movieScreening2 = new MovieScreening(movie, new DateTime(2025, 1, 2), 5.5);
movie.AddScreening(movieScreening1);
movie.AddScreening(movieScreening2);
MovieTicket movieTicket1 = new MovieTicket(movieScreening2, true, 8, 5);
MovieTicket movieTicket2 = new MovieTicket(movieScreening1, false, 8, 3);
MovieTicket movieTicket3 = new MovieTicket(movieScreening1, false, 8, 4);

Order order = new Order(1, true);
order.AddSeatReservation(movieTicket1);
order.AddSeatReservation(movieTicket2);
order.AddSeatReservation(movieTicket3);

order.SetExportFormat(new JsonExportFormat());
order.Export();
order.SetExportFormat(new PlainTextExportFormat());
order.Export();

Console.WriteLine(order.CalculatePrice());
