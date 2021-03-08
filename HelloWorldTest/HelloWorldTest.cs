using HelloWorld.Service;
using System;
using Xunit;

namespace HelloWorldTest
{
    public class CheckHelloTest
    {
        [Fact]
        public void SuccessCase()
        {
            var helloWorld = new HelloWorldService();
            Assert.Equal("HelloWorld", helloWorld.GetHelloWorld());          
        }
    }
}
