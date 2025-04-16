using System;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "abc";
        string str2 = "xyzllkj";
        string result = "";

        
        for (int i = 0; i < ( str2.Length); i++)
        {

            if (i < str1.Length)
            {
                result += str1[i];
            }

            
            if (i < str2.Length)
            {
                result += str2[i];
            }
        }

        
        Console.WriteLine(result); 
    }
}
