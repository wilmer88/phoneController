using System.Runtime.InteropServices;



//parameterless Main() methods



partial class Program
{


  static void Main(string[] args)
    {
        int months = 12, bounus = 5000;
        double ratePerHour = 12.34;
        int numberOfHoursWorked = 10;

        double currentMonthWage = ratePerHour * numberOfHoursWorked + bounus;

        Console.WriteLine(currentMonthWage);

        ratePerHour += 2;
        Console.WriteLine(ratePerHour);
     

        int hwnd = 0;
        IntPtr hwndChild = IntPtr.Zero;

        //Get a handle for the Calculator Application main window
        hwnd = (int)FindWindow(null, "Calculator");
        if (hwnd == 0)
        {


            System.Diagnostics.Process.Start("Calc");

        }

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        static extern IntPtr FindWindow(string? lp1, string lp2);




    }
}