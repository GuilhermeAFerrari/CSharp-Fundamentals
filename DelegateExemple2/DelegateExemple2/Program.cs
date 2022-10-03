using DelegateExemple2.Entities;

Console.WriteLine("Hello, enter with your credcard:");
Console.WriteLine("1 - Visa");
Console.WriteLine("2 - MasterCard");

int userOption = int.Parse(Console.ReadLine());

OptionMessage optionCard;

if (userOption == 1)
{
    optionCard = CredCard.Visa;
}
else
{
    optionCard = CredCard.MasterCard;
}

Console.WriteLine(Message.PrintMessage(optionCard));

public delegate string OptionMessage();

