using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudOperation.Core.Model;
using CrudOperation.Entity;

namespace CrudOperation.Core.IRepository
{
     public interface  IRepository
    {
        void CreateStudentEntry(Student student);
        List<Student> Read();
        Student EditForm(int id);
        void Update(int id, Student model);
        void DeleteConform(int id);
    }
}
