using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes {
    public class Major {
        public int Id { get; set; }
        public string Description { get; set; }
        public int MinSAT { get; set; }

        //Constructor
        public Major(int id, string description, int minsat) {
            Description = description;
            Id = id;
            MinSAT = minsat;

        }

        //Method
        public void Print() {
           Console.WriteLine($" Id={Id},Desc = {Description}, Min= {MinSAT}");




        }
    }
}

