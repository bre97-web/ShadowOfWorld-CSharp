

namespace ShadowOfWorld_Console_CSharp {
  class Start {
    public static void Main() {
      //Graphic.Start.Core();

      UserGroup.SignInAndSignUp v = new UserGroup.SignInAndSignUp();
      
      v.Register("8771");

      UserGroup.Manager fs = new UserGroup.Manager();
      UserGroup.Manager.Find();



      System.Console.ReadKey();
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
  
  public class Manager {

    private readonly static string UserNameListPath = @"C:/Users/Public/Documents/RMDUST/ShadowOfWorld/Save/UserNameList.txt";
    public static string[] UserNameList;

    public Manager() {
        Reset();
    }

    // 初始化
    private void Reset() {
      
      System.IO.File.Create(UserNameListPath);

    }


    // 索引本地用户存档
    public static void Find() {
      int Line = 0;
        
      UserNameList = new string[] { null};
      foreach (string UserName in System.IO.File.ReadAllLines(UserNameListPath)) {
        UserNameList[Line] = UserName;
        Line++;
      }
                
    }
    public static void Find(string ID) {
        
    }  


  }

  class SignInAndSignUp {

    public string[] UserNameList = new string[6];

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

    
    public void Register(string ID) {
      UserName = ID;

      // 创建本地文件夹
      System.IO.Directory.CreateDirectory(@"C:/RMDUST/ShadowOfWorld/UserNameList/");

      
      

    }

    public void SignUp() {
      // 打开文件并存档新的用户名
      using (System.IO.StreamWriter Create = System.IO.File.AppendText(@"C:/RMDUST/ShadowOfWorld/UserNameList/02.txt"))
      {
        Create.Write(UserName);
        Create.Close();
      }
      // 创建新用户的各项信息
    }

    public void SignIn() {
      System.Console.WriteLine("!");
    }

    private string SendUserID() {

      return userName;
    }
    // First Core
    public static void Login() {

    }

  }

}