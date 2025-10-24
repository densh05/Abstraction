using System;
using System.Text;
using System.Threading.Channels;

namespace Abstraction
{

    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML Document open");
        }
        public override void Create()
        {
            Console.WriteLine("XML Document create");
        }
        public override void Change()
        {
            Console.WriteLine("XML Document changed");
        }
        public override void Save()
        {
            Console.WriteLine("XML Document save");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT Document open");
        }
        public override void Create()
        {
            Console.WriteLine("TXT Document create");
        }
        public override void Change()
        {
            Console.WriteLine("TXT Document changed");
        }
        public override void Save()
        {
            Console.WriteLine("TXT Document save");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC Document open");
        }
        public override void Create()
        {
            Console.WriteLine("DOC Document create");
        }
        public override void Change()
        {
            Console.WriteLine("DOC Document changed");
        }
        public override void Save()
        {
            Console.WriteLine("DOC Document save");
        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Вітаємо\n Виберіть яку версію документа ви хочте відкрити\n XML,TXT або DOC");

            string version = Console.ReadLine();

            AbstractHandler abstracthadler;

            if(version == "XML")
            {
                abstracthadler = new XMLHandler();
            }
            else if(version == "TXT")
            {
                abstracthadler = new TXTHandler();
            }
            else if (version == "DOC")
            {
                abstracthadler = new DOCHandler();
            }
            else
            {
                Console.WriteLine("Unknown");
                return;
            }

            Console.WriteLine("Тепер виберіть що ви хочете зробити:");
            Console.WriteLine("1 - Відкрити ");
            Console.WriteLine("2 - Зробити");
            Console.WriteLine("3 - Змінити");
            Console.WriteLine("4 - Зберегти");

            string choice = Console.ReadLine();

            if(choice == "1")
            {
                abstracthadler.Open();
            }
            else if(choice == "2")
            {
                 abstracthadler.Create();
            }
            else if(choice == "3")
            {
                abstracthadler.Change();
            }
            else if(choice == "4")
            {
                abstracthadler.Save();
            }
            else
            {
                Console.WriteLine("Невідомимй вибір");
            }

            Console.WriteLine("Натисніть любу клавішу для виходу");

        }
    }
}
