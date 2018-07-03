using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

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
        //IsPromotable isPromotable = new IsPromotable(checkPromotionEligibility);

        //List<Employee> empList = new List<Employee>();

        //empList.Add(new Employee() { Id = 101, Name = "Mary", Salary = 5000, Experience = 5, });
        //empList.Add(new Employee() { Id = 101, Name = "Mike", Salary = 4000, Experience = 4, });
        //empList.Add(new Employee() { Id = 101, Name = "John", Salary = 6000, Experience = 6, });
        //empList.Add(new Employee() { Id = 101, Name = "Joe", Salary = 3000, Experience = 3, });

        //Employee.PromoteEmployee(empList, isPromotable);

        #endregion

        #region Part 39
        //SampleDelegate del1, del2, del3, del4;
        //del1 = new SampleDelegate(SampleMethod1);
        //del2 = new SampleDelegate(SampleMethod2);
        //del3 = new SampleDelegate(SampleMethod3);
        //del4 = del1 + del2 + del3;

        //del4();
        #endregion

        #region Part 40 Exception Handling
        //StreamReader streamReader = null;
        //try
        //{
        //    streamReader = new StreamReader(@"Data.txt");
        //    Console.WriteLine(streamReader.ReadToEnd());
        //    streamReader.Close();
        //}
        //catch(FileNotFoundException ex)
        //{
        //    Console.WriteLine("Please check if the file {0} exists", ex.FileName);
        //}
        //catch(Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    if (streamReader != null)
        //    {
        //        streamReader.Close();
        //    }
        //    Console.WriteLine("Finally Block");
        //}

        #endregion

        #region Part 41 Inner Exceptions
        //try
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter First Number");
        //        int FN = Convert.ToInt32(Console.ReadLine());

        //        Console.WriteLine("Enter Second Number");
        //        int SN = Convert.ToInt32(Console.ReadLine());

        //        int Result = FN / SN;

        //        Console.WriteLine("Result = {0}", Result);
        //    }
        //    catch (Exception ex)
        //    {
        //        string filePath = "Log1.txt";
        //        if (File.Exists(filePath) == true)
        //        {
        //            StreamWriter sw = new StreamWriter(filePath);
        //            sw.Write(ex.GetType().Name);
        //            sw.WriteLine();
        //            sw.Write(ex.Message);
        //            sw.Close();
        //            Console.WriteLine("Ther is a problem, Please try later");
        //        }
        //        else
        //        {
        //            throw new FileNotFoundException(filePath + " is not present", ex);
        //        }
        //    }
        //}
        //catch(Exception exception)
        //{
        //    Console.WriteLine("Current Exception = {0}", exception.GetType().Name);
        //    if (exception.InnerException != null)
        //    {
        //        Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);
        //    }
        //}

        #endregion

        #region Part 42 Custom Exceptions

        //throw new UserAlreadyLoggedInException("User is logged in - no duplicate sessions");

        #endregion

        #region Part 43 Exception Handling Abuse
        //try
        //{
        //    Console.WriteLine("Please Enter Numerator");
        //    int numerator = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Please Enter Denominator");
        //    int denominator = Convert.ToInt32(Console.ReadLine());

        //    int Result = numerator / denominator;

        //    Console.WriteLine("Result = {0}", Result);
        //}
        //catch(FormatException)
        //{
        //    Console.WriteLine("Please enter a number");
        //}
        //catch(OverflowException)
        //{
        //    Console.WriteLine("Only numbers between {0} and {1} are allowed", Int32.MinValue, Int32.MaxValue);
        //}
        //catch(DivideByZeroException)
        //{
        //    Console.WriteLine("Denominator cannot be zero");
        //}
        //catch(Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        #endregion

        #region Part 44 Exception Handling Abuse Solved

        //try
        //{
        //    Console.WriteLine("Please Enter Numerator");
        //    int numerator;
        //    bool isNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out numerator);

        //    if (isNumeratorConversionSuccessful == true)
        //    {
        //        int denominator;
        //        Console.WriteLine("Please Enter Denominator");
        //        bool isDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out denominator);

        //        if (isDenominatorConversionSuccessful == true && denominator != 0)
        //        {
        //            int Result = numerator / denominator;

        //            Console.WriteLine("Result = {0}", Result);
        //        }
        //        else
        //        {
        //            if(denominator == 0)
        //            {
        //                Console.WriteLine("Denominator cannot be zero");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Denominator should be a valid number {0} and {1}", Int32.MinValue, Int32.MaxValue);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Numerator should be a valid number {0} and {1}", Int32.MinValue, Int32.MaxValue);
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        #endregion

        #region Part 45, 46, 47 Enums

        //Customer[] customers = new Customer[3];

        //customers[0] = new Customer()
        //{
        //    Name = "Mark",
        //    Gender = Gender.Male,
        //};

        //customers[1] = new Customer()
        //{
        //    Name = "Mary",
        //    Gender = Gender.Female,
        //};

        //customers[2] = new Customer()
        //{
        //    Name = "Sam",
        //    Gender = Gender.Unknown,
        //};

        //foreach(Customer c in customers)
        //{
        //    Console.WriteLine("Name = {0} && Gender = {1}", c.Name, GetGender(c.Gender));
        //}

        //short[] Values = (short[])Enum.GetValues(typeof(Gender));

        //foreach(int value in Values)
        //{
        //    Console.WriteLine(value);
        //}

        //string[] Names = (string[])Enum.GetNames(typeof(Gender));

        //foreach(string name in Names)
        //{
        //    Console.WriteLine(name);
        //}

        #endregion
    }

    #region Part 45 46

    public static string GetGender(Gender gender)
    {
        switch(gender)
        {
            case Gender.Unknown:
                return "Unknown";
            case Gender.Male:
                return "Male";
            case Gender.Female:
                return "Female";
            default:
                return "Invalid data detected";
        }
    }

    #endregion

    #region Part 39 Multicast Delegates
    public static bool checkPromotionEligibility(Employee emp)
    {
        return emp.Experience >= 5 ? true : false;
    }

    public static void SampleMethod1()
    {
        Console.WriteLine("SampleMethod1 invoked");
    }

    public static void SampleMethod2()
    {
        Console.WriteLine("SampleMethod2 invoked");
    }

    public static void SampleMethod3()
    {
        Console.WriteLine("SampleMethod3 invoked");
    }

    #endregion

    #region Part 36

    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }

    #endregion
}

#region Part 45, 46, 47 Enums

public enum Gender
{
    Unknown = 1,
    Male = 2,
    Female = 3,
}

//0 - Unknown
//1 - Male
//2 - Female
public class Customer
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
}

#endregion

#region Part 42 Custom Exceptions
/*
[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() : base()
    {

    }
    public UserAlreadyLoggedInException(string message) : base(message)
    {

    }

    public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
    {

    }

    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info,context)
    {

    }


}
*/
#endregion

#region Part 3738

public delegate bool IsPromotable(Employee empl);

public delegate void SampleDelegate();


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
