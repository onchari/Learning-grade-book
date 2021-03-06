﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class GradeBook
    {
        //members of this class goes here.
        //members to hold state
        //members to hold behavious. members who do work Verbs
        private List<float> grades;
        private string _name;
        public event NameChangedDelegate NameChanged;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Null wah.");
                }
                
                    if (_name != value && NameChanged != null)
                {
                    NameChangedEventsArgs args = new NameChangedEventsArgs();
                    args.ExistingName = _name;
                    args.NewName = value;
                   
                    NameChanged(this._name, args);
                }
                _name = value;

            }
        }

        public GradeBook()
        {
            //initialization of objectes.  
            grades = new List<float>();
            _name = "empty";
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics statistics = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                //if(grade > statistics.highestGrade)
                //{
                //    statistics.highestGrade = grade;
                //}

                statistics.highestGrade = Math.Max(grade, statistics.highestGrade);
                statistics.lowestGrade = Math.Min(grade, statistics.lowestGrade);

                sum += grade;
            }
            statistics.averageGrade = sum / grades.Count;

            return statistics;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);

        }



        public void WriteGrades(TextWriter destination)
        {
            for (int i = grades.Count; i > 0; i--)
            {
                destination.WriteLine(grades[i - 1]);
            }
        }
    }
}
