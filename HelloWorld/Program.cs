using System;

namespace HelloWorld
{
    /// <summary>
    /// メインクラス
    /// </summary>
    public class Program
    {
        /// <summary>
        /// メインメソッド
        /// </summary>
        public static void Main()
        {
            int test = 5;
            Console.WriteLine("test is {0}", test + 1);
            Console.WriteLine("Hello .NET Core {0}!", Environment.Version.ToString());
        }
    }
}
