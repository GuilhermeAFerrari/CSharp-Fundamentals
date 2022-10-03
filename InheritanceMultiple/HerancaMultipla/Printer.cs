namespace HerancaMultipla
{
    public class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string message)
        {
            Console.WriteLine("Printer processing: " + message);
        }

        public void Print(string message)
        {
            Console.WriteLine("Printer print " + message);
        }
    }
}
