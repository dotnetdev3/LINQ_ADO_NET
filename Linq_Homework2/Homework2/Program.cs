//## Изучить материал
//(Основы LINQ)[https://metanit.com/sharp/tutorial/15.1.php] - всю главу 19

//## Практическая работа
//Используя коллекцию `CarsList` выполнить запросы на LINQ:
//* Выбрать все 6-цилиндровые автомобили и отсортировать по скорости
//* Отсортировать по объему двигателя и модели
//* Отсортировать по эффективности двигателя(соотношение мощности и объема)
//* Получить коллекцию моделей(только название модели, не весь объект) отсортированную по убыванию

//Для каждого запроса написать по 2 варианта - классический(`from x in xxx...`)
//и используя extension-методы

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars c = new Cars();
            c.Show();
            Console.WriteLine("=====================================================");
            c.Linq_select_Cylinders();
            Console.WriteLine("=====================================================");
            c.Linq_Sort_Liters_Model();
            Console.WriteLine("=====================================================");
            c.Linq_Sort_Power_Liters();
            Console.WriteLine("=====================================================");
            c.Linq_OrderByDescending();




            Console.Read();
        }
    }
}
