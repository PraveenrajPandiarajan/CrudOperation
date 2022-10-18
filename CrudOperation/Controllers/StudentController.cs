using CrudOperation.Core.Model;
using CrudOperation.Models;
using CrudOperation.Service.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CrudOperation.Core.IService;
using CrudOperation.Entity;


namespace CrudOperation.Controllers
{
    public class StudentController : Controller
    {
        private readonly IService _StudentServices;
        public StudentController(IService services)
        {

            _StudentServices = services;
        }
        //Create a data to the database.
        #region Create
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Next(Student student)
        {
            if (ModelState.IsValid)
            {
                _StudentServices.CreateStudentEntry(student);
                return RedirectToAction("Result");
            }
            else
            {
                return View("Index");
            }
        }
        #endregion
        //Read Operation
        #region Read 
        public IActionResult Result()
        {
            var value = _StudentServices.Read();
            return View(value);
        }
        #endregion
        //Delete Operation- delete the data from the database.
        #region Delete
        public IActionResult Delete(int id)
        {
            _StudentServices.DeleteConform(id);
            return RedirectToAction("Result");

        }
      
        #endregion
        
        #region Edit
        public IActionResult Edit(int id)
        {
                var value = _StudentServices.EditForm(id);
                return View(value);
               
        }
        [HttpPost]
        public IActionResult Edit(int id, Student model)
        {
            _StudentServices.Update(id, model);
            return RedirectToAction("Result");
          
        }
        #endregion


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}