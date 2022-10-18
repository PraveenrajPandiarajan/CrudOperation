using CrudOperation.Core.IRepository;
using CrudOperation.Core.Model;
using CrudOperation.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperation.Repository.Repository
{
    public class StudentRepository : IRepository
    {
        public StudentDetailsContext entity;

        public StudentRepository(StudentDetailsContext masterContext)
        {
            entity = masterContext;
        }
        
        #region Create
        public void CreateStudentEntry(Student student)
        {
            //masterContext entity = new masterContext();
            CrudOperation.Entity.Details student1 = new CrudOperation.Entity.Details();
            student1.First_Name = student.First_Name;
            student1.Address = student.Address;
            student1.Middle_Name = student.Middle_Name;
            student1.Gender = student.Gender;
            student1.Course = student.Course;
            student1.Phone = student.Phone;
            student1.Email_Id = student.Email_Id;
            student1.Last_Name = student.Last_Name;
            student1.Password = student.Password;
            student1.Retype_Password = student.Retype_Password;
            entity.Details.Add(student1);
            entity.SaveChanges();

        }
        #endregion
       
        #region Delete
     
        public void DeleteConform(int id)
        {
            var data = entity.Details.Where(x => x.Student_Id == id).SingleOrDefault();
            if (data != null)
            {
            
                data.Is_Deleted = true;
                entity.SaveChanges();
            }
        }
        #endregion
   
        #region Edit and Update
        public Student EditForm(int id)
        {
            Student registrationModel = new Student();
            var data = entity.Details.Where(x => x.Student_Id == id).SingleOrDefault();
            registrationModel.Student_Id = data.Student_Id;
            registrationModel.First_Name = data.First_Name;
            registrationModel.Middle_Name = data.Middle_Name;
            registrationModel.Last_Name = data.Last_Name;
            registrationModel.Gender = data.Gender;
            registrationModel.Course = data.Course;
            registrationModel.Phone = data.Phone;
            registrationModel.Address = data.Address;
            registrationModel.Email_Id = data.Email_Id;
            registrationModel.Password = data.Password;
            registrationModel.Retype_Password = data.Retype_Password;
            registrationModel.Is_Deleted = data.Is_Deleted;
            registrationModel.Create_Time_Stamp = data.Create_Time_Stamp;
            registrationModel.Update_Time_Stamp = data.Update_Time_Stamp;
            return registrationModel;
        }
        public void Update(int id, Student model)
        {

            var data = entity.Details.Where(x => x.Student_Id == id).SingleOrDefault();
            if (data != null)
            {
                data.Student_Id = model.Student_Id;
                data.First_Name = model.First_Name;
                data.Middle_Name = model.Middle_Name;
                data.Last_Name = model.Last_Name;
                data.Course = model.Course;
                data.Gender = model.Gender;
                data.Phone = model.Phone;
                data.Address = model.Address;
                data.Email_Id = model.Email_Id;
                data.Password = model.Password;
                data.Retype_Password = model.Retype_Password;
                data.Create_Time_Stamp = DateTime.Now;
                data.Update_Time_Stamp = DateTime.Now;
                entity.SaveChanges();
            }
        }
        #endregion

       
        #region Read
        public List<Student> Read()
        {
            List<Student> model = new List<Student>();
            var data = entity.Details.Where(x => x.Is_Deleted == false).ToList();
            foreach (var item in data)
            {
                Student registrationModel = new Student();
                registrationModel.Student_Id = item.Student_Id;
                registrationModel.First_Name = item.First_Name;
                registrationModel.Middle_Name = item.Middle_Name;
                registrationModel.Last_Name = item.Last_Name;
                registrationModel.Gender = item.Gender;
                registrationModel.Course = item.Course;
                registrationModel.Phone = item.Phone;
                registrationModel.Address = item.Address;
                registrationModel.Email_Id = item.Email_Id;
                registrationModel.Password = item.Password;
                registrationModel.Retype_Password = item.Retype_Password;
                registrationModel.Is_Deleted = item.Is_Deleted;
                registrationModel.Create_Time_Stamp = item.Create_Time_Stamp;
                registrationModel.Update_Time_Stamp = item.Update_Time_Stamp;
                model.Add(registrationModel);

            }
            return model;
        }
        #endregion

    }
}
