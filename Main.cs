
/// <summary>
/// 包含 Main 的命名空间
/// </summary>
namespace ShadowOfWorld_Console_CSharp {
  /// <summary>
  /// 程序启动
  /// </summary>
  public class Start {

    // "active" Control Running "Part1" Function in Main
    private static bool active;
    public static bool RunningTime {
      set {
        active = value;
      }
      get {
        return active;
      }
    }

    public static void Main() {

      // Default is true
      RunningTime = true;

      {
        System.Console.SetWindowSize(120 , 40);
        System.Console.SetBufferSize(121 , 40);
        System.Console.ForegroundColor = System.ConsoleColor.Black;
        System.Console.BackgroundColor = System.ConsoleColor.White;
        System.Console.OutputEncoding = System.Text.Encoding.Unicode;
        System.Console.CursorVisible = false;
        System.Console.Title = "RMDUST TEST";
      }
      
      
      egg.Days time = new egg.Days();

      ConsoleGraphic.Wellcome.Logo();

      Part1();
    }

    /// <summary>
    /// 启动
    /// </summary>
    private static void Part1() {
      Group.File.Manager.CoreInit();

      ConsoleGraphic.Menu Core = null;
      do {
        Core = new ConsoleGraphic.Menu();
        Core.MenuList = new string[] { "Game Start" , "Game Passage" , "Help" , "Back User" , "Game Exit" };
        Core.ConMax = 4;
        Core.ConMin = 0;

        // Get name of user
        Group.SignInAndSignUp.Register();
        // Create file of private user
        Group.File.Manager.Init(Group.User.UserName);
        Core.GetMenuCenter();

        Core = null;
      } while (RunningTime);
      
    }
  }
}

namespace ConsoleGraphic.Format {

  public class Write{
    public readonly static char text = '=';
    public readonly static char Space = ' ';

    public static void Init() {

    }

    /// <summary>
    /// 输出一条控制台宽度的横条
    /// </summary>
    public static void Print() {
      for (int Count = System.Console.WindowWidth-1;Count > 0 ;Count --) {
        System.Console.Write(text);
      }
    }
    /// <summary>
    /// 输出一条带尾回车的控制台宽度的横条
    /// </summary>
    public static void Println() {
      Print();
      System.Console.WriteLine();
    }
    /// <summary>
    /// 输出一条带首回车的控制台宽度的横条
    /// </summary>
    public static void Printl() {
      System.Console.WriteLine();
      Print();
    }
    public static void Printf() {
      Printl();
      System.Console.WriteLine();
    }

    /// <summary>
    /// 输出带有信息的横幅
    /// </summary>
    /// <param name="Message"></param>
    public static void Line(string Message) {
      Println();
      System.Console.WriteLine(Message);
      Println();
    }
    /// <summary>
    /// 输出带有信息的横幅
    /// </summary>
    /// <param name="Message"></param>
    public static void Line(string[] Message) {
      Println();
      foreach (string Value in Message) {
        System.Console.WriteLine(Value);
      }
      System.Console.WriteLine();
      Println();
    }
    /// <summary>
    /// 输出带有信息的横幅
    /// </summary>
    /// <param name="Message"></param>
    public static void Line(System.Collections.ArrayList Message) {
      Println();
      foreach (string Value in Message) {
        System.Console.WriteLine(Value);
      }
    }
  }

  /// <summary>
  /// 输出按固定格式框架的控制台信息
  /// </summary>
  public class En : Write {
    
    public static int WindowWidthStart = System.Console.WindowWidth / 2;
    public static int WindowWidthEnd = WindowWidthStart - 3;
    public static string Message;
    public static int MessageLength;

