using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace öccá
{
    internal class Feladatok
    {
        public List<Vasarlo> lista;
        public Feladatok()
        {
            lista=new List<Vasarlo>();
        }

        public bool beolvas()
        {
            StreamReader sr = new StreamReader("penztar.txt");
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Vasarlo v = new Vasarlo();
                while(line != "F")
                {
                    v.Termekek.Add(line);
                    line= sr.ReadLine();
                }
                lista.Add(v);
            }
            sr.Close();
            if(lista.Count > 0)
            {
                return true;
            }
            else
            { return false;}
        }

    }
}
