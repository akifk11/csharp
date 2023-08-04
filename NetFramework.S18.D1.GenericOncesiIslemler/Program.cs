using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D1.GenericOncesiIslemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList liste = new ArrayList();
            //liste.Add();

            sanalDatabase sanalDatabase = new sanalDatabase();
            sanalDatabase.yeniKayit(1);
            sanalDatabase.yeniKayit(2);
        }
    }
}
