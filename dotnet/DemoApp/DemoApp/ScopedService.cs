
namespace DemoApp;

internal interface IScopedService
{
    void DoSomethingAsync();
    string InsaneAlgorithm();
}
internal class ScopedService: IScopedService
{
    #region DoSomethingAsync Demo
    public async void DoSomethingAsync()
    {
        List<int> largeList = new List<int>();

        for (int i = 0; i < 10000000; i++)
        {
            largeList.Add(i);
        }

        // This will throw an exception
        await DoSomething();
    }

    private Task DoSomething()
    {
        throw new Exception("Oops!");
    }
    #endregion

    #region InsaneAlgorithm Demo
    public string InsaneAlgorithm()
    {
        // Don't move this, it'll break otherwise
        var primes = new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

        var random = new Random();
        var randomNumber = random.Next(1000, 10000);

        var product = 1;
        foreach (var prime in primes)
        {
            if (prime < randomNumber)
                product *= prime;
        }

        var result = "";
        for (var i = 0; i < product.ToString().Length; i++)
        {
            if (i % 2 == 0)
                result += product.ToString()[i];
        }

        var reversedResult = "";
        for (var i = result.Length - 1; i >= 0; i--)
        {
            reversedResult += result[i];
        }

        // Adding more complexity
        var finalResult = "";
        for (var i = 0; i < reversedResult.Length; i++)
        {
            if (i % 2 == 0)
            {
                finalResult += reversedResult[i];
            }
            else
            {
                finalResult += reversedResult[i].ToString().ToUpper();
            }
        }

        var finalReversedResult = "";
        for (var i = finalResult.Length - 1; i >= 0; i--)
        {
            finalReversedResult += finalResult[i];
        }

        // Print the final result
        Console.WriteLine($"The output is: {finalReversedResult}");
        return finalReversedResult;
    }
    #endregion

    #region Incorrect Operator Demo

    internal enum MyType
    {
        None = 0,
        One = 1,
        Two = 2,
        Three = 3
    }

    internal class MySettings
    {
        public MyType SettingsType { get; set; }
        public MySettings(MyType value)
        {
            SettingsType = value;
        }
    }

    public bool OperatorEvaluation(MyType typeToCheck)
    {
        var mySettings = new MySettings(typeToCheck);
        return mySettings != null && ((mySettings.SettingsType & MyType.None) == MyType.None);
    }
    #endregion
}
