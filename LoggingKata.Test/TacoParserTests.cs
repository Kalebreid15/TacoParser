using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("33.520682, -86.80249, Taco Bell Birmingham...", -86.802432)]
        [InlineData("30.438255, -84.280733, Taco Bell Tallahassee...", -84.280733)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {

            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location


            //Arrange

            var tacoParser = new TacoParser();

            //Act
            var location = tacoParser.Parse(line);
            var actual = location.Location.Longitude;


            //Assert

            Assert.Equal(expected, actual, 5);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("33.520682, -86.80249, Taco Bell Birmingham...", 33.520682)]
        [InlineData("30.438255, -84.280733, Taco Bell Tallahassee...", 30.438255)]



        //TODO: Create a test called ShouldParseLatitude
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var location = tacoParser.Parse(line);
            var actual = location.Location.Latitude;

            //Assert
            Assert.Equal(expected, actual, 5);
        }



        

    }
}
    
