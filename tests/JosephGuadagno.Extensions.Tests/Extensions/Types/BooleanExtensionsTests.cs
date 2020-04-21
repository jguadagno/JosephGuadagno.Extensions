using Xunit;
using JosephGuadagno.Extensions.Types;

namespace JosephGuadagno.Extensions.Tests.Extensions.Types
{
    public class BooleanExtensionsTests {

        [Fact]
        public void IsTrue_IsNull_ReturnFalse() {
            // Arrange
            bool? inputTests = null;

            // Act
            var results = inputTests.IsTrue();

            // Assert
            Assert.False(results);
        }

        [Fact]
        public void IsTrue_IsNotNullAndIsTrue_ReturnsTrue() {
            // Arrange
            bool? inputTests = true;

            // Act
            var results = inputTests.IsTrue();

            // Assert
            Assert.True(results);
        }

        [Fact]
        public void IsTrue_IsNotNullAndIsFalse_ReturnsFalse() {
            // Arrange
            bool? inputTests = false;

            // Act
            var results = inputTests.IsTrue();

            // Assert
            Assert.False(results);
        }

        [Fact]
        public void ShouldFail()
        {
            Assert.True(false);
        }
    }
}