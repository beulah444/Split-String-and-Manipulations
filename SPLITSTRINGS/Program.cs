using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //String Reverse
        //Example Preethi => ihteer
        string Name = "Preethi";
        String ReverseName = Name.ToCharArray().Select(c => c.ToString()).Aggregate<string>((a1, a2) => (a2 + a1));
        Console.WriteLine("string {0} is reversed to {1}", Name, ReverseName);
        //Digit Reverse
        //Example 1234 => 4321
        int Number = 123456789;
        int ReverseNumber = int.Parse(Number.ToString().ToCharArray().Select(c => c.ToString()).Aggregate<string>((a1, a2)=>(a2 + a1)));
        Console.WriteLine("Integer {0} is reversed to {1}", Number, ReverseNumber);
        //Split Digit and Number and Reverse the substring and join into a string
        //Example Preethi1234 => ihteerP4321
        string LettersDigits = "Preethi1234";
        string LetterOnly = new string(LettersDigits.TakeWhile(c => char.IsLetter(c)).ToArray());
        Console.WriteLine("Letter Part of  {0} is  {1}", LettersDigits, LetterOnly);
        string DigitOnly = new string(LettersDigits.Skip(LetterOnly.Length).TakeWhile(c => char.IsDigit(c)).ToArray());
        Console.WriteLine("Digit Part of  {0} is  {1}", LettersDigits, DigitOnly);
        string ReverseLetterOnly = LetterOnly.ToCharArray().Select(c => c.ToString()).Aggregate<string>((a1, a2) => (a2 + a1));
        Console.WriteLine("Letter Part {0} is reversed as {1}",LetterOnly, ReverseLetterOnly);
        string ReverseDigitOnly = DigitOnly.ToCharArray().Select(c => c.ToString()).Aggregate<string>((a1, a2) => (a2 + a1));
        Console.WriteLine("Digit Part {0} is reversed as {1}", DigitOnly, ReverseDigitOnly);
        string Reversed_DigitLetter = string.Join("",ReverseLetterOnly, ReverseDigitOnly);
        Console.WriteLine("Finally given String {0} is reversed as {1}", LettersDigits, Reversed_DigitLetter);
        Console.ReadKey();
    }
}
