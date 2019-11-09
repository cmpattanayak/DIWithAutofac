using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIwithAutofac
{
    public class TodayWriter : IDataWriter
    {
        private IService _output;
        public TodayWriter(IService output)
        {
            this._output = output;
        }

        public void WriteData()
        {
            _output.Write(DateTime.Today.ToShortDateString());
        }
    }
}
