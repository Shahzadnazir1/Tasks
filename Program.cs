
class program
{
    static void Main(string[] args)
    {
        int[] number = { 27, 60, 80, 90, 20, 66 };
        int index = Array.IndexOf(number, 20);

        Console.WriteLine("The index of 20 is: " + index);
    }
}