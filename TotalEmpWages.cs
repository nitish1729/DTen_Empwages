
  

class company 
{
    public const int FullTimeHrs = 8;
    public const int PartTimeHrs = 4;
    public const int NoworkHrs = 0;
    public int wagePerHrs;
    public int workingdays;
    public int workinHrsPerMonth;

    static void company1()
    {
        Console.WriteLine("Enter wagePerHrs");
        int wagePerHrs = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Workingdays");
        int workingdays = int.Parse(Console.ReadLine());
        Console.WriteLine("workinHrsPerMonth");
        int workinHrsPerMonth = int.Parse(Console.ReadLine());
        int empwages = FullTimeHrs * wagePerHrs * workingdays * workinHrsPerMonth;
        Console.WriteLine("Emp Total Monthly wages:-" + empwages);
    }
        public static void Main(string[] args)
        {
          company com1 = new company();
          company.company1();

        }
}