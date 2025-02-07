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
        public void CalculatePriceShouldReturnWithStudentDiscountWithPremiumSeats() {
            //Arrange
            Movie movie = new Movie("Jurassic Park");
            MovieScreening movieScreening1 = new MovieScreening(movie, new DateTime(2025, 1, 1), 5.5);
            movie.AddScreening(movieScreening1);
            MovieTicket movieTicket1 = new MovieTicket(movieScreening1, true, 8, 3);
            MovieTicket movieTicket2 = new MovieTicket(movieScreening1, false, 8, 4);
            Order order = new Order(1, true);
            order.AddSeatReservation(movieTicket1);
            order.AddSeatReservation(movieTicket2);

            //Act
            double price = order.CalculatePrice();

            //Assert
            Assert.Equal(6.5, price);
        }

        [Fact]
        public void CalculatePriceShouldReturnWithoutStudentDiscountOnWeekday() {
            //Arrange
            Movie movie = new Movie("Jurassic Park");
            MovieScreening movieScreening1 = new MovieScreening(movie, new DateTime(2025, 1, 1), 5);
            movie.AddScreening(movieScreening1);
            MovieTicket movieTicket1 = new MovieTicket(movieScreening1, false, 8, 3);
            MovieTicket movieTicket2 = new MovieTicket(movieScreening1, false, 8, 4);
            Order order = new Order(1, false);
            order.AddSeatReservation(movieTicket1);
            order.AddSeatReservation(movieTicket2);

            //Act
            double price = order.CalculatePrice();

            //Assert
            Assert.Equal(5, price);
        }

        [Fact]
        public void CalculatePriceShouldReturnWithStudentDiscountOnWeekend() {
            //Arrange
            Movie movie = new Movie("Jurassic Park");
            MovieScreening movieScreening1 = new MovieScreening(movie, new DateTime(2025, 1, 4), 5);
            movie.AddScreening(movieScreening1);
            MovieTicket movieTicket1 = new MovieTicket(movieScreening1, false, 8, 3);
            MovieTicket movieTicket2 = new MovieTicket(movieScreening1, false, 8, 4);
            MovieTicket movieTicket3 = new MovieTicket(movieScreening1, false, 8, 5);
            MovieTicket movieTicket4 = new MovieTicket(movieScreening1, false, 8, 6);
            MovieTicket movieTicket5 = new MovieTicket(movieScreening1, false, 8, 7);
            MovieTicket movieTicket6 = new MovieTicket(movieScreening1, false, 8, 8);
            Order order = new Order(1, false);
            order.AddSeatReservation(movieTicket1);
            order.AddSeatReservation(movieTicket2);
            order.AddSeatReservation(movieTicket3);
            order.AddSeatReservation(movieTicket4);
            order.AddSeatReservation(movieTicket5);
            order.AddSeatReservation(movieTicket6);

            //Act
            double price = order.CalculatePrice();

            //Assert
            Assert.Equal(27, price);
        }


        [Fact]
        public void CalculatePriceShouldReturnWithStudentDiscountOnWeekendWithPremiumSeats() {
            //Arrange
            Movie movie = new Movie("Jurassic Park");
            MovieScreening movieScreening1 = new MovieScreening(movie, new DateTime(2025, 1, 4), 5);
            movie.AddScreening(movieScreening1);
            MovieTicket movieTicket1 = new MovieTicket(movieScreening1, true, 8, 3);
            MovieTicket movieTicket2 = new MovieTicket(movieScreening1, true, 8, 4);
            MovieTicket movieTicket3 = new MovieTicket(movieScreening1, true, 8, 5);
            MovieTicket movieTicket4 = new MovieTicket(movieScreening1, true, 8, 6);
            MovieTicket movieTicket5 = new MovieTicket(movieScreening1, true, 8, 7);
            MovieTicket movieTicket6 = new MovieTicket(movieScreening1, true, 8, 8);
            Order order = new Order(1, false);
            order.AddSeatReservation(movieTicket1);
            order.AddSeatReservation(movieTicket2);
            order.AddSeatReservation(movieTicket3);
            order.AddSeatReservation(movieTicket4);
            order.AddSeatReservation(movieTicket5);
            order.AddSeatReservation(movieTicket6);

            //Act
            double price = order.CalculatePrice();

            //Assert
            Assert.Equal(43.200000000000003, price);
        }
    }
}