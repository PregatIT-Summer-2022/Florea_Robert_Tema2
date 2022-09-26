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

        // no need for the access modifier public
        public void ShowData() // this method is the one that needs an interface as all your classes will be implementing it
        {

        }
    }
}
