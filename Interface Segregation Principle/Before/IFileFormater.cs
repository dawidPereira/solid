using System.IO;

namespace solid.Interface_Segregation_Principle.Before
{
    interface IFileFormater
    {
        byte[] FormatToPDF(object file);
        string FormatToXML(object file);
        string FormatToJSON(object file);
    }
}
