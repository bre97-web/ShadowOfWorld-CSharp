using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShadowOfWorld_Console_CSharp {
  class Start {
    public static void Main() {
      //Graphic.Start.Core();

      UserGroup.SignInAndSignUp v = new UserGroup.SignInAndSignUp();
      v.Register("1010");
      
    }
  }
}

/*
namespace ConsoleGraphic {
  class Wellcome {
    public Wellcome() {
      Logo();
      Loading();
      Thread.Sleep(2000);
      System.Console.Clear();
    }
    
    private static void Logo() {
      for (var count = (Console.LargestWindowHeight) / 2;count > 0;count --) {
        Console.Write("\n");
      }
      Console.WriteLine("       == ===        =         =     ======       ==     ==     ======     =========     \n       ==    ==      ==       ==     ==    ==     ==     ==   ===          =   =   =     \n       ==     =      == =   = ==     ==     ==    ==     ==    ===             =         \n       ==  ==        ==  = =  ==     ==     ==    ==     ==       ====         =         \n       ==   ==       ==   =   ==     ==     ==    ==     ==           ==       =         \n       ==    ==      ==       ==     ==    =      ==     ==            =       =         \n       ==     ===    ==       ==    === ===       =========    =======        ===        \n");
    }
    private static void Loading() {

      for (var count = Console.LargestWindowWidth;count > 0;count --) {
        Console.Write('=');
        Thread.Sleep(50);
      }
      
    }
  }

}
*/
namespace UserGroup {

  class SignInAndSignUp {

    private string[] userNameList;
    //List<userName> userNameList = new List<userName>();

    private string userName;
    public string UserName {
      set {
        userName = value.Length != 4 ? "USER NAME FORM ERROR" : value;
      }
      get {
        return userName;
      }
    }
    
    public SignInAndSignUp() {
      

    }

    /*
     * 流程:
     *    提供用户名 -> 注册用户名
     *                   用户名已存档 -> 注册阻止 -> 登入
     *                   用户名未存档 -> 注册通过 -> 登入
     *    --------------------------------------------------
     *    Read Key -> Register
     *                TRUE -> Do not SignUp -> SignIn
     *                FALSE -> Do SignUp -> SignIn
     */

    
    public void Register(string value) {
      string Path = CSIDL_PERSONAL + "\RMDUST\ShadowOfWorld\UserNameList.txt";

      if (false == System.IO.Directory.Exists(Path)) {
        Directory.CreateDirectory(Path);
      }
      userNameList[] = System.IO.File.ReadLines(Path);



    }
    public void SignUp() {

    }
    public void SignIn() {

    }
    private string SendUserID() {

      return userName;
    }


    


    public static void Login() {

    }

  }

  

}