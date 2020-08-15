using System;
using System.Collections.Generic;
using System.Text;

namespace singletondemo
{
    public class Singleton
    {
        private static int ObjectsCount = 0;
        public static Singleton GetInstance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            internal static readonly Singleton instance = new Singleton();
            static Nested()
            {
            }
        }

        private Singleton()
        {
            ObjectsCount++;
            Console.WriteLine($"instances {ObjectsCount}");
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
