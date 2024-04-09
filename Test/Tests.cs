namespace CodeCoverage.Tests
{
    public class MathHelperTests
    {
        private readonly IMathHelperService _mathHelper;

        public MathHelperTests()
        {
            _mathHelper = new MathHelperService();
        }

        [Fact]
        public void TestAdd()
        {
            // Arrange
            int a = 3;
            int b = 4;

            // Act
            int result = _mathHelper.Add(a, b);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void TestSubtract()
        {
            // Arrange
            int a = 10;
            int b = 5;

            // Act
            int result = _mathHelper.Subtract(a, b);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestMultiply()
        {
            // Arrange
            int a = 3;
            int b = 4;

            // Act
            int result = _mathHelper.Multiply(a, b);

            // Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void TestDivide()
        {
            // Arrange
            int a = 10;
            int b = 5;

            // Act
            decimal result = _mathHelper.Divide(a, b);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void TestDivideByZero()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _mathHelper.Divide(a, b));
        }
    }
}
