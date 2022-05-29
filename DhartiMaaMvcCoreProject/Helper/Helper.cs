namespace DhartiMaaMvcCoreProject.Helper
{
    public class DhartiMaaAPI
    {
        public HttpClient Initial()
        {
            var client=new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5256");
            return client;
        }
    }
}
