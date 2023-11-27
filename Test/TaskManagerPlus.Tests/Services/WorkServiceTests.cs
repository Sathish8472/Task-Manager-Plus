using TaskManagerPlus.Domain.Entities;
using TaskManagerPlus.Domain.Services;

namespace TaskManagerPlus.Domain.Tests.Services
{
    public class WorkServiceTests
    {
        private readonly IWorkService _workService;
        public WorkServiceTests(IWorkService workService)
        {
            _workService = workService;
        }

        [Fact]
        public void IsValidWork_ValidWork_ReturnTrue()
        {
            // Arrange
            var validWork = new Work
            {
                Id = 1,
                Name = "Work 1",
                Description = "Work Description",
                StartTime = new TimeSpan(9, 0, 0),
                Endtime = new TimeSpan(10, 30, 0),
                Date = DateTime.Now.Date,
                AssignedUser = new User
                {
                    Id = 1,
                    Email = "Test",
                    FirstName = "Test",
                    LastName = "Test",
                }
            };

            // Act
            var result = _workService.IsValidWork(validWork);

            // Assert
            Assert.True(result);

        }

        [Fact]
        public void IsValidWork_InvalidWork_ReturnFalse()
        {
            // Arrange
            var invalidWork = new Work
            {
                Id = 1,
                Description = "Invalid Description",
                Date = DateTime.Now.Date.AddDays(2),
                StartTime = new TimeSpan(12, 0, 0),
                Endtime = new TimeSpan(13, 30, 0),
            };

            // Act
            var result = _workService.IsValidWork(invalidWork);

            // Assert
            Assert.False(result);
        }
    }
}
