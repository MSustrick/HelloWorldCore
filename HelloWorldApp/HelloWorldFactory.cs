using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldApp
{
    public class HelloWorldFactory: IHelloWorldFactory
    {
        public IHelloWorld CreateHelloWorld(AppType appType)
        {
            switch(appType)
            {
                case AppType.Console:

                    return new HelloWorldConsole();

                default:

                    throw new NotImplementedException();
            }
        }
    }
}
