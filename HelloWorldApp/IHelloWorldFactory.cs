using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldApp
{
    public interface IHelloWorldFactory
    {
        IHelloWorld CreateHelloWorld(AppType appType);
    }
}
