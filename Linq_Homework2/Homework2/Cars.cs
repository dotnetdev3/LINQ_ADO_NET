using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Cars 
    {
        public Cars()
        {
            CarsList = new List<Car>()
            {
                new Car("BMW", "X6", 280, "SUV", new Engine(8, 547, 4.4f)),
                new Car("Porsche", "Macan", 254, "SUV", new Engine(6, 340, 3.0f)),
                new Car("Ferrary", "458 Italia", 325, "Coupe", new Engine(8, 570, 4.8f)),
                new Car("Nissan", "370Z", 300, "Coupe", new Engine(6, 336, 3.6f)),
                new Car("Mitsubishi ", "Lancer Evolution", 240, "Sedan", new Engine(4, 276, 2.0f)),
                new Car("Subaru ", "WRX STI", 250, "Sedan", new Engine(4, 268, 2.0f))
            };
        }

        public List<Car> CarsList { get; }

        public void Show()
        {
            foreach (var i in CarsList)
            {
                Console.WriteLine("Model: {0} \n\t\tProducer: {1} ,\n\t\tHighSpeed: {2} ,\n\t\tCarEngine: (cylinders:{3} ; power: {4}; liters: {5}f) ,\n\t\tBodyType: {6}\n", i.Model, i.Producer, i.HighSpeed, i.CarEngine.Cylinders, i.CarEngine.Power, i.CarEngine.Liters, i.BodyType);
            }
        }

        public void Linq_select_Cylinders()
        {
            //var select_list = new List<Car>();
            //foreach (var s in CarsList)
            //{
            //    if (s.CarEngine.Cylinders == 6)
            //        select_list.Add(s);

            //}
            //-------------------------------------------------------------------------------------------
            //var select_list = from  s in CarsList
            //                  where s.CarEngine.Cylinders == 6
            //                  orderby s.HighSpeed
            //                  select s;
            //---------------------------------------------------------------------------------------------

            var select_list = CarsList.Where(s => s.CarEngine.Cylinders == 6).OrderBy(s => s.HighSpeed).Select(s=>s);

            foreach (var s in select_list)
            {
                Console.WriteLine("Model: {0} \n\t\tProducer: {1} ,\n\t\tHighSpeed: {2} ,\n\t\tCarEngine: (cylinders:{3} ; power: {4}; liters: {5}f) ,\n\t\tBodyType: {6}\n", s.Model, s.Producer, s.HighSpeed, s.CarEngine.Cylinders, s.CarEngine.Power, s.CarEngine.Liters, s.BodyType);
            }
        }
        public void Linq_Sort_Liters_Model()
        {
            //var select_list = from s in CarsList
            //                  orderby s.CarEngine.Liters
            //                  select s;
//---------------------------------------------------------------------------------------------------------------------
            var select_list = CarsList.OrderBy(s => s.CarEngine.Liters).ThenBy(s=>s.Model).Select(s => s);

            foreach (var s in select_list)
            {
                Console.WriteLine("Model: {0} , CarEngine: (cylinders:{1} ; power: {2}; liters: {3}f) \n", s.Model, s.CarEngine.Cylinders, s.CarEngine.Power, s.CarEngine.Liters);

            }
        }
        public void Linq_Sort_Power_Liters()
        {
            //var select_list = from s in CarsList
            //                  orderby s.CarEngine.Power / s.CarEngine.Liters
            //                  select s;
//---------------------------------------------------------------------------------------------------------------
            var select_list = CarsList.OrderBy(s => s.CarEngine.Power / s.CarEngine.Liters).Select(s => s);
            foreach (var s in select_list)
            {
                Console.WriteLine("Model: {0} , CarEngine: (power: {2} / liters: {3}f = {4}) \n", s.Model, s.CarEngine.Cylinders, s.CarEngine.Power, s.CarEngine.Liters,s.CarEngine.Power/s.CarEngine.Liters);

            }
        }
        public void Linq_OrderByDescending()
        {
            //var select_list = from s in CarsList
            //                  orderby s.Model descending
            //                  select s;
//--------------------------------------------------------------------------------------------------------------
          var select_list = CarsList.OrderByDescending(s => s.Model).Select(s=>s);

            foreach (var s in select_list)
            {
                Console.WriteLine("Model: {0}", s.Model);
            }

        }

     
    }
}
