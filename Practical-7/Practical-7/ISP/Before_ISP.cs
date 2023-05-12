using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.ISP
{
    interface IDocument
    {
        void Open();
        void Close();
        void Save();
        void SpellCheck();
    }

    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening word document..");
            //Here Logic is given
        }
        public void Close()
        {
            Console.WriteLine("Close word document..");
            //Here Logic is given
        }
        public void Save()
        {
            Console.WriteLine("Save word document..");
            //Here Logic is given
        }
        public void SpellCheck()
        {
            Console.WriteLine("Spellcheck word document..");
            //Here Logic is given
        }
    }

    public class PDFDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening pdf document..");
            //Here Logic is given
        }
        public void Close()
        {
            Console.WriteLine("Closing pdf document..");
            //Here Logic is given
        }
        public void Save()
        {
            Console.WriteLine("Save pdf document..");
            //Here Logic is given
        }
        public void SpellCheck()
        {
            // here it's not used
        }
    }
}
