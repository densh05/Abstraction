using System;
using System.Text;

namespace Abstraction_Interface
{
    interface IPlayable // Створюємо інтерфейс
    {
        void Play(); //Створюємо абстрактні методи
        void Pause();
        void Stop();

    }

    interface IRecodable //Створюємо другий інтерфейс
    {
        void Record(); //Створюємо абстрактні методи
        void Pause();
        void Stop();
    }

    class Player : IPlayable, IRecodable //Створюємо класс,реалізовуємо інтерфейси
    {
         public void Play()
        {
            Console.WriteLine("Запис відтворюється");
        }
        public void Pause()
        {
            Console.WriteLine("Запис призупинено");
        }

        public void Stop()
        {
            Console.WriteLine("Запис закінчено");
        }

        void IRecodable.Record() //Робимо теїніку явної вказівки імені інтерфейсу
        {
            Console.WriteLine("Запис розпочато");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Запис призупинено");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Запис закінчено");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

           

            Console.WriteLine("Вітаю,якщо ви хочете продивитись відео,натисніть - 1\nЯкщо хочете записати своє відео,натисніть - 2.");

            string choice = Console.ReadLine(); //Стрінгова змінна 

            if (choice == "1") //If-Else 
            {
                //Змінна playable типу IPlayable,Так як класс Player спадкований від двох інтерфейсів
                //Просимо щоб змінна pllayable вміла робити все,що в інтерфейсі IPlayable

                IPlayable playable = new Player(); 

                playable.Play();
                playable.Pause();
                playable.Stop();
            }

            else if (choice == "2")
            {
                IRecodable recodable = new Player();

                recodable.Record();
                recodable.Pause();
                recodable.Stop();
            }
            else
            {
                Console.WriteLine("Unknown");
            }

            Console.WriteLine("До зустрічі!");


        }
    }
}
