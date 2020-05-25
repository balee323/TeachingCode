using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFileEditor.Model;

namespace SimpleFileEditor
{
    class DataMapper
    {

        //constructor
        public DataMapper()
        {

        }


        public List<Employee> Extract(string[] rawData)
        {
            List<Employee> emps = new List<Employee>();

            for(int i = 0; i < rawData.Length; i++)
            {
                string[] parts = rawData[i].Split('|');

                Employee emp = new Employee();

                emp.EmployeeName = parts[0]; //name
                emp.EmployeeDOB = DateTime.Parse(parts[1]); //DOB
                emp.EmployeeJobTitle = parts[2]; //job title

                emps.Add(emp);
            }

            return emps;

        }


    }
}
