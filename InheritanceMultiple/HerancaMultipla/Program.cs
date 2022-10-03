using HerancaMultipla;

Printer printer = new Printer { SerialNumber = 1025 };
printer.Print("My doc");
printer.ProcessDoc("My doc");

Scanner scanner = new Scanner { SerialNumber = 1475 };
Console.WriteLine(scanner.Scan());
scanner.ProcessDoc("My doc scan");

ComboDevice comboDevice = new ComboDevice() { SerialNumber = 3395 };
comboDevice.Print("My doc combo");
comboDevice.ProcessDoc("My doc combo");
Console.WriteLine(comboDevice.Scan());
