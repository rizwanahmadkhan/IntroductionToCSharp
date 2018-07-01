using System;
using System.Collections.Generic;

//interface ICustomer1
//{
//    void Print();
//}

//interface ICustomer2
//{
//    void Print();
//}

//class Customer : ICustomer1, ICustomer2
//{
//    void ICustomer1.Print()
//    {
//        Console.WriteLine("Interface1 Method");
//    }

//    void ICustomer2.Print()
//    {
//        Console.WriteLine("Interface2 Method");
//    }
//    public void Print2()
//    {
//        Console.WriteLine("Print2 Method");
//    }

//    public void Print1()
//    {
//        Console.WriteLine("Print1 Method");
//    }
//}

#region Part 36

public delegate void HelloFunctionDelegate(string Message);

#endregion
class Program
{
    static void Main(string[] args)
    {
        //Customer c = new Customer();

        //((ICustomer1)c).Print();
        //((ICustomer2)c).Print();

        #region Part 36

        //HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        //del("Hello from delegate");
        #endregion

        #region Part 3738
        IsPromotable isPromotable = new IsPromotable(checkPromotionEligibility);

        List<Employee> empList = new List<Employee>();

        empList.Add(new Employee() { Id = 101, Name = "Mary", Salary = 5000, Experience = 5, });
        empList.Add(new Employee() { Id = 101, Name = "Mike", Salary = 4000, Experience = 4, });
        empList.Add(new Employee() { Id = 101, Name = "John", Salary = 6000, Experience = 6, });
        empList.Add(new Employee() { Id = 101, Name = "Joe", Salary = 3000, Experience = 3, });

        Employee.PromoteEmployee(empList, isPromotable);

        #endregion

    }

    public static bool checkPromotionEligibility(Employee emp)
    {
        return emp.Experience >= 5 ? true : false;
    }


    #region Part 36

    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }

    #endregion
}

#region Part 3738

public delegate bool IsPromotable(Employee empl);

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach(Employee e in employeeList)
        {
            if(IsEligibleToPromote(e) == true)
            {
                Console.WriteLine(e.Name + " promoted");
            }
        }
    }
}

#endregion

//class A
//{
//    public int Sum(int num1, int num2)
//    {
//        return num1 + num2;
//    }

//    public float Sum(float num1, float num2)
//    {
//        return num1 + num2;
//    }
//}
