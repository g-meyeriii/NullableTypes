using System;

namespace NullableTypes {
    class Program {
        static void Main(string[] args) {

           // var math = new Major { Id = 1 Description = "Math", MinSAT = 900 };

            var students = new Students[] {
                new Students(1,"Billy",1000,3.0,null),
                new Students(2, "Jill", null, 2.8,200 ),
                new Students(3, "Jane", 1200, 4.0,1300 ),
                new Students(4, "Fred", null, 1.0, 500)
                };

             var majors = new Major[] { //Putting  values into a array instead of hard coding 
                
             new Major(100,"Accounting", 1000),
             new Major(200,"Business", 1000 ),
             new Major(300,"Enginering", 1200 ),
             new Major(400, "Math",1300 ),
             new Major(500,"Education",1100)

            };

            foreach (var Students in students){

               // students.print();
            }
        }
    }
}
