

namespace ShadowOfWorld_Console_CSharp {
  class Start {
    public static void Main() {

      System.Console.BackgroundColor = 0;
      System.Console.SetWindowSize(120 , 40);
      System.Console.SetBufferSize(120 , 40);

      ConsoleGraphic.Wellcome.Logo();

      ConsoleGraphic.GetMenu Core = new ConsoleGraphic.GetMenu();

      // 屏蔽回车
      //System.ConsoleKeyInfo a = System.Console.ReadKey(true);
      //System.Console.ReadKey(true);

      
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


  public class GetMenu {
    public GetMenu() {

    }

    public void GetMenuCenter() {
      System.Console.WriteLine("1. Game Start\n2. Game Passage\n3. Help\n4. Back User\n0. Game Exit\n");
      string[] List = new string[] { "Game Start" , "Game Passage" , "Help" , "Back User" , "Game Exit" };

      // OK
      int Con = 0;
      while (true) {
        
        System.Console.WriteLine(List[Con = GetMenuReadKey(Con , 5)]);

        if(Con == 5) {
          break;
        }
      }
    }

    public int GetMenuReadKey(int ControlValue , int Max , string Message) {
      switch (System.Console.ReadLine().ToString()) {
        case "w":
          if (ControlValue != 0) {
            ControlValue --;
          }
          break;
        case "s":
          if (ControlValue != Max) {
            ControlValue ++;
          }
          break;
        case " ":
          if (GetMenuControl(ControlValue , 1) == 0) {
            return Max;
          }
          break;
      }
      return ControlValue;
    }
    public int GetMenuReadKey(int ControlValue , int Max) {
      string aa = System.Console.ReadKey().KeyChar.ToString();
      switch (aa) {
        case "w":
          if (ControlValue != 0) {
            ControlValue --;
          }
          break;
        case "s":
          if (ControlValue != Max) {
            ControlValue ++;
          }
          break;
        case " ":
          System.Console.WriteLine("!!");
          if (GetMenuControl(ControlValue , 1) == 0) {
            return Max;
          }
          break;
      }
      return ControlValue;
    }

    public static int GetMenuControl(int ControlValue , int mode) {
      switch (mode) {
        case 1:
          switch (ControlValue) {
            case 0:

              break;
            case 1:

              break;
            case 2:

              break;
            case 3:

              break;
            case 4:
              return 0;

          }
          break;
        case 2:
          switch (ControlValue) {
            case 0:

              break;
            case 3:
              return 0;

          }
          break;
      }
      return 0;
    }
    //private 

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