namespace BioscoopCasusTests.CalculatePriceStrategyTests;

public class CalculateStudentPriceStrategyTests
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
        CalculateStudentPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(5.5, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithTwoRegularSeats()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 1), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket1 = new MovieTicket(screening, false, 1, 1);
        MovieTicket ticket2 = new MovieTicket(screening, false, 1, 2);
        List<MovieTicket> tickets = [ticket1, ticket2];
        CalculateStudentPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(5.5, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithThreeRegularSeats()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 1), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket1 = new MovieTicket(screening, false, 1, 1);
        MovieTicket ticket2 = new MovieTicket(screening, false, 1, 2);
        MovieTicket ticket3 = new MovieTicket(screening, false, 1, 3);
        List<MovieTicket> tickets = [ticket1, ticket2, ticket3];
        CalculateStudentPriceStrategy calculatePriceStrategy = new();

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
        CalculateStudentPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(7.5, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithTwoPremiumSeats()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 1), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket1 = new MovieTicket(screening, true, 1, 1);
        MovieTicket ticket2 = new MovieTicket(screening, true, 1, 2);
        List<MovieTicket> tickets = [ticket1, ticket2];
        CalculateStudentPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(7.5, priceResult);
    }
    
    [Fact]
    public void CalculateSeatPriceWithThreePremiumSeats()
    {
        //Arrange
        Movie movie = new Movie("Jurassic Park");
        MovieScreening screening = new MovieScreening(movie, new DateTime(2025, 1, 1), 5.5);
        movie.AddScreening(screening);
        MovieTicket ticket1 = new MovieTicket(screening, true, 1, 1);
        MovieTicket ticket2 = new MovieTicket(screening, true, 1, 2);
        MovieTicket ticket3 = new MovieTicket(screening, true, 1, 3);
        List<MovieTicket> tickets = [ticket1, ticket2, ticket3];
        CalculateStudentPriceStrategy calculatePriceStrategy = new();

        //Act
        var priceResult = calculatePriceStrategy.CalculatePrice(tickets);

        //Assert
        Assert.Equal(15, priceResult);
    }
    
}