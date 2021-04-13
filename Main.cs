

/// <summary>
/// 包含 Main 的命名空间
/// </summary>
namespace ShadowOfWorld_Console_CSharp {
  /// <summary>
  /// 程序启动
  /// </summary>
  public class Start {

    // "active" Control "Part1" Running Function in Main
    // Default is true
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
    
      RunningTime = true;

      // Set Window Console Inf
      {
        System.Console.SetWindowSize(120 , 40);
        System.Console.SetBufferSize(121 , 40);
        System.Console.ForegroundColor = System.ConsoleColor.Black;
        System.Console.BackgroundColor = System.ConsoleColor.White;
        System.Console.OutputEncoding = System.Text.Encoding.Unicode;
        System.Console.CursorVisible = false;
        System.Console.Title = "RMDUST TEST";
        System.Console.Clear();
      }
      
      // Run 
      egg.Days time = new egg.Days();

      System.Console.Clear();
      // Dev Information
      ConsoleGraphic.DeveloperInf.Logo();
      System.Threading.Thread.Sleep(1000);
      ConsoleGraphic.Graphic.Load();

      System.Console.Clear();



      // Run !!!
      Part1();

      System.Console.ReadKey();
    }

    /// <summary>
    /// 启动
    /// </summary>
    private static void Part1() {
      // Initialization Local File and Folder
      Group.File.Manager.Init();

      string[] MenuValue = new string[] { "Game Start","Game Passage","Help","Back User","Game Exit" };

      // Open Main-Menu
      ConsoleGraphic.Menu Core = null;
      do {
        System.Console.Clear();

        Core = new ConsoleGraphic.Menu();
        
        Core.SetMenuList(MenuValue);
        Core.SetMenuListItems(4,0);

        // Get name of user
        Group.Login.Register();
        // Create file of private user
        Group.File.Manager.Init(Group.User.GetUserName());
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

namespace ConsoleGraphic {
  /// <summary>
  /// 表示程序启动时显示的开发者信息
  /// </summary>
  public class DeveloperInf {
    /// <summary>
    /// 开发者图标
    /// </summary>
    public static void Logo() {
      System.Console.Write(System.IO.File.ReadAllText("Resource/Logo.txt"));
    }
  }

  /// <summary>
  /// 表示控制台动画
  /// </summary>
  public class Graphic {
    /// <summary>
    /// 一段虚假的加载动画
    /// </summary>
    public static void Load() {
      for (int Count = 5;Count > 0;Count--) {
        System.Console.SetCursorPosition(60,20);
        System.Console.WriteLine("|");
        System.Threading.Thread.Sleep(100);

        System.Console.SetCursorPosition(60,20);
        System.Console.WriteLine("/");
        System.Threading.Thread.Sleep(100);

        System.Console.SetCursorPosition(60,20);
        System.Console.WriteLine("-");
        System.Threading.Thread.Sleep(200);

        System.Console.SetCursorPosition(60,20);
        System.Console.WriteLine(@"\");
        System.Threading.Thread.Sleep(100);
      }
    }

  }

  /// <summary>
  /// 表示图形菜单的输出,控制流
  /// </summary>
  public class Menu {
    public Menu() {
      
      Active = true;
    }

    // The MenuList are developers
    private string[] MenuList;
    private int MenuListItemsMax;
    private int MenuListItemsMin;
    private int MenuListNow;
    private bool Active;

    public void SetMenuList(string[] Message) {
      MenuList = Message;
    }
    public void SetMenuListItems(int Max , int Min) {
      MenuListItemsMax = Max;
      MenuListItemsMin = Min;
    }



    /// <summary>
    /// 显示图形菜单
    /// </summary>
    private void GetMenu() {
      foreach (string Message in MenuList) {
        System.Console.WriteLine(Message);
      }
    }
    /// <summary>
    /// 显示图形菜单的特定项
    /// </summary>
    /// <param name="Item"></param>
    private void GetMenu(int Item) {
      System.Console.WriteLine(MenuList[Item]);
    }
    /// <summary>
    /// 自动显示图形菜单的特定项，依据 MenuListNow 的值
    /// </summary>
    private void GetMenuAuto() {
      GetMenu(MenuListNow);
    }

    /// <summary>
    /// 更新控制开关 Active 状态
    /// </summary>
    private void ActiveUpdate() {
      Active = MenuListNow == MenuListItemsMax ? false : true;
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
          GetMenuControl();
          ActiveUpdate();
        }
        System.Console.Clear();
      }

    }

    /// <summary>
    /// 获取控制台键入值,作出反应
    /// </summary>
    /// <returns></returns>
    private bool GetMenuReadKey() {
      switch (System.Console.ReadKey().KeyChar.ToString()) {
        case "W":
        case "w":
          MenuListNow = MenuListNow > MenuListItemsMin ? MenuListNow - 1 : MenuListNow;
          break;
        case "S":
        case "s":
          MenuListNow = MenuListNow < MenuListItemsMax ? MenuListNow + 1 : MenuListNow;
          break;
        case " ":
          return true;
      }
      return false;
    }

    // 不要看 ， Do not Touch , Hanashinaii
    /// <summary>
    /// 依据来自 GetMenuCenter 的值作出反应
    /// </summary>
    private void GetMenuControl() {
      switch (MenuListNow) {
        case 0:
          Game.GameCenter.GameStart();
          break;
        case 1:
          
          ConsoleGraphic.Menu Cc = new Menu();
          Cc.MenuList = new string[] { "开发中" , "开发中." , "开发中..."};
          Cc.MenuListItemsMax = 2;
          Cc.GetMenuCenter();
          
          break;
        case 2:
          System.Console.Clear();
          GetInformation.GetHelp();
          System.Threading.Thread.Sleep(1000);
          System.Console.Read();
          break;        
        case 3:
          // 注销并返回登入状态
          MenuListNow = MenuListItemsMax;
          break;
        case 4:
          // 终止运行
          MenuListNow = MenuListItemsMax;
          ShadowOfWorld_Console_CSharp.Start.RunningTime = false;
          break;
      }
    }

  }

  /// <summary>
  /// 表示在控制台输出的开发者预备信息
  /// </summary>
  public class GetInformation {
    /// <summary>
    /// 获取自带来自开发者提供的帮助
    /// </summary>
    public static void GetHelp() {
      System.Console.WriteLine(System.IO.File.ReadAllText("Resource/HelpInf.txt"));
    }

  }
}

namespace Group.File {

  public class Manager {

    private static string[] FolderPath = System.IO.File.ReadAllLines("Resource/Path/FolderInf.txt");
    private static string[] FilePath = System.IO.File.ReadAllLines("Resource/Path/FileInf.txt");

    static Manager() {
     
    }

    /// <summary>
    /// 得到一串路径，来自 Resource/Path/FolderInf.txt
    /// </summary>
    /// <returns></returns>
    public static string[] GetFolderPath() {
      return FolderPath;
    }
    /// <summary>
    /// 得到一项路径，来自 Resource/Path/FolderInf.txt
    /// </summary>
    /// <param name="Line"></param>
    /// <returns></returns>
    public static string GetFolderPath(int Line) {
      return FolderPath[Line];
    }

    /// <summary>
    /// 得到一串路径，来自 Resource/Path/FileInf.txt
    /// </summary>
    /// <returns></returns>
    public static string[] GetFilePath() {
      return FilePath;
    }
    /// <summary>
    /// 得到一项路径，来自 Resource/Path/FileInf.txt
    /// </summary>
    /// <param name="Line"></param>
    /// <returns></returns>
    public static string GetFilePath(int Line) {
      return FilePath[Line];
    }

    /// <summary>
    /// 检查登入用户的文件
    /// </summary>
    public static void Init(string ID) {
      System.IO.Directory.CreateDirectory(GetFolderPath(0) + ID);

    }
    /// <summary>
    /// 检查原始文件存在
    /// </summary>
    public static void Init() {
      FindFolder();
      FindFile();
    }

    /// <summary>
    /// 创建原始文件夹，除非已经存在
    /// </summary>
    private static void FindFolder() {
      foreach (string Path in GetFolderPath()) {
        System.IO.Directory.CreateDirectory(Path);
      }
    }
    /// <summary>
    /// 创建原始文件，除非已经存在
    /// </summary>
    private static void FindFile() {
      foreach (string Path in GetFilePath()) {
        if (!System.IO.File.Exists(Path)) {
          System.IO.File.Create(Path).Close();
        }
      }
    }

  }
  public class User : Manager {

    /// <summary>
    /// 索引本地用户文件，返回结果
    /// </summary>
    public static System.Collections.ArrayList Find() {
      System.Collections.ArrayList UserNameList = new System.Collections.ArrayList();
      foreach (string UserName in System.IO.File.ReadAllLines(GetFilePath(0))) {
        UserNameList.Add(UserName);
      }
      return UserNameList;
    }
    /// <summary>
    /// 用户名在本地用户文件中是否存在
    /// </summary>
    /// <param name="ID"></param>
    /// <returns></returns>
    public static bool Find(string ID) {
      foreach (string UserName in System.IO.File.ReadAllLines(GetFilePath(0))) {
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
      using (System.IO.StreamWriter Create = System.IO.File.AppendText(GetFilePath(0))) {
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

namespace Group {
  /// <summary>
  /// 表示登录模块
  /// </summary>
  public static class Login {
    
    /// <summary>
    /// 注册与登入
    /// </summary>
    public static void Register() {
      Group.User.SetUserList();
      ConsoleGraphic.Format.Ch.SquareLine("用户列表");
      ConsoleGraphic.Format.Ch.SquareLine(Group.User.GetUserNameList());

      // Put on a User Name
      Group.User.SetUserName(System.Console.ReadLine());
      
      

      while (!Group.File.User.Find(Group.User.GetUserName())) {
        SignUp();

      }
      SignIn();
    }
    /// <summary>
    /// 注册与登入
    /// </summary>
    /// <param name="ID"></param>
    public static void Register(string ID) {
      Group.User.SetUserName(ID);
      if (!Group.File.User.Find(Group.User.GetUserName())) {
        SignUp();
      }
      SignIn();
    }

    private static void SignUp() {
      ConsoleGraphic.Format.Ch.SquareLine("注册模式");
      Group.User.SetUserName(System.Console.ReadLine());
      Group.File.User.Add(Group.User.GetUserName());
    }
    private static void SignIn() {
      ConsoleGraphic.Format.Ch.SquareLine("登入模式");
      //XIANSHI NAME
      Group.User.SetUserName(System.Console.ReadLine().ToString());
    }
  }

  public static class User {
    private static string UserName;
    private static System.Collections.ArrayList UserNameList = new System.Collections.ArrayList();

    public static string GetUserName() {
      return UserName;
    }
    public static void SetUserName(string Message) {
      UserName = Message;
    }

    /// <summary>
    /// 使用前必须调用 SetUserList()
    /// </summary>
    /// <returns></returns>
    public static System.Collections.ArrayList GetUserNameList() {
      return UserNameList;
    }
    public static void SetUserList() {
      UserNameList = Group.File.User.Find();
    }

  }

}

namespace egg {
  public class Days {
    string Day , Month ;

    public Days() {
      Day = System.DateTime.Now.Day.ToString();
      Month = System.DateTime.Now.Month.ToString();

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
      System.Console.WriteLine(System.IO.File.ReadAllText("Resource/Holiday/LunarNewYear.txt"));


      System.Threading.Thread.Sleep(5000);
    }
    private void LunarYear() {
      System.Console.WriteLine(System.IO.File.ReadAllText("Resource/Holiday/LunarNewYear.txt"));
    }
    private void ChinaYear() {

    }
    private void ChirstmasDays() {

    }

  }

}