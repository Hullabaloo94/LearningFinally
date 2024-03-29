﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("connected to database");

            try
            {
                throw new Exception("error while accessing database resource");
            }
            catch (Exception)
            {
                Console.WriteLine("exception caught");
            }
            // finally is a command that will ALWAYS run eventually. This is good for closing resources once you are done with them.
            finally
            {
                Console.WriteLine("disconnecting database");
            }
        }
    }
}
