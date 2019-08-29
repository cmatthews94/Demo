using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAppMVC.Interfaces;
using DemoAppMVC.Models;
using DemoAppMVC.Objects;

namespace DemoAppMVC.ProgramLogic
{
    public class WebLogic : IWebLogic
    {
        public StudentModel GetClaire()
        {
            var ourStudent = new Student()
            {
                FirstName = "Claire",
                LastName = "Matthews",
                DOB = new DateTime(1994, 02, 19),
            };

            var ourStudentModel = new StudentModel()
            {
                FirstName = ourStudent.FirstName,
                LastName = ourStudent.LastName,
            };

            return ourStudentModel;
        }

        public StudentModel GetMaria()
        {
            var ourStudent = new Student()
            {
                FirstName = "Maria",
                LastName = "Matthews",
                DOB = new DateTime(1989, 03, 18),
            };

            var ourStudentModel = new StudentModel()
            {
                FirstName = ourStudent.FirstName,
                LastName = ourStudent.LastName,
            };

            return ourStudentModel;
        }
    }
}