    /// <summary>
    /// 输出带有边缘边框的,信息的横幅
    /// </summary>
    public static void SquareLine() {
      Println();
      Printf();
    }
    /// <summary>
    /// 输出带有边缘边框的,信息的横幅[字母 和 数字]
    /// </summary>
    /// <param name="Message"></param>
    public static void SquareLine(string Message) {
      En.Message = Message;
      En.MessageLength = En.Message.Length;

      Println();
      System.Console.Write(text);

      for (int Count = WindowWidthStart - MessageLength ;Count > 0 ;Count--) {
        System.Console.Write(' ');
      }
      System.Console.Write(Message);
      for (int Count = WindowWidthEnd;Count > 0 ;Count--) {
        System.Console.Write(' ');
      }
      System.Console.Write(text);
      Printf();

    }
    /// <summary>
    /// 输出带有边缘边框的,信息的横幅[字母 和 数字]
    /// </summary>
    /// <param name="Message"></param>
    public static void SquareLine(int Message) {
      Println();
      System.Console.Write(text);

      for (int Count = WindowWidthStart - Message.ToString().Length/2 ;Count > 0 ;Count--) {
        System.Console.Write(' ');
      }
      System.Console.Write(Message);
      for (int Count = WindowWidthEnd - 1 - (Message.ToString().Length % 2 == 0 ? Message.ToString().Length / 2 - 1 : Message.ToString().Length / 2);Count > 0 ;Count--) {
        System.Console.Write('?');
      }
      System.Console.Write(text);
      Printf();

    }
    /// <summary>
    /// 输出带有边缘边框的,信息的横幅[汉字]
    /// </summary>
    /// <param name="Message"></param>
    public static void SquareLine(System.Collections.ArrayList Message) {
      Println();

      foreach (string Value in Message) {
        System.Console.Write(text);

        for (int Count = WindowWidthStart - Value.Length / 2 ;Count > 0 ;Count--) {
          System.Console.Write(' ');
        }
        System.Console.Write(Value);
        for (int Count = WindowWidthEnd - 1 - (Value.Length % 2 == 0 ? Value.Length / 2 - 1 : Value.Length / 2);Count > 0 ;Count--) {
          System.Console.Write(' ');
        }
        System.Console.WriteLine(text);
      }
      Printf();
    }
  }
  public class Ch : Write {

    public static int WindowWidthStart = System.Console.WindowWidth / 2;
    public static int WindowWidthEnd = WindowWidthStart - 3;
    public static string Message;
    public static int MessageLength;

    /// <summary>
    /// 输出带有边缘边框的,信息的横幅[汉字]
    /// </summary>
    public static void SquareLine() {
      En.SquareLine();
    }
    /// <summary>
    /// 输出带有边缘边框的,信息的横幅[汉字]
    /// </summary>
    /// <param name="Message"></param>
    public static void SquareLine(string Message) {
      Ch.Message = Convert.Fix(Message);
      Ch.MessageLength = Ch.Message.Length;

      Println();
      System.Console.Write(text);

      for(int Count = WindowWidthStart - MessageLength;Count > 0;Count --) {
        System.Console.Write(Space);
      }
      System.Console.Write(Message);
      for (int Count = WindowWidthEnd - MessageLength;Count > 0 ;Count --) {
        System.Console.Write(Space);
      }
      System.Console.Write(text);
      Printf();
    }
    /// <summary>
    /// 输出带有边缘边框的,信息的横幅[汉字]
    /// </summary>
    /// <param name="Message"></param>
    public static void SquareLine(System.Collections.ArrayList Message) {
      Println();

      foreach (string Value in Message) {
        Ch.Message = Convert.Fix(Value);
        Ch.MessageLength = Ch.Message.Length;

        System.Console.Write(text);

        for (int Count = WindowWidthStart - Ch.MessageLength / 2 - 1;Count > 0 ;Count--) {
          System.Console.Write(Space);
        }
        System.Console.Write(Value);
        for (int Count = WindowWidthEnd - (Ch.MessageLength % 2 == 0 ? Ch.MessageLength / 2 - 1 : Ch.MessageLength / 2);Count > 0 ;Count --) {
          System.Console.Write(Space);
        }
        System.Console.WriteLine(text);
      }
      Printf();
    }
  }

  public class Convert {
    public void Auto() {
    }
    public void Auto(string Message) {
    }

    public static string Fix(int Message) {
      return " ";
    }
    public static string Fix(string Message) {
      foreach (char Value in Message) {
        if(Value >= '0' && Value <= 'z') {
          Message = Message.Replace(Value,'式');
        }
      }
      return Message;
    }
    // TODO
    public static System.Collections.ArrayList Fix(System.Collections.ArrayList Message) {
      int count = 0;
      foreach (char[] Value in Message) {
        // This Bug
        string ConMessage = Value.ToString();
        for (int temp = Value.Length - 1;temp > 0;temp --) {
          if(Value[temp] >= '0' && Value[temp] <= 'z') {
            ConMessage = Value.ToString().Replace(Value[temp],'范');
          }
          Message.RemoveAt(count);
          Message.Add(ConMessage);
        }
        count ++;
      }
      return Message;
    }
  }
}

