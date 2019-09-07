using System;
using System.Collections.Generic;
using System.Text;

namespace solid.Interface_Segregation_Principle.Before
{
    public class FileFormater : IFileFormater
    {
        public byte[] FormatToPDF(object file)
        {
            throw new NotImplementedException();
            //...
        }

        public string FormatToXML(object file)
        {
            //...
            return default;
        }

        public string FormatToJSON(object file)
        {
            //...
            return default;
        }
    }
}
