using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Demo
{
    public class Student
    {
        //private string _name;

        //public void SetName(string name)       //underscore voo private
        //{
        //    if (!String.IsNullOrEmpty(name))
        //    {
        //        this._name = name;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Name is Empty");
        //    }
        //}
        //public string GetName(string name)
        //{
        //    if (!String.IsNullOrWhiteSpace(name))
        //    {
        //        this._name = name;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Name is Empty");
        //        return _name;
        //    }
        //    return _name;
        //}


        //public int MyProperty { get; set; }           // om snel te maken  prob tab tab
        //private int _age;

        //public int Age
        //{
        //    get 
        //    { 
        //        return _age; 
        //    }
        //    set 
        //    {
        //        if (value >= 18 && value < 30)
        //        {
        //        _age = value; 
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid range of age");
        //        }
        //    }
        //}

        private int _age;
        private string MyProperty { get; }

        private string _bankCard;

        public string BankCard
        {
            get 
            {
                string output = "*********" + _bankCard.Substring(_bankCard.Length - 4);
               
                return output; 
            }
            set 
            { 
                _bankCard = value; 
            }
        }


        //public int Age
        //{
        //    get 
        //    { 
        //        return _age; 
        //    }
        //    set 
        //    {
        //        if (value > 20)
        //        {
        //            _age = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid age");
        //        }
        //    }
        //}
    }
        class Program
        {
            static void Main(string[] args)
            {
            Student student = new Student();
            //student.SetName(" ");
            //Console.WriteLine(student.GetName(""));

            //Student student = new Student() ;
            //student.Age = 15;

            Console.WriteLine("Give your Banc Card in");
            student.BankCard = Console.ReadLine();
            Console.WriteLine($"Your Banc Card number {student.BankCard}");
            }
        }
}
