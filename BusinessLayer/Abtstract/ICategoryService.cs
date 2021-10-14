using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abtstract
{
    public interface ICategoryService 
    {
        List<Category> GetCategoryList();

        void CategoryAdd(Category category);

        Category GetById(int Id);

        void CategoryDelete(Category category);

        void CategoryUpdate(Category category);


    }
}
