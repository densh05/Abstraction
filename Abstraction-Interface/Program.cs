using System;
using System.Text;

namespace Abstraction_Interface
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();

    }

    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player : IPlayable, IRecodable
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

        void IRecodable.Record()
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

            string choice = Console.ReadLine();

            if (choice == "1")
            {
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
