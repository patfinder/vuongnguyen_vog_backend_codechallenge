using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace VogCodeChallenge.Console
{
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };

        public static void TestMethod()
        {
            int index = 0;
            while (index < NamesList.Count)
            {
                System.Console.WriteLine($"Item {index + 1}: {NamesList[index]}");
                index++;
            }
        }

        public static object TESTModule(object input)
        {
            switch(input)
            {
                case int i when i >= 1 && i <= 4:
                    return i * 2;
                case int i when i > 4:
                    return i * 3;
                case int i:
                    throw new InvalidOperationException("Negative integer value is not allowed");
                case float f when f == 1.0f || f == 2.0f:
                    return 3.0f;
                case string s:
                    return s.ToUpper();
                default:
                    return input;
            }
        }
    }
}
