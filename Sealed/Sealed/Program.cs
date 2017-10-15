using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed
{
    
        public class Information
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public virtual void ShowInfo() { }

        }

        public sealed class JHInfo : Information
        {
            public sealed override void ShowInfo()
            {
                Console.WriteLine("進貨信息:\n" + Code + " " + Name);
            }
        }

        class Program
        {

            static void Main(string[] args)
            {

                JHInfo jhinfo = new JHInfo();
                jhinfo.Code = "JH001";
                jhinfo.Name = "test";
                jhinfo.ShowInfo();
                Console.ReadLine();

            }
    }
}
