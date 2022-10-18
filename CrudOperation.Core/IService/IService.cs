using CrudOperation.Core.Model;
using CrudOperation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperation.Core.IService
{
    public interface IService
    {
        void CreateStudentEntry(Student student);
  
        List<Student> Read();
        void Update(int id,Student model);
        Student EditForm(int id);
        
       void DeleteConform(int id);

    }
}
