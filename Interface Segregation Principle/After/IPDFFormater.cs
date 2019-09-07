namespace solid.Interface_Segregation_Principle.After
{
    interface IPDFFormater
    {
        byte[] FormatToPDF(object file);
    }

    interface IXMLFormater
    {
        string FormatToXML(object file);
    }

    interface IJSONFormater
    {
        string FormatToJSON(object file);
    }
}
