namespace NancyRequestStartupError
{
    using Nancy;
    using Nancy.Bootstrapper;

    public class TestRequestStartup : IRequestStartup
    {
        public void Initialize(IPipelines pipelines, NancyContext context)
        {
            pipelines.BeforeRequest.AddItemToStartOfPipeline(nancyContext =>
            {
                return HttpStatusCode.UnprocessableEntity;
            });
        }
    }

    public class TestModule : NancyModule
    {
        public TestModule()
        {
            Get["/"] = o =>
            {
                return HttpStatusCode.OK;
            };
        }
    }
}
