using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShadowOfWorld_Console_CSharp {
  class Start {
    static void Main(string[] args) {
      Graphic.Start.Core();

      

    }
  }
}

namespace Graphic {
  class Start {
    public static void Core() {
      Logo();
      Thread.Sleep(2000);
      Console.Clear();
    }
    private static void Logo() {
      Console.WriteLine("\n\n\n\n       == ===        =         =     ======       ==     ==     ======     =========     \n       ==    ==      ==       ==     ==    ==     ==     ==   ===          =   =   =     \n       ==     =      == =   = ==     ==     ==    ==     ==    ===             =         \n       ==  ==        ==  = =  ==     ==     ==    ==     ==       ====         =         \n       ==   ==       ==   =   ==     ==     ==    ==     ==           ==       =         \n       ==    ==      ==       ==     ==    =      ==     ==            =       =         \n       ==     ===    ==       ==    === ===       =========    =======        ===        \n");
    }
  }

}