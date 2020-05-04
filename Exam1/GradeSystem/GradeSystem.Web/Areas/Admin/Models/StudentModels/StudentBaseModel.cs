﻿using Autofac;
using GradeSystem.Framework.StudentAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeSystem.Web.Areas.Admin.Models.StudentModels
{
    public class StudentBaseModel : AdminBaseModel, IDisposable
    {
        protected readonly IStudentService _studentService;
        public StudentBaseModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public StudentBaseModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
        }

        public void Dispose()
        {
            _studentService?.Dispose();
        }
    }
}
