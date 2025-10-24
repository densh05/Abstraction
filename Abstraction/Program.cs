using System;
using System.Text;
using System.Threading.Channels;

namespace Abstraction
{

    abstract class AbstractHadler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    class XMLHandler : AbstractHadler
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

    class TXTHadler : AbstractHadler
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

    class DOCHandler : AbstractHadler
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

        }
    }
}
