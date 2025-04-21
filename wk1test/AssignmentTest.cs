using Xunit;

namespace wk1test
{
    public class AssignmentTests
    {
        [Fact]
        public void Assignment_Should_Have_A_Title()
        {
            string Title = "New Title";
            var assignment = new Assignment(Title);

            Assert.NotNull(assignment._title);
        }
    }
}
