﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.DelegatesExamples
{
    public static class BasicSyntaxDelegate
    {
        //Обьявляем делегат
        //Данный делегат может указывать на любой метод с имеет возвращемый тип void и не принимает параметров
        delegate void CountDelegate();

        public static void ShowDelegate()
        {
            //Передаем ссылку на метод при создании экзмепляра делегата
            CountDelegate countDelegate = new CountDelegate(Discount);

            //Вызываем метод на который указывает делегат
            countDelegate.Invoke();
        }

        //Обьявляем методы с идентичной делегату сигнатурой
        public static void Count()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine(i*2);
        }

        public static void Discount()
        {
            Console.WriteLine("Congratulations! You got discount for 25%");
        }
    }
}
