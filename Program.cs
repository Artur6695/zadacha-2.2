using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        private static List<Sentance> _sentances = new List<Sentance>();

        static void Main(string[] args)
        {
            Sentance s1 = new Sentance(50, "Hello world!");
            Sentance s2 = new Sentance(35, "Hello, mister Visiter!");
            Sentance s3 = new Sentance(111, "Привет, как твои дела?");
            Sentance s4 = new Sentance(66, "London is a capital of Great Britain.");
            Sentance s5 = new Sentance(222, "На дворе трава, на траве дрова");
            _sentances.Add(s1);
            _sentances.Add(s2);
            _sentances.Add(s3);
            _sentances.Add(s4);
            _sentances.Add(s5);

            Console.WriteLine("Список:");
            Print();

            Console.WriteLine("\nВведите номер критерия! \n1. По максимальному кол-ву символов в предложении \n2. По кол-ву слов");
            string s = Console.ReadLine();
            int x = int.Parse(s);
            
            Sort(x);
            Console.WriteLine("\nСписок, после сортировки:");
            Print();

            _sentances.Add(new Sentance(56, "Еще одно предложение."));
            Console.WriteLine("\nВведите номер позиции, в которую нужно добавить новое предложение (от 0 до {0})", _sentances.Count - 1);
            s = Console.ReadLine();
            int index = int.Parse(s);
            _sentances.Insert(index, new Sentance(90, "Это предложение нужно удалить."));

            Console.WriteLine("\nСписок, после добавления предложений в конец и в заданную позицию списка:");
            Print();

            _sentances.RemoveAt(_sentances.Count - 1);
            _sentances.RemoveAt(index);

            Console.WriteLine("\nНажмите Enter для продолжения!");
            Console.ReadLine();

            Console.WriteLine("\nСписок, после удаления двух, ранее добавленных, предложений:");
            Print();

            Console.WriteLine("\nВведите номер критерия! \n1. По максимальному кол-ву символов в предложении \n2. По кол-ву слов");
            s = Console.ReadLine();
            x = int.Parse(s);
            Console.WriteLine("\nВведите значение параметра поиска");
            s = Console.ReadLine();
            int e = int.Parse(s);
            if (x == 1)
                index = _sentances.FindIndex(i => i.MaxChar == e);
            else if (x == 2)
                index = _sentances.FindIndex(i => i.WordsCount == e);
            else
                Console.WriteLine("\nТакого критерия/значения не существует");

            Console.WriteLine("\nНайденный элемент поиска:\n");
            Console.WriteLine("Слов: {0} \nМакс. кол-во символов: {1} \nПредложение: {2}", _sentances[index].WordsCount, _sentances[index].MaxChar, _sentances[index].SentanceThis);

            _sentances.Clear();
            Console.WriteLine("\nСписок пуст!");

            Console.ReadLine();
        }

        static void Sort(int x)
        {
            for (int i = 1; i < _sentances.Count; i++)
            {
                for (int j = 0; j < _sentances.Count - i; j++)
                {
                    if (x == 1)
                    {
                        if (_sentances[j].MaxChar > _sentances[j + 1].MaxChar)
                        {
                            Sentance s = _sentances[j];
                            _sentances[j] = _sentances[j + 1];
                            _sentances[j + 1] = s;
                        }
                    }
                    else
                    {
                        if (_sentances[j].WordsCount > _sentances[j + 1].WordsCount)
                        {
                            Sentance s = _sentances[j];
                            _sentances[j] = _sentances[j + 1];
                            _sentances[j + 1] = s;
                        }
                    }
                }
            }
        }

        static void Print()
        {
            for (int i = 0; i < _sentances.Count; i++)
            {
                Console.WriteLine("\nСлов: {0}", _sentances[i].WordsCount);
                Console.WriteLine("Максимальное кол-во символов: {0}", _sentances[i].MaxChar);
                Console.WriteLine("Предложение: {0}", _sentances[i].SentanceThis);
            }
        }
    }
}
