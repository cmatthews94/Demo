using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAppMVC.Models;

namespace DemoAppMVC.Interfaces
{
    public interface IWebLogic
    {
        StudentModel GetClaire();

        StudentModel GetMaria();
    }
}
