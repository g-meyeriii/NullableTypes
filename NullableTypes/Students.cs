using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes {
    class Students {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SAT { get; set; }
        public double GPA { get; set; }

        public int? MajorId { get; set; } //two ways to do this
        public Major? Major {get;set;}


        public Students(int Id, string name, int? sat, double gpa, int? MajorId ) {
            Name = name;
            SAT = sat;
            GPA = gpa;
            
        }

        public void print() {
            Console.WriteLine($"Id={Id},Name = {Name}, SAT ={SAT},GPA = {GPA}");
                } 
        }
    }

