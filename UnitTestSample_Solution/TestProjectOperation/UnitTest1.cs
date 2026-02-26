using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProjectOperation
{
    public class Tests
    {
        private UnitTestSample.Operations _program { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _program = new UnitTestSample.Operations ();
        }

        [Test]
        public void Add_WithTwoNumbers_ReturnsSum()
        {
           
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _program.Add(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }
    }
}