﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaBooks.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; } //Displays all the products details

        public IEnumerable<SelectListItem> CategoryList { get; set; } //install the pakage "MS. Aspcore.Mvc.Rendering"
        public IEnumerable<SelectListItem> CoverTypeList { get; set; } //install the pakage "MS. Aspcore.Mvc.Rendering"

    }
}
