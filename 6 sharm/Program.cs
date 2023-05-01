using System;
using System.Collections.Generic;

namespace Disciplines
{
    class Program
    {
        enum Disciplines
        {

            Філософія = 1,
            Правознавство,
            ІноземнаМова,

            ОсновиПрограмування,
            ІнформаційніТехнології,
            ДискретнаМатематика,

            АрхітектураКомпютера,
            ЛюдиноМашинна,
            КомпютернаГрафіка
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Список дисциплін:");

            foreach (Disciplines discipline in Enum.GetValues(typeof(Disciplines)))
            {
                Console.WriteLine($"{(int)discipline} - {discipline}");
            }

            Console.WriteLine("Введіть номери дисциплін, які ви хотіли б вивчати (відокремлюючи номери комами):");
            string input = Console.ReadLine();

            // Розділити введений рядок на окремі номери
            string[] disciplineNumbers = input.Split(',');

            // Створити список для зберігання назв дисциплін, які користувач обрав
            List<string> selectedDisciplines = new List<string>();

            // Пройтися по кожному введеному номеру та додати назву дисципліни до списку вибраних дисциплін
            foreach (string number in disciplineNumbers)
            {
                if (Enum.TryParse(number, out Disciplines discipline))
                {
                    selectedDisciplines.Add(discipline.ToString());
                }
                else
                {
                    Console.WriteLine($"Дисципліна з номером {number} не існує.");
                }
            }

            Console.WriteLine("Ви обрали наступні дисципліни:");

            foreach (string selectedDiscipline in selectedDisciplines)
            {
                Console.WriteLine(selectedDiscipline);
            }

            Console.WriteLine("Цикл загальноосвітніх дисциплін:");
            Console.WriteLine($"{1} - {Disciplines.Філософія}, {2} - {Disciplines.Правознавство}, {3} - {Disciplines.ІноземнаМова}");

            Console.WriteLine("Цикл обов’язкових професійних дисциплін:");
            Console.WriteLine($"{1} - {Disciplines.ОсновиПрограмування}, {2} - {Disciplines.ІнформаційніТехнології}, {3} - {Disciplines.ДискретнаМатематика}");

            Console.WriteLine("Цикл дисциплін за вибором студента:");
            Console.WriteLine($"{1} - {Disciplines.АрхітектураКомпютера}, {2} - {Disciplines.ЛюдиноМашинна}, {3} - {Disciplines.КомпютернаГрафіка}");

            Console.WriteLine("Автор програми: Рзаєва С.Л.");
        }
    }
}