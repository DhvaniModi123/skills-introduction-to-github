// See https://aka.ms/new-console-template for more information
void CalculateNumberProperties(int number, out bool isEven, out bool isPrime)
{
    isEven = (number % 2 == 0);

    if (number <= 1)
    {
        isPrime = false;
        return;
    }

    isPrime = true;
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}
