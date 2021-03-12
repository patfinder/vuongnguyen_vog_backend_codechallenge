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

    }
}
