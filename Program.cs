using System;
using project;

namespace homework
{
    class Program
    {
        static void Main()
        {
            // Структура даних
            Book kobzar = new Book();
            kobzar.setValues("Kobzar", "Shevchenko");
            kobzar.print();
        }
    } 
}