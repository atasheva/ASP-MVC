using MVC_Lab2_Test.Models;
using MVC_Lab2_Test.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Lab2_Test.Controllers
{
    public class TestController : Controller
    {
        //public ActionResult GetView()
        //{
        //    Employee emp = new Employee();
        //    emp.FirstName = "Sukesh";
        //    emp.LastName = "Marla";
        //    emp.Salary = 10000;

        //    //ViewData["Employee"] = emp;
        //    //return View("MyView");

        //    //ViewBag.Employee = emp;
        //    //return View("MyView", emp);


        //    EmployeeViewModel vmEmp = new EmployeeViewModel();
        //    vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
        //    vmEmp.Salary = emp.Salary.ToString("C");
        //    if (emp.Salary > 15000)
        //    {
        //        vmEmp.SalaryColor = "yellow";
        //    }
        //    else
        //    {
        //        vmEmp.SalaryColor = "green";
        //    }

        //    vmEmp.UserName = "Admin";

        //    return View("MyView", vmEmp);


        //}
        public ActionResult GetView()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployees();

            List <EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (Employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 15000)
                {
                    empViewModel.SalaryColor = "yellow";
                }
                else
                {
                    empViewModel.SalaryColor = "green";
                }
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.Employees = empViewModels;
            employeeListViewModel.UserName = "Admin";
            return View("MyView", employeeListViewModel);
        }

    }
}