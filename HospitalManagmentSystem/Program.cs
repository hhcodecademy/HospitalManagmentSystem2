using HospitalManagmentSystem.Managments;

namespace HospitalManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DepartmentManagment department = new DepartmentManagment();
            department.DeleteDepartment();
        }
    }
}