/// <summary>
/// 表示与控制台相关的,特定的图形输出
/// </summary>
namespace ConsoleGraphic {
  /// <summary>
  /// 程序启动时显示的开发者信息
  /// </summary>
  public class Wellcome {
    /// <summary>
    /// 开发者团队图标
    /// </summary>
    public static void Logo() {
      for (var count = (System.Console.LargestWindowHeight) / 2 ;count > 0 ;count--) {
        System.Console.Write("\n");
      }
      System.Console.WriteLine("       == ===        =         =     ======       ==     ==     ======     =========     \n       ==    ==      ==       ==     ==    ==     ==     ==   ===          =   =   =     \n       ==     =      == =   = ==     ==     ==    ==     ==    ===             =         \n       ==  ==        ==  = =  ==     ==     ==    ==     ==       ====         =         \n       ==   ==       ==   =   ==     ==     ==    ==     ==           ==       =         \n       ==    ==      ==       ==     ==    =      ==     ==            =       =         \n       ==     ===    ==       ==    === ===       =========    =======        ===        \n");
      System.Threading.Thread.Sleep(1000);
      System.Console.Clear();
    }
  }




  

  /// <summary>
  /// 表示图形菜单的输出,控制流
  /// </summary>
  public class Menu {
    public Menu() {
      
      Active = true;
    }

    public string[] MenuList;
    public int ConMax;
    public int ConMin;
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

    /// <summary>
    /// 输出表示图形菜单的值
    /// </summary>
    private void GetMenu() {
      foreach (string Message in MenuList) {
        System.Console.WriteLine(Message);
      }
    }
    /// <summary>
    /// 输出表示图形菜单的特定值
    /// </summary>
    /// <param name="Item"></param>
    private void GetMenu(int Item) {
      System.Console.WriteLine(MenuList[Item]);
    }
    /// <summary>
    /// 自动输出表示图形菜单的特定值
    /// </summary>
    private void GetMenuAuto() {
      System.Console.WriteLine(MenuList[Con]);
    }

    /// <summary>
    /// 更新控制开关状态
    /// </summary>
    private void ActiveUpdate() {
      Active = Con == ConMax ? false : true;
    }

    /// <summary>
    /// 运作中心
    /// </summary>
    public void GetMenuCenter() {
      System.Console.Clear();
      while (Active) {
        GetMenu();
        GetMenuAuto();  
        if (GetMenuReadKey()) {
          ActiveUpdate();
        }
        System.Console.Clear();
      }

    }
    /// <summary>
    /// 获取控制台键入值,作出相应反应
    /// </summary>
    /// <returns></returns>
    public bool GetMenuReadKey() {
      
      switch (System.Console.ReadKey().KeyChar.ToString()) {
        case "w":
          Con = Con > 0 ? Con - 1 : Con;
          break;
        case "s":
          Con = Con < ConMax ? Con + 1 : Con;
          break;
        case " ":
          GetMenuControl();
          return true;
      }
      return false;
    }

    /// <summary>
    /// 依据Con的值作出相应反应
    /// </summary>
    public void GetMenuControl() {
      switch (Con) {
        case 0:
          Game.GameCenter.GameStart();
          break;
        case 1:
          
          ConsoleGraphic.Menu Cc = new Menu();
          Cc.MenuList = new string[] { "开发中" , "开发中." , "开发中..."};
          Cc.ConMax = 2;
          Cc.GetMenuCenter();
          
          break;
        case 2:
          GetInformation.GetHelp();
          break;

        // 注销并返回登入状态
        case 3:
          Con = ConMax;
          //ShadowOfWorld_Console_CSharp.Start.RunningTime = false;
          break;
        // 终止运行
        case 4:
          Con = ConMax;
          ShadowOfWorld_Console_CSharp.Start.RunningTime = false;
          break;
      }
    }

  }

  /// <summary>
  /// 表示在控制台输出的开发者预备信息
  /// </summary>
  public class GetInformation {
    public static void GetHelp() {
      System.Console.Clear();



      System.Console.WriteLine(System.IO.File.ReadAllLines(@"C:/Users/Public/Documents/RMDUST/ShadowOfWorld/Core/Inf.txt"));
      System.Threading.Thread.Sleep(1000);
      System.Console.Read();
      
    }

  }
}

/// <summary>
/// 表示与本地用户相关的控制流,输出流,输入流
/// </summary>
namespace Group.File {

  public class Manager {

    public readonly static string[] Path = new string[] { @"C:/Users/Public/Documents/RMDUST/ShadowOfWorld/Save/" ,
                                                          @"C:/Users/Public/Documents/RMDUST/ShadowOfWorld/Core/" ,
                                                          @"C:/Users/Public/Documents/RMDUST/ShadowOfWorld/Save/UserNameList.txt" ,
    };
    //public static string UserFolder;


    

