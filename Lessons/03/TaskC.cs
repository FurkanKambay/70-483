﻿using System;

namespace Lessons._03
{
    /// <summary>
    /// Use ?? operator to implement lazy initialization of _foo backing field 
    /// in Foo getter.
    /// </summary>
    public class TaskC
    {
        private static Foo _foo;

        public static void Run()
        {
            Console.WriteLine(_foo);
            Console.WriteLine(Foo);
        }

        public static Foo Foo
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    }

    public class Foo { }
}