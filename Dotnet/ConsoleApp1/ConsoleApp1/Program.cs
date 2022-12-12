using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {


        #region abstract example
        //abstract class shape
        //{
        //    public abstract void area();
        //}


        //class circle : shape
        //{
        //    int r = 10;
        //    int ar;
        //    public override void area()
        //    {
        //       ar= 22 * r * r / 7;
        //        Console.WriteLine("Circle Area " + ar);
        //    }
        //}

        //class square : shape
        //{
        //    int s = 10;
        //    int ar;
        //    public override void area()
        //    {
        //        ar = s * s;
        //        Console.WriteLine("square area "+ar);
        //    }
        //}

        //class triangle : shape
        //{
        //    int b = 10;
        //    int h = 10;
        //    int ar;

        //    public override void area()
        //    { ar = b * h / 2;
        //        Console.WriteLine("triangle area "+ ar);
        //    }
        //}

        #endregion

        #region class example
        //class student{
        //    int rollnumber;
        //    String name;
        //    int marks;

        //    public int percent()
        //    {
        //        int per=marks/100;

        //        return per;
        //    }

        //    public int showmarks()
        //    {
        //        return marks;
        //    }

        //}
        #endregion

        #region prime function
        //static bool isPrime(int n)
        //{

        //    if (n == 1 || n == 0) return false;


        //    for (int i = 2; i < n; i++)
        //    {
        //        if (n % i == 0) return false;
        //    }

        //    return true;
        //}

        #endregion

        #region overloading
        //class morph
        //{
        //    public void add(int a, int b)
        //    {
        //        Console.WriteLine("Sum is " + (a + b));
        //    }

        //    public void add(string a, string b)
        //    {
        //        Console.WriteLine("Sum is " + (a + b));
        //    }
        //}
        #endregion

        #region Defaut constructor

        //class add
        //{
        //    public
        //    int a, b;
        //    public add()
        //    {
        //        a = 75;
        //        b = 45;
        //        Console.WriteLine("Default Constructor");

        //    }
        //}

        #endregion

        #region class
        //class student
        //{
        //    int rollno;
        //    int cls;
        //    string name;
        //    int sub1;
        //    int sub2;
        //    int totalmarks;

        //    public student()
        //    {
        //        rollno = 1;
        //        cls = 1;
        //        name = "a";
        //        sub1 = 1;
        //        sub2 = 1;
        //    }

        //    public void getdetails()
        //    {
        //        Console.WriteLine("Enter Rollno");
        //        rollno = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Enter class");
        //        cls = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Enter Name");
        //        name = Convert.ToString(Console.ReadLine());
        //        Console.WriteLine("Enter Marks in subject 1");
        //        sub1 = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Enter Marks in subject 2");
        //        sub2 = Convert.ToInt32(Console.ReadLine());
        //    }

        //    public int total()
        //    {
        //        totalmarks = sub1 + sub2;
        //        return totalmarks;
        //    }
        //    public void show()
        //    {
        //        Console.WriteLine(" Rollno" + rollno);
        //        Console.WriteLine(" class" + cls );
        //        Console.WriteLine(" Name" + name);
        //        Console.WriteLine(" Marks in subject 1 " + sub1);
        //        Console.WriteLine(" Marks in subject 2 "+ sub2);
        //        Console.WriteLine(" Total marks" + totalmarks);


        //    }


        //}
        #endregion


        #region Interface eg1
        //public interface ILandAnimal
        //{
        //    public void GetDetails();
        //}

        //public interface IWaterAnimal
        //{
        //    public void GetDetails();
        //}


        //class Frog : ILandAnimal, IWaterAnimal
        //{
        //    public void GetDetails()
        //    {

        //        throw new NotImplementedException();
        //    }
        //}

        #endregion

        #region interface 2
        public interface Itrain
        {
            
            public void traindetails();
        }

        public interface Iaeroplane
        {
            public void planedetails();
        }

        class customer : Itrain, Iaeroplane
        {
        
            string name;
            string spoint;
            string epoint;
            DateTime date;
            int pnr;


           public void getcustomerdetails()
            {
                Console.WriteLine("Enter name");
                name = Convert.ToString( Console.ReadLine());

                Console.WriteLine("Enter boarding point");
                spoint = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter destination");
                epoint = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter date");
                date = DateTime.Parse(Console.ReadLine());
            }
            public void planedetails()
            {
                Random rnd = new Random();
                pnr = rnd.Next();

                Console.WriteLine("Customer Name " + name);
                Console.WriteLine("boarding pount " + spoint);
                Console.WriteLine("desitnation  " + epoint);
                Console.WriteLine("Jouney Date " + date);
                Console.WriteLine("PNR " + pnr);


            }

            public void traindetails()
            {

                Random rnd = new Random();
                pnr = rnd.Next();

                Console.WriteLine("Customer Name " + name);
                Console.WriteLine("boarding pount " + spoint);
                Console.WriteLine("desitnation  " + epoint);
                Console.WriteLine("Jouney Date " + date);
                Console.WriteLine("PNR " + pnr);

            }
        }

        #endregion

        #region garbage collection
        //public class garbage
        //{
        //    int a;
        //}

        #endregion

        #region user defined exception 2
        //public class BookingException : Exception
        //{
        //    public BookingException(string message) : base(message)
        //    {
        //    }
        //}


        //public class Bookticket
        //{
        //    int ticket;

          
            
        //public void increaseticket()
        //{

        //    for (int i = 0; i < 100; i++, ticket++)
        //    {
        //        int inp = Convert.ToInt32(Console.ReadLine());


        //        if (ticket > 10)
        //        {
        //            throw (new BookingException("Show is FULL"));
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Ticket {0}", ticket);
        //        }
        //    }

        //}
        //}

#endregion

        #region user defined exception 1

        public class TempratureException : Exception
        {
            public TempratureException(string message): base(message)
            {
            }
        }


        public class Temprature
        {
            int temp = 0;

            public void showtemp()
            {
                if (temp == 0)
                {
                    throw (new TempratureException("Zero temp found"));
                }
                else
                {
                    Console.WriteLine("temprature {0}", temp);
                }
            }
        }
        #endregion

        #region custom exception
        //class Student
        //{
        //   public int id { get; set; }
        //    public string name { get; set; }
        //}

        //class InvalidStudentNameException : Exception
        //{
        //    public InvalidStudentNameException()
        //    {
        //    }

        //    public InvalidStudentNameException(String name) : base (String.Format("Invalid Student Name: {0}", name)) { }
        //}


        //private static void ValidateStudent(Student std)
        //{
        //    Regex regex = new Regex("^[a-zA-Z]+$");
        //    if (!regex.IsMatch(std.name))
        //    {
        //        throw new InvalidStudentNameException(std.name);
        //    }

        //}

        #endregion


        #region Generic DataType
        //public class MyGenericArray<T>
        //{
        //    private T[] array;
        //    public MyGenericArray(int size)
        //    {
        //        array = new T[size + 1];
        //    }

        //    public T getItem(int index)
        //    {
        //        return array[index];
        //    }
        //    public void setItem(int index, T value)
        //    {
        //        array[index] = value;
        //    }
        //}

        #endregion

        #region exception task user
        //class User
        //{
        //    public string username { get; set; }
        //    public string address { get; set; }
        //    public string email { get; set; }
        //    public int age { get; set; }
        //}

        //class InvalidUserAgeException : Exception
        //{
        //    public InvalidUserAgeException()
        //    {}
        //    public InvalidUserAgeException(int age) : base(String.Format("Age greater than 50: {0}", age)) { }
        //}

        //class InvalidUserEmailException : Exception
        //{
        //    public InvalidUserEmailException()
        //    { }
        //    public InvalidUserEmailException(String email) : base(String.Format("Email invalid: {0}", email)) { }
        //}

        //class InvalidUserAddressException : Exception
        //{
        //    public InvalidUserAddressException()
        //    { }
        //    public InvalidUserAddressException(String address) : base(String.Format("Address greater than 100: {0}", address)) { }
        //}


        //private static void Validateage(User usr)
        //{

        //    if (usr.age>50)
        //    {
        //        throw new InvalidUserAgeException(usr.age);
        //    }

        //}

        //private static void Validateaddress(User usr)
        //{

        //    if (usr.address.Length > 100)
        //    {
        //        throw new InvalidUserAddressException(usr.address);
        //    }

        //}

        //private static void Validateemail(User usr)
        //{

        //    Regex regex = new Regex("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$");
        //    if (!regex.IsMatch(usr.email))
        //    {
        //        throw new InvalidUserEmailException(usr.email);
        //    }

        //}

        #endregion
        static void Main(string[] args) {
#region list task
            //List<int> intlist = new List<int>(5);
            //int inp;
            //for(int i =0;i<5;i++)
            //{
            //    inp = Convert.ToInt32( Console.ReadLine());
            //    intlist.Add(inp);
            //}

            //foreach (int i in intlist)
            //{
            //    Console.WriteLine("integer list" + i);
            //}

            //intlist.RemoveAt(4);

            //Console.WriteLine("----------------------------");

            //foreach (int i in intlist)
            //{
            //    Console.WriteLine("New integer list" + i);
            //}

            //intlist.Reverse(0, 2);

            //Console.WriteLine("----------------------------");

            //foreach (int i in intlist)
            //{
            //    Console.WriteLine("Final integer list" + i);
            //}



            //List<string> stringlist = new List<string>(5);

            //string str;
            //for (int i = 0; i < 5; i++)
            //{
            //    str = Console.ReadLine();
            //    stringlist.Add(str);
            //}
            //Console.WriteLine("----------------------------");
            //foreach (string i in stringlist)
            //{
            //    Console.WriteLine("String list" + i);
            //}

            //stringlist.RemoveAt(4);
            //Console.WriteLine("----------------------------");

            //foreach (string i in stringlist)
            //{
            //    Console.WriteLine("New string list" + i);
            //}
            #endregion

            #region Stack list Arraylist dictonary generic list
            //ArrayList al = new ArrayList();
            //string str = "Protiviti Training Demo";
            //int x = 7;
            //DateTime d = DateTime.Parse("19-Aug-2022");
            //al.Add(str);
            //al.Add(x);
            //al.Add(d);

            //foreach(object o in al)
            //{
            //    Console.WriteLine("Array List " + o);
            //}


            //// Hastable

            //Hashtable ht = new Hashtable();
            //ht.Add("ora", "oracle");
            //ht.Add("asp", "asp.net");
            //ht.Add("js", "JavaScript");
            //ht.Add("vb", "vb.net");

            //foreach(DictionaryEntry e in ht)
            //{
            //    Console.WriteLine("Hashtable objects " + e.Value);
            //}
            //Console.WriteLine("does Contain key? " + ht.ContainsKey("ora"));


            //// Sortedlist

            //SortedList sl = new SortedList();
            //sl.Add("ora", "oracle");
            //sl.Add("asp", "asp.net");
            //sl.Add("js", "JavaScript");
            //sl.Add("vb", "vb.net");


            //foreach (DictionaryEntry e in sl)
            //{
            //    Console.WriteLine("Sorted list objects " + e.Value);
            //}

            //// Stack

            //Stack st = new Stack();
            //st.Push("aa");
            //st.Push("bb");
            //st.Push("cc");
            //st.Push("dd");

            //foreach (object i in st)
            //{
            //    Console.WriteLine("Items in List" + i);
            //}


            ////Generic List

            //List<int> lst = new List<int>();
            //lst.Add(100);
            //lst.Add(200);
            //lst.Add(300);
            //lst.Add(400);

            //foreach(int i in lst)
            //{
            //    Console.WriteLine("Items in List" + i);
            //}

            // Dictonary

            //Dictionary<int, string> dct = new Dictionary<int, string>();
            //dct.Add(1, "cs.net");
            //dct.Add(2, "cs.net");
            //dct.Add(3, "cs.net");
            //dct.Add(4, "cs.net");

            //foreach(KeyValuePair<int,string> kvp in dct)
            //{
            //    Console.WriteLine("dictonary objects" + kvp.Key + " " + kvp.Value);
            //}

            #endregion

            #region cutom exception task user
            //User newuser = null;

            //try
            //{
            //    newuser = new User();
            //    newuser.username = "Raman";
            //    newuser.address = "ggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggg";
            //    Validateaddress(newuser);

            //    newuser.age = 89;
            //    Validateage(newuser);

            //    newuser.email = "hsasdnssbsm";
            //    Validateemail(newuser);


            //}
            //catch (InvalidUserAddressException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //catch (InvalidUserAgeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (InvalidUserEmailException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadKey();

            #endregion

            #region Generic DataType

            //MyGenericArray<int> intarray = new MyGenericArray<int>(5);

            ////setting values
            //for(int c=0; c < 5; c++)
            //{
            //    intarray.setItem(c, c*5);
            //}
            //// retriving values
            //for (int c = 0; c < 5; c++)
            //{
            //    Console.WriteLine( intarray.getItem(c));
            //}

            //Console.WriteLine("-------------------");


            //// New Character array
            //MyGenericArray<char> chararray = new MyGenericArray<char>(5);

            ////setting values
            //for (int c = 0; c < 5; c++)
            //{
            //    chararray.setItem(c, (char)(c+97));
            //}
            //// retriving values
            //for (int c = 0; c < 5; c++)
            //{
            //    Console.WriteLine(chararray.getItem(c));
            //}

            //Console.WriteLine("-------------------");

            #endregion

            #region custom exeption
            //    Student newstudent = null;

            //    try
            //    {
            //        newstudent = new Student();
            //        newstudent.name = "James007";

            //        ValidateStudent(newstudent);
            //    }
            //    catch(InvalidStudentNameException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    Console.ReadKey();


            #endregion

            #region userdefined exception 2
            //Bookticket obj = new Bookticket();

            //try
            //{
            //    obj.increaseticket();
            //}
            //catch (BookingException e)
            //{
            //    Console.WriteLine("BooK ticket exception{0} ", e.Message);
            //}
            //Console.ReadKey();
            #endregion

            #region User defined exeception 1

            //Temprature tem = new Temprature();

            //try
            //{
            //    tem.showtemp();
            //}
            //catch (TempratureException e)
            //{
            //    Console.WriteLine("TempratureException{0} ", e.Message);
            //}
            //Console.ReadKey();

            #endregion


            #region out of range exception

            //int[] a = new int[5];

            //try
            //{
            //    a[6] = 200;
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine("Out of range execption", e);
            //}
            //finally
            //{
            //    Console.WriteLine("Completed the out of range ");
            //}
            #endregion

            #region Format exception
            //try
            //{
            //    int result = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(" Format exception caught", e);
            //}
            //finally
            //{
            //    Console.WriteLine("Ran succesfully");
            //}

            #endregion

            #region divide by 0 exception
            //int num1 = 10, num2 = 0;
            //try
            //{
            //    int result = num1 / num2;
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Exception caught", e);
            //}
            //finally
            //{
            //    Console.WriteLine("0");
            //}

            #endregion

            #region garbage collection

            //garbage obj = new garbage();

            //Console.WriteLine("Grabage object is now on " + GC.GetGeneration(obj) + " Generation");

            //Console.WriteLine("Grabage collection occured in 0th geneetaion " + GC.CollectionCount(0));
            //Console.WriteLine("Grabage collection occured in 1st geneetaion " + GC.CollectionCount(1));
            //Console.WriteLine("Grabage collection occured in 2nd geneetaion " + GC.CollectionCount(2));
            //GC.Collect(1);
            //Console.WriteLine("Grabage collection occured in 1st geneetaion " + GC.CollectionCount(1));
            #endregion


            #region Interface

            //customer obj = new customer();

            //obj.getcustomerdetails();

            //Console.WriteLine("-----------------------");
            //int ch;


            //Console.WriteLine("1 for Aeroplane \n  2 for train");
            //ch = Convert.ToInt32( Console.ReadLine());

            //if (ch == 1)
            //{
            //    obj.planedetails();
            //}else if (ch == 2)
            //{
            //    obj.traindetails();
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Input");
            //}


            #endregion

            #region student class
            //student a = new student();
            //a.getdetails();
            //a.total();
            //student b = new student();
            //b.getdetails();
            //b.total();
            //student c = new student();
            //c.getdetails();
            //c.total();


            //a.show();
            //b.show();
            //c.show();

            //Console.WriteLine(Math.Max(a.total(), Math.Max(b.total(), c.total())));

            #endregion

            #region deafault constructor
            //add sum = new add();
            //Console.WriteLine(sum.a);
            //Console.WriteLine(sum.b);

            #endregion
            #region abstract class implement
            //circle cirobj = new circle();

            //cirobj.area();

            //square sqrobj = new square();
            //sqrobj.area();

            //triangle triobj = new triangle();
            //triobj.area();

            #endregion

            #region overload implement

            //morph intsum = new morph();
            //intsum.add(4, 5);
            //intsum.add("rrr", "kgf");

            #endregion


            #region if else
            // int age = Console.Read();


            //if (age>30 && age<50)
            //{
            //    Console.WriteLine("A");
            //}
            //else if(age>50 && age<80)
            //{
            //    Console.WriteLine("B");
            //}
            //else if(age>80)
            //{
            //    Console.WriteLine("C");
            //}
            #endregion


            #region switch case
            //switch (age)
            //{
            //    case int n when (n >= 100):
            //        Console.WriteLine("A");
            //        break;
            //}
            #endregion

            #region prime
            //for (int i = 1; i <= 100; i++)
            //{

            //    if (isPrime(i))
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            #endregion

            #region for each loop
            //List<int> a = new List<int> { 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            //a.Sort();

            //foreach (var g in a)
            //{
            //    Console.WriteLine(g);


            //}

            #endregion


            #region largest in array
            //int[] array= new int[5];

            //for(int i =0; i < 5; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int large = array[0];


            //for(int i =1; i < 5; i++)
            //{
            //    if (large < array[i])
            //    {
            //        large = array[i];
            //    }
            //}
            //int i = 0;
            //do
            //{
            //    if (large < array[i])
            //    {
            //        large = array[i];
            //    }
            //}while(i< 5) ;
            //Console.WriteLine("Largest number " + large);

            #endregion


            #region string
            //        Console.WriteLine("enter 6 String  value:");
            //        List<String> str = new List<String>();
            //        for (int i = 0; i < 6; i++)
            //        {
            //            str.Add(Console.ReadLine());
            //        }

            //        str.RemoveAt(3);
            //        Console.WriteLine("remove 4th position:");

            //        Console.WriteLine("array length: " + str.Count);
            //        for (int i = 0; i < str.Count; i++) 
            //            Console.WriteLine(str[i]);
            //        str.Insert(3, "Manoj");
            //        str.Insert(4, "Kumar");
            //        Console.WriteLine("insert 2 elements after that: ");
            //        Console.WriteLine("Array length: " + str.Count);
            //        for (int i = 0; i < str.Count; i++) 
            //            Console.WriteLine(str[i]);
            //        str.Add("Vinod");
            //        str.Add("Warier");




            //        Console.WriteLine("adding 3 elements at the end: ");
            //        Console.WriteLine("Array length: " + str.Count);
            //        for (int i = 0; i < str.Count; i++) 
            //            Console.WriteLine(str[i]);


            //        Console.WriteLine("Last two elements are:");
            //        Console.WriteLine(str[str.Count - 2]);
            //        Console.WriteLine(str[str.Count - 1]);
            #endregion

        }
    }
}