    static Manager() {
     
    }

    /// <summary>
    /// 检查所有原始文件是否存在
    /// </summary>
    public static void CoreInit() {
      System.IO.Directory.CreateDirectory(Path[0]);
      System.IO.Directory.CreateDirectory(Path[1]);
      if (!System.IO.File.Exists(Path[2])) {
        System.IO.File.Create(Path[2]).Close();
      }
    }
    /// <summary>
    /// 检查登入用户是否已装载应有文件
    /// </summary>
    public static void Init(string ID) {
      System.IO.Directory.CreateDirectory(Path[0] + ID);
    }
    public static void Init() {
      System.IO.Directory.CreateDirectory(Path[0] + Group.User.UserName);
    }

  }
  public class User : Manager {

    /// <summary>
    /// 索引本地用户文件并将结果
    /// </summary>
    public static System.Collections.ArrayList Find() {
      System.Collections.ArrayList UserNameList = new System.Collections.ArrayList();
      foreach (string UserName in System.IO.File.ReadAllLines(Path[2])) {
        UserNameList.Add(UserName);
      }
      return UserNameList;
    }
    /// <summary>
    /// 检查用户名在本地用户文件中是否存在
    /// </summary>
    /// <param name="ID"></param>
    /// <returns></returns>
    public static bool Find(string ID) {
      foreach (string UserName in System.IO.File.ReadAllLines(Path[2])) {
        if (ID == UserName) {
          return true;
        }
      }
      return false;
    }

    /// <summary>
    /// 向本地用户文件添加一行用户名
    /// </summary>
    public static void Add(string ID) {
      using (System.IO.StreamWriter Create = System.IO.File.AppendText(Path[2])) {
        Create.WriteLine(ID);
        Create.Close();

      }
    }

    /// <summary>
    /// 向本地用户文件删除一行用户名
    /// </summary>
    public static void Delete() {

    }
  }

}

/// <summary>
/// 表示与用户相关的现有信息
/// </summary>
namespace Group {
  /// <summary>
  /// 登入账户
  /// </summary>
  public static class SignInAndSignUp {
    
    public static void Register() {
      Group.User.SetUserList();
      Group.User.GetUserList();

      Login();
      if (Group.File.User.Find(Group.User.UserName)) {
        SignIn();
      } else {
        SignUp();
      }
    }
    public static void Register(string ID) {
      Group.User.UserName = ID;
      if(Group.File.User.Find(Group.User.UserName)) {
        SignIn();
      } else {
        SignUp();
      }
    }
    /// <summary>
    /// 提示用户注册一个用户名
    /// </summary>
    private static void SignUp() {
      ConsoleGraphic.Format.Ch.Line("注册模式\n");
      
      Group.File.User.Add(Group.User.UserName);
      Group.User.UserName = System.Console.ReadLine().ToString();
    }
    private static void SignIn() {
      //System.Console.WriteLine("用户存在");
    }
    /// <summary>
    /// 提示用户提供一个用户名
    /// </summary>
    private static void Login() {
      ConsoleGraphic.Format.Ch.SquareLine("登入模式");
      Group.User.UserName = System.Console.ReadLine().ToString();
    }
  }

  public static class User {
    private static string userName;
    public static string UserName {
      set {
        userName = value;
      }
      get {
        return userName;
      }

    }

    public static System.Collections.ArrayList UserNameList = new System.Collections.ArrayList();

    public static void SetUserList() {
      UserNameList = Group.File.User.Find();
    }
    public static void GetUserList() {
      ConsoleGraphic.Format.Ch.SquareLine("用户列表");
      ConsoleGraphic.Format.Ch.SquareLine(UserNameList);
    }


  }

}

namespace egg {
  public class Days {
    string Day , Month ;

    public Days() {
      //Day = System.DateTime.Now.Day.ToString();
      //Month = System.DateTime.Now.Month.ToString();

      Day = "1";
      Month = "1";

      switch(Month) {
        case "1":Jan();break;
        case "2":break;
      }
    }

    private void Jan() {
      switch(Day) {
        case "1":
          NewYear();
          break;
      }
    }

    
    private void NewYear() {
      ConsoleGraphic.Format.En.SquareLine("EGG TEST");


      System.Threading.Thread.Sleep(500);
    }
    private void LunarYear() {

    }
    private void ChinaYear() {

    }
    private void ChirstmasDays() {

    }

  }

}