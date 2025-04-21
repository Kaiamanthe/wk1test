using Xunit;

namespace wk1test
{
    public class AssignmentTests
    {
        [Fact]
        public void Assignment_Should_Have_A_Title()
        {
            var assignment = new Assignment();

            Assert.NotNull(assignment.Title);
        }
    }
}
