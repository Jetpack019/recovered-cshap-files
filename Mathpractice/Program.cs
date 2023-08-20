using System;
using MyMathLibrary;

namespace MyApp {
    class Program {
        static void Main(string[] args) {
            int result = MathHelper.Add(5, 3);
            Console.WriteLine("Result of addition: " + result);
        }
    }
}
