using DSI.Domain.Models;

namespace DSI.Domain.Services
{
    public class DataService : IDataService
    {
        public HelloWorld GetHelloWorld()
        {
            var model = new HelloWorld
            {
                Text = "Hello World!"
            };
            return model;
        }
    }
}
