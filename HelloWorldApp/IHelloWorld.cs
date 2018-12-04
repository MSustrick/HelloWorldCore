using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    public interface IHelloWorld
    {
        Task<string> GetMessage();

        void PrintMessage();
    }
}
