using System.Data;

namespace _20260317
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test joe,tom,marry;

            joe=new Test();
            marry =new Test();

            joe.Mid = 80;
            joe.Final = 90;

            marry.Mid = 60;
            marry.Final = 66;
            
            Console.WriteLine("joe"+joe.GetAvg());

            tom = joe;

            Console.WriteLine("tom"+tom.GetAvg());

            joe.SetGrade(99, 100);

            Console.WriteLine("tom"+tom.GetAvg());
        }
    }
}
