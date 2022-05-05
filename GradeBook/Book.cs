﻿using System;
using System.Collections.Generic;
namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        public string Name;
        public Book (string name)
        {
            grades = new List<double> ();
            this.Name = name;//this.name is setting field name to parameter name
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics ();
            result.Average = 0.0;

            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach (var grade in grades)
            {
                result.High = Math.Max(result.High, grade);
                result.Low = Math.Min(result.Low, grade);
                result.Average += grade;
            }
            result.Average /= grades.Count;
            return result;
        }

        public void AddGrade(double grade)
        {           
            grades.Add(grade);
        }

    }
}