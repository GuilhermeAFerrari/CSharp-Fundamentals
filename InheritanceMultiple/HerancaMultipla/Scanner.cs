using System.Reflection.Metadata;
using System.Xml.Linq;

namespace HerancaMultipla
{
    public class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string message)
        {
            Console.WriteLine("Scan processing: " + message);
        }

        public string Scan()
        {
            return $"Scan: {SerialNumber}";
        }
    }
}
