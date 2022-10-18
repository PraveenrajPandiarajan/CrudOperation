using CrudOperation.Core.IService;
using CrudOperation.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CrudOperation.Service.Service.StudentService;
using static CrudOperation.Service.Service.StudentService;
using CrudOperation.Core.IRepository;
using CrudOperation.Entity;

namespace CrudOperation.Service.Service
{
    public class StudentService
    {
        public class StudentServices : IService
        {
            private readonly IRepository _studentRepository;

            public StudentServices(IRepository studentRepository)
            {
                _studentRepository = studentRepository;
            }
            public void CreateStudentEntry(Student student)
            {
                if (student.First_Name != string.Empty && student.First_Name != string.Empty)
                {
                    _studentRepository.CreateStudentEntry(student);
                }
            }
            public List<Student> Read()
            {

                return _studentRepository.Read();
            }
            public void Update(int id,Student model)
            {
                _studentRepository.Update(id,model);
            }
            public Student EditForm(int id)
            {
                return _studentRepository.EditForm(id);
            }
        
            public void DeleteConform(int id)
            {
                 _studentRepository.DeleteConform(id);
            }

        }
    }
}

    