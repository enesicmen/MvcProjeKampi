using BusinessLayer.Abtstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetById(int Id)
        {
            return _categoryDal.Get(x => x.CategoryID == Id);
        }

        public List<Category> GetCategoryList()
        {
            return _categoryDal.List();
        }



        //public void CategoryAddBl(Category p)
        //{
        //    if(p.CategoryName == "" || p.CategoryStatus == false || p.CategoryName.Length <= 2)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        _categoryDal.Insert(p);
        //    }
        //}
    }
}
