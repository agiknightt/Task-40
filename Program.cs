using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_40
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Prisoner> prisoners = new List<Prisoner>();

            AddPrisoner(prisoners);

            Console.WriteLine("Список заключенных до амнистии\n");

            for (int i = 0; i < prisoners.Count; i++)
            {
                prisoners[i].ShowInfo();
            }

            var fillteredPrisoners = from Prisoner prisoner in prisoners where prisoner.Crime != "Антиправительственное" select prisoner;

            Console.WriteLine("Список заключенных после амнистии\n");

            foreach (var prisoner in fillteredPrisoners)
            {
                prisoner.ShowInfo();
            }
            Console.ReadKey();
        }

        private static void AddPrisoner(List<Prisoner> prisoners)
        {
            prisoners.Add(new Prisoner("Иванов Игорь", "Антиправительственное"));
            prisoners.Add(new Prisoner("Антонов Антон", "Кража"));
            prisoners.Add(new Prisoner("Викторов Виктор", "Антиправительственное"));
            prisoners.Add(new Prisoner("Ластиков Генадий", "Убийство"));
            prisoners.Add(new Prisoner("Васильев Василий", "Антиправительственное"));
            prisoners.Add(new Prisoner("Нагиев Дмитрий", "Убийство"));
            prisoners.Add(new Prisoner("Хренова Гадя", "Убийство"));
        }
    }
    class Prisoner
    {
        public string Name { get; private set; }
        public string Crime { get; private set; }
        public Prisoner(string name, string crime)
        {
            Name = name;
            Crime = crime;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Имя - {Name}\n\nЗаключен за - {Crime}\n");
        }
    }
}
