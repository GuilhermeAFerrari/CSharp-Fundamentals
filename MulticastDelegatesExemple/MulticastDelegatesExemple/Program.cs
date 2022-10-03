using MulticastDelegatesExemple.Services;

double a = 10;
double b = 12;

BinaryNumericOperation operation = CalculantionService.ShowMax;

// Defini mais uma referencia ao mesmo objeto delegate
operation += CalculantionService.ShowSum;

operation.Invoke(a, b);


delegate void BinaryNumericOperation(double n1, double n2);