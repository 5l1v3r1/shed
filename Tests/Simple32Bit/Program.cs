﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple32Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pointer size (should be 4) is:" + IntPtr.Size);
            System.Threading.Thread.Sleep(3000);
        }
    }
}
