namespace BioscoopCasusTests.CalculatePriceStrategyTests;

public class CalculateRegularPriceStrategyTests
{
    [Fact]
    public void CalculateSeatPriceWithOneRegularSeat()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 1), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket = new MovieTicket(screening, false, 1, 1);
        List<MovieTicket> tickets = [ticket];
        CalculateRegularPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(5.5, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithTwoRegularSeatsOnMonday()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 6), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket1 = new MovieTicket(screening, false, 1, 1);
        MovieTicket ticket2 = new MovieTicket(screening, false, 1, 1);
        List<MovieTicket> tickets = [ticket1, ticket2];
        CalculateRegularPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(5.5, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithTwoRegularSeatsOnTuesday()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 7), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket1 = new MovieTicket(screening, false, 1, 1);
        MovieTicket ticket2 = new MovieTicket(screening, false, 1, 1);
        List<MovieTicket> tickets = [ticket1, ticket2];
        CalculateRegularPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(5.5, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithTwoRegularSeatsOnWednesday()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 8), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket1 = new MovieTicket(screening, false, 1, 1);
        MovieTicket ticket2 = new MovieTicket(screening, false, 1, 1);
        List<MovieTicket> tickets = [ticket1, ticket2];
        CalculateRegularPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(5.5, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithTwoRegularSeatsOnThursday()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 9), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket1 = new MovieTicket(screening, false, 1, 1);
        MovieTicket ticket2 = new MovieTicket(screening, false, 1, 1);
        List<MovieTicket> tickets = [ticket1, ticket2];
        CalculateRegularPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(5.5, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithTwoRegularSeatsOnFriday()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 10), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket1 = new MovieTicket(screening, false, 1, 1);
        MovieTicket ticket2 = new MovieTicket(screening, false, 1, 1);
        List<MovieTicket> tickets = [ticket1, ticket2];
        CalculateRegularPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(11, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithTwoRegularSeatsOnSaturday()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 11), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket1 = new MovieTicket(screening, false, 1, 1);
        MovieTicket ticket2 = new MovieTicket(screening, false, 1, 1);
        List<MovieTicket> tickets = [ticket1, ticket2];
        CalculateRegularPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(11, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithTwoRegularSeatsOnSunday()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 12), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket1 = new MovieTicket(screening, false, 1, 1);
        MovieTicket ticket2 = new MovieTicket(screening, false, 1, 1);
        List<MovieTicket> tickets = [ticket1, ticket2];
        CalculateRegularPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(11, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithOnePremiumSeat()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 1), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket = new MovieTicket(screening, true, 1, 1);
        List<MovieTicket> tickets = [ticket];
        CalculateRegularPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(8.5, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithTwoPremiumSeatsOnMonday()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 6), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket1 = new MovieTicket(screening, true, 1, 1);
        MovieTicket ticket2 = new MovieTicket(screening, true, 1, 1);
        List<MovieTicket> tickets = [ticket1, ticket2];
        CalculateRegularPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(8.5, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithFiveRegularSeatsOnFriday()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 10), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket1 = new MovieTicket(screening, false, 1, 1);
        MovieTicket ticket2 = new MovieTicket(screening, false, 1, 2);
        MovieTicket ticket3 = new MovieTicket(screening, false, 1, 3);
        MovieTicket ticket4 = new MovieTicket(screening, false, 1, 4);
        MovieTicket ticket5 = new MovieTicket(screening, false, 1, 5);
        List<MovieTicket> tickets = [ticket1, ticket2, ticket3, ticket4, ticket5];
        CalculateRegularPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(27.5, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithSixRegularSeatsOnFriday()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 10), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket1 = new MovieTicket(screening, false, 1, 1);
        MovieTicket ticket2 = new MovieTicket(screening, false, 1, 2);
        MovieTicket ticket3 = new MovieTicket(screening, false, 1, 3);
        MovieTicket ticket4 = new MovieTicket(screening, false, 1, 4);
        MovieTicket ticket5 = new MovieTicket(screening, false, 1, 5);
        MovieTicket ticket6 = new MovieTicket(screening, false, 1, 6);
        List<MovieTicket> tickets = [ticket1, ticket2, ticket3, ticket4, ticket5, ticket6];
        CalculateRegularPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(29.7, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithSevenRegularSeatsOnFriday()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 10), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket1 = new MovieTicket(screening, false, 1, 1);
        MovieTicket ticket2 = new MovieTicket(screening, false, 1, 2);
        MovieTicket ticket3 = new MovieTicket(screening, false, 1, 3);
        MovieTicket ticket4 = new MovieTicket(screening, false, 1, 4);
        MovieTicket ticket5 = new MovieTicket(screening, false, 1, 5);
        MovieTicket ticket6 = new MovieTicket(screening, false, 1, 6);
        MovieTicket ticket7 = new MovieTicket(screening, false, 1, 7);
        List<MovieTicket> tickets = [ticket1, ticket2, ticket3, ticket4, ticket5, ticket6, ticket7];
        CalculateRegularPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(34.65, priceResult);
    }
    
}