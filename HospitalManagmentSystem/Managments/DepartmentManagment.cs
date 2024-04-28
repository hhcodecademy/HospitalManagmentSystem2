using HospitalManagmentSystem.Data;
using HospitalManagmentSystem.Models;
using HospitalManagmentSystem.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem.Managments
{
    public class DepartmentManagment
    {
        CustomDbContext dbContext;
        public DepartmentManagment()
        {
            dbContext = new CustomDbContext();
           // dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public void AddDepartment()
        {

            Department department = new Department();
            List<Doctor> doctors = new List<Doctor>();
            Console.WriteLine("Enter dep name:");
            department.Name = Console.ReadLine();
            Console.WriteLine("Enter dep desc:");
            department.Description = Console.ReadLine();

            Console.WriteLine("Have you got any doctors for this department:");
            char flag = char.Parse(Console.ReadLine().ToLower());
            while (flag == 'y')
            {

                Doctor doctor = new Doctor();
                Console.WriteLine("Enter doctor name:");
                doctor.Name = Console.ReadLine();
                Console.WriteLine("Enter doctor surname:");
                doctor.Surname = Console.ReadLine();
                Console.WriteLine("Enter doctor fathername:");
                doctor.Fatehername = Console.ReadLine();
                Console.WriteLine("Enter doctor occupation:");
                doctor.Occupation = Console.ReadLine();
                Console.WriteLine("Enter doctor gender(1,2):");
                int gender = int.Parse(Console.ReadLine());
                doctor.Gender = (GenderType)gender;
                doctors.Add(doctor);
                Console.WriteLine("Have you got any doctors for this department:");
                flag = char.Parse(Console.ReadLine().ToLower());
            }
            department.Doctors = doctors;
            dbContext.Departments.Add(department);
            dbContext.SaveChanges();

        }
        public void UpdateDepartment()
        {
            ShowDepartment();
    

            Console.WriteLine("Dep id daxil ediniz.");
            int id = int.Parse(Console.ReadLine());

            var dep = dbContext.Departments.Find(id);
            if (dep != null)
            {
                Console.WriteLine("Deyismek istediyiniz department melumatlarini daxil edniz");
                dep.Name = Console.ReadLine();
                dep.Description = Console.ReadLine();
                dbContext.Departments.Update(dep);
                dbContext.SaveChanges();
            }

        }

        public void DeleteDepartment()
        {
            ShowDepartment();


            Console.WriteLine("Silmek istediyiniz Dep id daxil ediniz.");
            int id = int.Parse(Console.ReadLine());

            var dep = dbContext.Departments.Find(id);
            if (dep != null)
            {
                dbContext.Departments.Remove(dep);
                dbContext.SaveChanges();
            }

        }

        public void ShowDepartment()
        {

            var departments = dbContext.Departments;
            Console.WriteLine($"Id   Name      Descrtipton");
            foreach (var department in departments)
            {
                Console.WriteLine($"{department.Id}    {department.Name} {department.Description}");
            }

        }


    }

}
