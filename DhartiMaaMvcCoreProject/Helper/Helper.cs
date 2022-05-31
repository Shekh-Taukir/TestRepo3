namespace DhartiMaaMvcCoreProject.Helper
{
    public class DhartiMaaAPI
    {
        public HttpClient Initial()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(CommonConstant.BaseUrl)
            };
            return client;
        }
    }
}
