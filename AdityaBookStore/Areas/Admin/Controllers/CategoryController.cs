﻿
using AdityaBooks.DataAccess.Repository.IRepository;
using AdityaBooks.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdityaBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.Id == 0)
                {
                    _unitOfWork.Category.Add(category);
                     _unitOfWork.Save();
                }
                else
                {
                    _unitOfWork.Category.Update(category);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));

            }
            return View(category);
        }

        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            //return NotFound
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });

        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = true, message = "Erroe while Deleting" });
            }
            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion
    }
}