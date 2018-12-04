using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldApi;
using Microsoft.AspNetCore;

namespace HelloWorldApi.Tests
{
    [TestClass]
    public class TestMessageController
    {
        [TestMethod]
        public void GetMessage_ShouldReturnHelloWorld()
        {
            var messageController = new HelloWorldApi.Controllers.MessageController();

            var message = messageController.Get();

            Assert.AreEqual(message.Value, "Hello World!");
        }
    }
}
