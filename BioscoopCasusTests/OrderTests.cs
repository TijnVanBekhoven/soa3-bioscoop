namespace BioscoopCasusTests {
    public class OrderTests {
        [Fact]
        public void CalculatePriceShouldReturn0IfNoTickets() {
            //Arrange
            Order order = new Order(1, true);
            
            //Act
            double price = order.CalculatePrice();
        
            //Assert
            Assert.Equal(0, price);
        }
        
        [Fact]
        public void CalculatePriceShouldReturnWithStudentDiscount() {
            //Arrange
            Movie movie = new Movie("Jurassic Park");
            MovieScreening movieScreening1 = new MovieScreening(movie, new DateTime(2025, 1, 1), 5.5);
            movie.AddScreening(movieScreening1);
            MovieTicket movieTicket1 = new MovieTicket(movieScreening1, false, 8, 3);
            MovieTicket movieTicket2 = new MovieTicket(movieScreening1, false, 8, 4);
            Order order = new Order(1, true);
            order.AddSeatReservation(movieTicket1);
            order.AddSeatReservation(movieTicket2);
            
            //Act
            double price = order.CalculatePrice();
        
            //Assert
            Assert.Equal(5.5, price);
        }

        [Fact]
        public void CalculatePriceShouldReturnWithoutDiscount() {
            //Arrange
            Movie movie = new Movie("Jurassic Park");
            MovieScreening movieScreening1 = new MovieScreening(movie, new DateTime(2025, 1, 1), 5.5);
            movie.AddScreening(movieScreening1);
            MovieTicket movieTicket1 = new MovieTicket(movieScreening1, false, 8, 3);
            MovieTicket movieTicket2 = new MovieTicket(movieScreening1, false, 8, 4);
            Order order = new Order(1, false);
            order.AddSeatReservation(movieTicket1);
            order.AddSeatReservation(movieTicket2);
            
            //Act
            double price = order.CalculatePrice();
        
            //Assert
            Assert.Equal(5.5, price);
        }
    }
}