class Employee_Full_Time_Wage
{
    static void Main(string[]args)
    {
        int IS_FULL_TIME = 1;
        int EMP_RATE_PER_HOUR = 20;
        int empHur = 0;
        int empWage = 0;
        Random random = new Random();
        int empCheck = random.Next(0, 2);
        if (empCheck == IS_FULL_TIME)
        {
            empHur = 6;
        }
        else
        {
            empHur = 0;
        }
        empWage = empHur * EMP_RATE_PER_HOUR;
        Console.Write("Emp Wage:" + empWage);
    }
}