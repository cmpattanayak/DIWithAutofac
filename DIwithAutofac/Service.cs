using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIwithAutofac
{
    public class Service : IService
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
