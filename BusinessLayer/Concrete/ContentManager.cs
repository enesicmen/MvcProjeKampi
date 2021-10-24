using BusinessLayer.Abtstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {

        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void ContentAdd(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentDelete(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetCategoryList()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeadingId(int Id)
        {
            return _contentDal.List(x=>x.HeadingID==Id);
        }
    }
}
