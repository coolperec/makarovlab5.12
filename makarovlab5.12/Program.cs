//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

//        string phoneNumber = CozdatNomer(numbers);

//        Console.WriteLine(phoneNumber);
//    }

//    static string CozdatNomer(int[] numbers)
//    {
//        return $"+7 ({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}-{numbers[8]}{numbers[9]}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine(TrimString("Hello, World!", 11));
//    }

//    static string TrimString(string text, int dlina)
//    {
//        if (dlina <= 3)
//        {
//            return text.Length > dlina ? text.Substring(0, dlina) + "..." : text;
//        }

//        if (text.Length > dlina)
//        {
//            return text.Substring(0, dlina - 3) + "...";
//        }

//        return text;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine(SquareDigits(5678));

//    }

//    static long SquareDigits(long n)
//    {
//        string num = n.ToString();
//        string result = "";

//        foreach (char digit in num)
//        {
//            int squared = (digit - '0') * (digit - '0');
//            result += squared.ToString();
//        }

//        return long.Parse(result);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine(Likes(new string[] { }));
//        Console.WriteLine(Likes(new string[] { "Yaroslav" }));
//        Console.WriteLine(Likes(new string[] { "Karim", "Vladislav" }));
//        Console.WriteLine(Likes(new string[] { "Dmitryi", "Maksim", "Nikita" }));
//        Console.WriteLine(Likes(new string[] { "Pavel", "Andrey", "Sonya", "Anna" }));
//    }

//    static string Likes(string[] names)
//    {
//        int count = names.Length;

//        return count switch
//        {
//            0 => "Никто не лайкнул",
//            1 => $"{names[0]} лайкнул",
//            2 => $"{names[0]} и {names[1]} лийкнули",
//            3 => $"{names[0]}, {names[1]} и {names[2]} лайкнули",
//            4 => $"{names[0]}, {names[1]} и {count - 2} другие лайкнули"
//        };
//    }
//}



