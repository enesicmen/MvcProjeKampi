using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abtstract
{
    public interface IContentService
    {
        List<Content> GetCategoryList();

        List<Content> GetListByHeadingId(int Id);

        void ContentAdd(Content content);

        Content GetById(int Id);

        void ContentDelete(Content content);

        void ContentUpdate(Content content);
    }
}
