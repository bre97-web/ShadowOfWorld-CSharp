

namespace ShadowOfWorld_Console_CSharp {
  class Start {
    public static void Main() {

      System.Console.BackgroundColor = 0;
      
      System.Console.SetWindowSize(120 , 40);
      System.Console.SetBufferSize(120 , 40);

      ConsoleGraphic.Wellcome.Logo();

      ConsoleGraphic.Menu Core = new ConsoleGraphic.Menu();
      Core.GetMenuCenter();



      System.Console.ReadKey();
    }
  }
}

namespace ConsoleGraphic {
  public class Wellcome {
    public static void Logo() {
      for (var count = (System.Console.LargestWindowHeight) / 2 ;count > 0 ;count--) {
        System.Console.Write("\n");
      }
      System.Console.WriteLine("       == ===        =         =     ======       ==     ==     ======     =========     \n       ==    ==      ==       ==     ==    ==     ==     ==   ===          =   =   =     \n       ==     =      == =   = ==     ==     ==    ==     ==    ===             =         \n       ==  ==        ==  = =  ==     ==     ==    ==     ==       ====         =         \n       ==   ==       ==   =   ==     ==     ==    ==     ==           ==       =         \n       ==    ==      ==       ==     ==    =      ==     ==            =       =         \n       ==     ===    ==       ==    === ===       =========    =======        ===        \n");
      System.Threading.Thread.Sleep(1000);
      System.Console.Clear();
    }
  }


  public class Menu {
    public Menu() {
      MenuList = new string[] { "Game Start" , "Game Passage" , "Help" , "Back User" , "Game Exit" , " " };
      ConMax = 4;
      Con = 0;
      Active = true;
    }

    // 目录表
    private string[] MenuList;
    private int ConMax;

    private int con;
    private int Con {
      set {
        con = value;
      }
      get {
        return con;
      }
    }
    private bool Active;

    // 输出目录
    public void GetMenu() {
      foreach (string Message in MenuList) {
        System.Console.WriteLine(Message);
      }
    }
    public void GetMenu(int Item) {
      System.Console.WriteLine(MenuList[Item]);
    }
    public void GetMenuAuto() {
      System.Console.WriteLine(MenuList[Con]);
    }

    // 状态更新
    public void ActiveUpdate() {
      Active = Con == ConMax ? false : true;
    }

    // 目录
    public void GetMenuCenter() {
      GetMenu();

      while (Active) {
        GetMenuAuto();  
        if (GetMenuReadKey()) {
          ActiveUpdate();
        }
        System.Console.Write(Con);
      }

    }

    /*
     * 
     * 
     * 
     */
    public bool GetMenuReadKey() {
      
      switch (System.Console.ReadKey().KeyChar.ToString()) {
        case "w":
          Con = Con > 0 ? Con - 1 : Con;
          break;
        case "s":
          Con = Con < ConMax ? Con + 1 : Con;
          break;
        case "q":
          GetMenuControl();
          return true;
      }
      return false;
    }

    // youwenti
    public void GetMenuControl() {
      switch (Con) {
        case 0:

          break;
        case 1:

          break;
        case 2:
          GetInformation.GetHelp();
          break;
        case 3:

          break;
        case 4:    
          Con = ConMax;
          break;
      }
    }

  }

  public class GetInformation {
    public static void GetHelp() {
      System.Console.Clear();

      string[] Inf = new string[] { "Information :\n" , "??Create"};

      foreach(string Message in Inf) {
        System.Console.WriteLine(Message);
        System.Threading.Thread.Sleep(1000);
      }
      
    }

  }
}





namespace UserGroup.File {

  public class Manager {

    private static string userName;
    public static string UserName {
      set {
        userName = value.Length != 4 ? "USER NAME FORM ERROR" : value;
      }
      get {
        return userName;
      }
    }

    private readonly static string FoderPath = @"C:/Users/Public/Documents/RMDUST/ShadowOfWorld/Save/";
    private readonly static string FoderPath2 = @"C:/Users/Public/Documents/RMDUST/ShadowOfWorld/Core/";
    private readonly static string UserNameListPath = @"C:/Users/Public/Documents/RMDUST/ShadowOfWorld/Save/UserNameList.txt";

    private static System.Collections.ArrayList UserNameList = new System.Collections.ArrayList();

    public Manager() {
      Reset();
    }

    private void Reset() {
      System.IO.Directory.CreateDirectory(FoderPath);
      System.IO.Directory.CreateDirectory(FoderPath2);
      if (!System.IO.File.Exists(UserNameListPath)) {
        System.IO.File.Create(UserNameListPath).Close();
      }
    }


    // 索引本地用户存档
    public static void Find() {
      foreach (string UserName in System.IO.File.ReadAllLines(UserNameListPath)) {
        UserNameList.Add(UserName);
      }
    }

    public static bool Find(string ID) {
      foreach (string UserName in System.IO.File.ReadAllLines(UserNameListPath)) {
        UserNameList.Add(UserName);
        if (ID == UserName) {
          return true;
        }
      }
      return false;
    }

    public static void AddUser() {
      using (System.IO.StreamWriter Create = System.IO.File.AppendText(UserNameListPath)) {
        Create.Write(UserName);
        Create.Close();
      }
    }


  }


}

namespace UserGroup {
  class SignInAndSignUp {



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


    public static void Register(string ID) {
      //UserName = ID;


    }

    private static void SignUp() {
      // 打开文件并存档新的用户名

      // 创建新用户的各项信息
    }

    public static void SignIn() {
      System.Console.WriteLine("!");
    }


    // First Core
    public void Login() {

    }

  }

}