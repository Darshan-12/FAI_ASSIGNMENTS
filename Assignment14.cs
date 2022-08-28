using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_Assignment
{
    interface IDataComponent
    {
        void Add(Employee employee);
        void Remove(int id);
        void Update(int id);
        Employee FindById(int id);
        Employee[] FindByName(string name);
    }
    class FileComponent:IDataComponent
    {
        public void Add(Employee employee)
        {
            
        }

        void IDataComponent.Add(Employee employee)
        {
           
        }

        Employee IDataComponent.FindById(int id)
        {
            return null;
        }

        Employee[] IDataComponent.FindByName(string name)
        {
            return null;
        }

        void IDataComponent.Remove(int id)
        {
         
        }

        void IDataComponent.Update(int id)
        {
            
        }
    }
    class Assignment14
    {
    }
}
