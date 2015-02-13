namespace NancyRequestStartupError.Tests
{
    using Nancy;
    using Nancy.Testing;
    using Xunit;

    public class ConfigurableBootstrapperTest
    {
        [Fact]
        public void should_not_automatically_execute_TestRequestStartup()
        {
            // Given
            var browser = new Browser(with =>
            {
                with.Module<TestModule>();
            });

            // When
            var response = browser.Get("/");

            // Then
            Assert.Equal(response.StatusCode, HttpStatusCode.OK);
        }
    }
}
