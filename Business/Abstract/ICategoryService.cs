﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetList();
        // IDataResult<Category> GetById(int categoryId);
        // IDataResult<List<Category>> GetListByCategory(int categoryId);
        // IResult Add(Category category);
        // IResult Delete(Category category);
        // IResult Update(Category category);
    }
}
