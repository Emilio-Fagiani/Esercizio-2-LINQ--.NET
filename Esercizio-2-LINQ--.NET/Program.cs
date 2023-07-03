using Esercizio_2_LINQ__.NET;

class Program
{
    static void Main()
    {
        OperationWithNumber operationWithNumber = new OperationWithNumber();
        List<int> randomNum = operationWithNumber.GenerateRandomNum(10);
        Console.WriteLine();
        Console.WriteLine("Numeri dispari: \n");

        operationWithNumber.SelectUnevenNumb(randomNum);
    }
}