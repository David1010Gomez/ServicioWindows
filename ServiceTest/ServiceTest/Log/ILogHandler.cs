using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTest.Log
{
    public interface ILogHandler
    {
        void Write(string folderName, string logMensage, bool NuevoProceso = false);


    }
}
