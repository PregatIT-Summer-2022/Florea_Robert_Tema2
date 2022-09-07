using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florea_Robert_Tema2
{
    public  interface IPerson
    {
        public string Name { get; set; }
        public Program.House House { get; set; }

        public void ShowData()
        {

        }
    }
}
