using System;
using System.Linq;

namespace Hw._28._01._21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Метод pop
            var arr = new[] { "o", "p" };
            Console.WriteLine(ArrayHelper.Pop(ref arr));
            foreach (var team in arr)
            {
                Console.WriteLine($"team: {team}");
            }
            // Метод push
            var ar = new[] { "o", "p" };
            Console.WriteLine(ArrayHelper.Push(ref arr, "e"));
            foreach (var team in arr)
            {
                Console.WriteLine($"team: {team}");
            }
            // Метод shift
            var array = new[] { "o", "p" };
            Console.WriteLine(ArrayHelper.Shift(ref arr));
            foreach (var team in arr)
            {
                Console.WriteLine($"team: {team}");
            }
            // Метод unshift
            var arrea = new[] { "o", "p" };
            Console.WriteLine(ArrayHelper.UnShift(ref arrea, "p"));
            foreach (var team in arr)
            {
                Console.WriteLine($"team: {team}");
            }
        }

    } 

        public static class ArrayHelper
        {
        // Метод pop
        public static string Pop(ref string[] args)
            {
                var lastThings = args[1];
                args = args.Take(args.Length - 1).ToArray();
                return lastThings;
            }

            public static int Pop(ref int[] args)
            {
                var lastThings = args[2];
                args = args.Take(args.Length - 2).ToArray();
                return lastThings;
            }

            public static double Pop(ref double[] args)
            {
                var lastThings = args[3];
                args = args.Take(args.Length - 3).ToArray();
                return lastThings;
            }

            public static decimal Pop(ref decimal[] args)
            {
                var lastThings = args[4];
                args = args.Take(args.Length - 4).ToArray();
                return lastThings;
            }

            public static float Pop(ref float[] args)
            {
                var lastThings = args[5];
                args = args.Take(args.Length - 5).ToArray();
                return lastThings;
            }
        // Метод push
        public static int Push(ref string[] args, string Things )
            {
                var elements = args.Append(Things);
                args = new string[args.Length];
                args = elements.ToArray();
                return args.Length;
            }

            public static int Push(ref int[] args, int element)
            {
                var elements = args.Append(element);
                args = new int[args.Length];
                args = elements.ToArray();
                return args.Length;
            }

            public static int Push(ref double[] args, double element)
            {
                var elements = args.Append(element);
                args = new double[args.Length];
                args = elements.ToArray();
                return args.Length;
            }

            public static int Push(ref decimal[] args, decimal element)
            {
                var elements = args.Append(element);
                args = new decimal[args.Length];
                args = elements.ToArray();
                return args.Length;
            }

            public static int Push(ref float[] args, float element)
            {
                var elements = args.Append(element);
                args = new float[args.Length];
                args = elements.ToArray();
                return args.Length;
            }
        // Метод shift
        public static string Shift(ref string[] args)
            {
                var firstThings = args[0];
                args = args.Skip(1).ToArray();
                return firstThings;
            }

            public static int Shift(ref int[] args)
            {
                var firstThings = args[0];
                args = args.Skip(1).ToArray();
                return firstThings;
            }

            public static double Shift(ref double[] args)
            {
                var firstThings = args[0];
                args = args.Skip(1).ToArray();
                return firstThings;
            }

            public static decimal Shift(ref decimal[] args)
            {
                var firstThings = args[0];
                args = args.Skip(1).ToArray();
                return firstThings;
            }

            public static float Shift(ref float[] args)
            {
                var firstThings = args[0];
                args = args.Skip(1).ToArray();
                return firstThings;
            }
        // Метод unshift
        public static int UnShift(ref string[] args, string element)
            {
                args = new[] { element }.Concat(args).ToArray();
                return args.Length;
            }

            public static int UnShift(ref int[] args, int element)
            {
                args = new[] { element }.Concat(args).ToArray();
                return args.Length;
            }

            public static int UnShift(ref double[] args, double element)
            {
                args = new[] { element }.Concat(args).ToArray();
                return args.Length;
            }

            public static int UnShift(ref decimal[] args, decimal element)
            {
                args = new[] { element }.Concat(args).ToArray();
                return args.Length;
            }

            public static int UnShift(ref float[] args, float element)
            {
                args = new[] { element }.Concat(args).ToArray();
                return args.Length;
            }
        }
    
}
