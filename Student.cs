using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class Student
    {
        private int roll_no;
        
        private string name, branch, grade;
        private int maths, marathi, english;
        private double Percentage, total;



        //public Student()
        //{
        //    roll_no = 0;
        //    name = "";
        //    branch = "";
        //    grade = "";
        //}

        //public Student(int roll_no, string name, string branch, string grade)
        //{
        //    this.roll_no = roll_no;
        //    this.name = name;
        //    this.branch = branch;
        //    this.grade = grade;
        //}
        //public void AcceptStudentData(int roll_no, string name, string branch, int maths, int marathi, int english)
        //{
        //    this.roll_no = roll_no;
        //    this.name = name;
        //    this.branch = branch;
        //    this.maths = maths;
        //    this.marathi = marathi;
        //    this.english = english;

        //}
        public void DisplayData(int roll_no,string name)
        {
            roll_no = 1212;
            name = "Rohit Survase";
        }
        public void Calculate()
        {
            total = maths + marathi + english;
            Percentage = total / 300 * 100;
        }

        public void Grade()
        {
            if (Percentage > 70)
            {
                grade = "Grade A";
            }
            else if (Percentage >= 50 && Percentage <= 70)
            {
                grade = "Grade B";
            }
            else if (Percentage >= 40 && Percentage <= 50)
            {
                grade = "Grade c";
            }
            else
            {
                Console.WriteLine("you are fail pls try next time");
            }
        }

        public string PrintSData()
        {
            return $"Student:roll no is {roll_no} name is {name} branch is {branch} total marks is{total} Per is{Percentage} Grade is {grade}";
        }


    }

}
//wc to create student class student has id,name,3sub marks create first method to accept detail.create sec method cal to per,create third method assign grade,
//create class account account has acc no ,acc type ,bal,
//Create first method accept account detail,second method show acc detail,create third method withdraw money for bal,deposit money to acc