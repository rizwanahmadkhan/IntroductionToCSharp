﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Runtime.InteropServices;
using System.Linq;


namespace IToCSharp
{
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

            #region Part 49

            //Customer C1 = new Customer();
            ////C1._id; can't access this because _id is private
            ////Console.WriteLine(C1.ID);

            //CorporateCustomer CC = new CorporateCustomer();
            //CC.printID();

            #endregion

            #region Part 52

            //Calculator.Add(10, 20);
            //Calculator.Add(10, 20, 39);

            #endregion

            #region Part 55 Late Binding

            //Customer C1 = new Customer();
            //string fullName = C1.GetFullName("Rizwan", "Khan");
            //Console.WriteLine("Full Name = {0}", fullName);

            //Assembly executingAssembly = Assembly.GetExecutingAssembly();

            //Type customerType = executingAssembly.GetType("IToCSharp.Customer");

            //object customerInstance = Activator.CreateInstance(customerType);

            //MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            //string[] parameters = new string[2];
            //parameters[0] = "Rizwan";
            //parameters[1] = "Khan";

            //string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            //Console.WriteLine("Full Name = {0}", fullName);

            #endregion

            #region Part 56 Generics

            //bool Equal = Calculator<string>.AreEqual("AB", "AB");

            //if(Equal == true)
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}

            #endregion

            #region Part 58 Overridding Equals() Method

            //Customer C1 = new Customer();
            //C1.FirstName = "Rizwan";
            //C1.LastName = "Khan";

            //Customer C2 = new Customer();
            //C2.FirstName = "Rizwan";
            //C2.LastName = "Khan";

            //Console.WriteLine(C1.Equals(C2));

            #endregion

            #region Part 60 StringBuilder

            //StringBuilder userString = new StringBuilder("C#");
            //userString.Append(" Video");
            //userString.Append(" Tutorial");
            //userString.Append(" for");
            //userString.Append(" Beginners");

            //Console.WriteLine(userString.ToString());

            #endregion

            #region Part 67 68 70

            //AddNumbers(10, 20, 30, 40, 50);

            //AddNumbers(20, 30);

            //AddNumbers(20, 30, new int[] { 40, 50 });

            #endregion

            #region Part 72 73 Dictionaries

            //Customer customer1 = new Customer()
            //{
            //    ID = 101,
            //    Name = "Mark",
            //    Salary = 5000,
            //};

            //Customer customer2 = new Customer()
            //{
            //    ID = 110,
            //    Name = "Pam",
            //    Salary = 6500,
            //};

            //Customer customer3 = new Customer()
            //{
            //    ID = 119,
            //    Name = "John",
            //    Salary = 3500,
            //};

            //Dictionary<int, Customer> customersDictionary = new Dictionary<int, Customer>();

            //customersDictionary.Add(customer1.ID, customer1);
            //customersDictionary.Add(customer2.ID, customer2);
            //customersDictionary.Add(customer3.ID, customer3);

            //Customer cust = customersDictionary[119];

            //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);

            //foreach(KeyValuePair<int, Customer> customerKeyValuePair in customersDictionary)
            //{
            //    Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
            //    Customer cust = customerKeyValuePair.Value;
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //    Console.WriteLine("---------------------------------");
            //}

            //foreach (Customer cust in customersDictionary.Values)
            //{
            //    //Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
            //    //Customer cust = customerKeyValuePair.Value;
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //    Console.WriteLine("---------------------------------");
            //}

            //Customer cust;
            //if(customersDictionary.TryGetValue(111, out cust) == true)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //}
            //else
            //{
            //    Console.WriteLine("The key is not found");
            //}

            //Console.WriteLine("Total Items = {0}", customersDictionary.Count(kvp => kvp.Value.Salary > 4000));

            //Customer[] customers = new Customer[3];
            //customers[0] = customer1;
            //customers[1] = customer2;
            //customers[2] = customer3;

            //Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.ID, cust => cust);

            //foreach(KeyValuePair<int, Customer> kvp in dict)
            //{
            //    Console.WriteLine("Key = {0}", kvp.Key);
            //    Customer cust = kvp.Value;
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //}

            //List<Customer> customers = new List<Customer>();
            //customers.Add(customer1);
            //customers.Add(customer2);
            //customers.Add(customer3);

            //Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.ID, cust => cust);

            //foreach (KeyValuePair<int, Customer> kvp in dict)
            //{
            //    Console.WriteLine("Key = {0}", kvp.Key);
            //    Customer cust = kvp.Value;
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //}

            #endregion

            #region Part 74 77 List Collection

            //Customer customer1 = new Customer()
            //{
            //    ID = 101,
            //    Name = "Mark",
            //    Salary = 5000,
            //};

            //Customer customer2 = new Customer()
            //{
            //    ID = 110,
            //    Name = "Pam",
            //    Salary = 6500,
            //};

            //Customer customer3 = new Customer()
            //{
            //    ID = 119,
            //    Name = "John",
            //    Salary = 3500,
            //};

            //List<Customer> customers = new List<Customer>(2);
            //customers.Add(customer1);
            //customers.Add(customer2);
            //customers.Add(customer3);
            //customers.Insert(0, customer3);

            //Console.WriteLine(customers.IndexOf(customer3, 0, 4));

            //List<int> numbers = new List<int>() { 1, 8, 7, 5, 2 ,3, 4, 9, 6 };

            //Console.WriteLine("Number before sorting");

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //numbers.Sort();

            //Console.WriteLine("Number after sorting");

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //numbers.Reverse();

            //Console.WriteLine("Number in descending order");

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };
            //Console.WriteLine("Alphabets before sorting");
            //foreach (string alphabet in alphabets)
            //{
            //    Console.WriteLine(alphabet);
            //}

            //alphabets.Sort();
            //Console.WriteLine("Alphabets after sorting");
            //foreach (string alphabet in alphabets)
            //{
            //    Console.WriteLine(alphabet);
            //}

            //alphabets.Reverse();
            //Console.WriteLine("Alphabets in descending order");
            //foreach (string alphabet in alphabets)
            //{
            //    Console.WriteLine(alphabet);
            //}

            //customers.Sort();


            #endregion

            #region Part 78 Sorting a List

            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000,
            };

            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 7000,
            };

            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 5500,
            };

            List<Customer> customers = new List<Customer>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            customers.Sort();

            #endregion

        }

        #region Part 67 68

        //public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
        //{
        //    int result = firstNumber + secondNumber;

        //    if (restOfNumbers != null)
        //    {
        //        foreach (int i in restOfNumbers)
        //        {
        //            result += i;
        //        }
        //    }

        //    Console.WriteLine("Sum = {0}", result); 
        //}
        //public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] restOfNumbers)
        //{
        //    int result = firstNumber + secondNumber;

        //    if(restOfNumbers != null)
        //    {
        //        foreach(int i in restOfNumbers)
        //        {
        //            result += i;
        //        }
        //    }

        //    Console.WriteLine("Sum = {0}", result);
        //}

        //public static void AddNumbers(int firstNumber, int secondNumber)
        //{
        //    int result = firstNumber + secondNumber;

        //    Console.WriteLine("Sum = {0}", result);
        //}

        #endregion

        #region Part 45 46

        //public static string GetGender(Gender gender)
        //{
        //    switch(gender)
        //    {
        //        case Gender.Unknown:
        //            return "Unknown";
        //        case Gender.Male:
        //            return "Male";
        //        case Gender.Female:
        //            return "Female";
        //        default:
        //            return "Invalid data detected";
        //    }
        //}

        #endregion

        #region Part 39 Multicast Delegates
        //public static bool checkPromotionEligibility(Employee emp)
        //{
        //    return emp.Experience >= 5 ? true : false;
        //}

        //public static void SampleMethod1()
        //{
        //    Console.WriteLine("SampleMethod1 invoked");
        //}

        //public static void SampleMethod2()
        //{
        //    Console.WriteLine("SampleMethod2 invoked");
        //}

        //public static void SampleMethod3()
        //{
        //    Console.WriteLine("SampleMethod3 invoked");
        //}

        #endregion

        #region Part 36

        //public static void Hello(string strMessage)
        //{
        //    Console.WriteLine(strMessage);
        //}

        #endregion
    }

    #region Part 72 73 Dictonaries 74 List 78 Sort Complex Types

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }

    #endregion

    #region Part 58 Overriding Equals() Mehtod

    //public class Customer
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //    public override bool Equals(object obj)
    //    {
    //        if(obj == null)
    //        {
    //            return false;
    //        }

    //        if((obj is Customer) == false)
    //        {
    //            return false;
    //        }

    //        return FirstName == ((Customer)obj).FirstName && LastName == ((Customer)obj).LastName;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return FirstName.GetHashCode() ^ LastName.GetHashCode();
    //    }
    //}

    #endregion

    #region Part 56 Generics

    //public class Calculator<T>
    //{
    //    public static bool AreEqual(T Value1, T Value2)
    //    {
    //        return Value1.Equals(Value2);
    //    }
    //}

    #endregion

    #region Part 55 Late Binding

    //public class Customer
    //{
    //    public string GetFullName(string FirstName, string LastName)
    //    {
    //        return FirstName + " " + LastName;
    //    }
    //}

    #endregion

    #region Part 52 Attributes

    //public class Calculator
    //{
    //    [Obsolete("Use Add(List<int> Numbers) Method")]
    //    public static int Add(int FirstNumber, int SecondNumber)
    //    {
    //        return FirstNumber + SecondNumber;
    //    }

    //    public static int Add(List<int> Numbers)
    //    {
    //        int sum = 0;
    //        foreach (int num in Numbers)
    //        {
    //            sum += num;
    //        }
    //        return sum;
    //    }
    //}

    #endregion

    #region Part 49 Access Modifiers

    //public class Customer
    //{
    //    //private int _id;

    //    //public int ID
    //    //{
    //    //    get
    //    //    {
    //    //        return _id;
    //    //    }
    //    //    set
    //    //    {
    //    //        _id = value;
    //    //    }
    //    //}

    //    protected int ID;
    //}

    //public class CorporateCustomer : Customer
    //{
    //    public void printID()
    //    {
    //        CorporateCustomer CC = new CorporateCustomer();
    //        CC.ID = 101;
    //        Console.WriteLine(CC.ID);
    //    }
    //}

    #endregion

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
    //public class Customer
    //{
    //    public string Name { get; set; }
    //    public Gender Gender { get; set; }
    //}

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
            foreach (Employee e in employeeList)
            {
                if (IsEligibleToPromote(e) == true)
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
}
