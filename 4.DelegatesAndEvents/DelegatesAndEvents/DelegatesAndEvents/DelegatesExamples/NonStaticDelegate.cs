﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.DelegatesExamples
{
    //Удали все и напиши заново. Так будет понятнее

    public static class NonStaticDelegate
    {
        public static void ShowNonStaticDelegate()
        {
            MethodsForDelegate methodsForDelegate = new MethodsForDelegate();

            CountDelegate countDelegate = methodsForDelegate.Count;

            countDelegate();
        }
    }

    delegate void CountDelegate();

    public class MethodsForDelegate
    {
        public void Count()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine(i * 2);
        }
    }
}
