﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJenkCons
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write(p.SayIt() );
        }
       public  string SayIt()
        {
            return "Hello";

        }
    }


}
