using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace öccá
{
    internal class Vasarlo
    {
        private List<string> termekek;
        public Vasarlo() 
        {
            termekek=new List<string>();
        }

        public List<string> Termekek { get => termekek; set => termekek = value; }
        public override string ToString()
        {
            foreach(var item in termekek)
            {
                return item;
            }
            return "a";
        }
    }
}
