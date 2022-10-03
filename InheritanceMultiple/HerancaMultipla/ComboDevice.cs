namespace HerancaMultipla
{
    public class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine("ComboDevice print: " + message);
        }

        public override void ProcessDoc(string message)
        {
            Console.WriteLine("ComboDevice ProcessDoc: " + SerialNumber);
        }

        public string Scan()
        {
            return $"ComboDevice Scan: {SerialNumber}";
        }
    }
}
