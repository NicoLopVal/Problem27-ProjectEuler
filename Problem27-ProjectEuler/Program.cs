// Getting a list with all possible prime numbers below the max possible value
List<double> allPrimes = new List<double>();
allPrimes.Add(2);

double maxValue = Math.Pow(1000, 2) + 1000 * 1000 + 1000;

for(double i = 3; i <= maxValue; i = i+2)
{
    bool isPrime = true;
    foreach(double prime in allPrimes)
    {
        if(i%prime == 0)
        {
            isPrime = false;
            break;
        }
    }
    if(isPrime)
        allPrimes.Add(i);
}


// Iterating to look for the answer
int maxRepetitions = 0;
double maxA = 0;
double maxB = 0;
for (double a = -1000; a <= 1000; a++)
{
    if (a == 0)
        continue;
    for (double b = -1000; b <= 1000; b++)
    {
        int n = 1;
        while (true)
        {
            double value = Math.Pow(n,2) + (a * n) + b;
            if (allPrimes.Contains(value))
            {
                n++;
            }
            else
                break;
        }
        if(n > maxRepetitions)
        {
            maxRepetitions = n;
            maxA = a;
            maxB = b;
        }
    }
}

//Answer
Console.WriteLine("The coeficient a is: {0}", maxA);
Console.WriteLine("The coeficient b is: {0}", maxB);
Console.WriteLine("The product of a and b is: {0}", maxA * maxB);