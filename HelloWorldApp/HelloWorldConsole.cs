using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldApp
{
    public class HelloWorldConsole : HelloWorldBase, IHelloWorld
    {

        public void PrintMessage()
        {
            Console.WriteLine(this.Message);
        }
    }
}
