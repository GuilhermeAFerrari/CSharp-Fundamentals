using DelegateExemple.Services;

double a = 10;
double b = 12;

BinaryNumericOperation operation = CalculationService.Max;

// Sintaxe alternativa
//BinaryNumericOperation operation2 = new BinaryNumericOperation(CalculationService.Max);

double result = operation(a, b);
//double result2 = operation.Invoke(a, b);
Console.WriteLine(result);
//Console.WriteLine(result2);

delegate double BinaryNumericOperation(double n1, double n2);