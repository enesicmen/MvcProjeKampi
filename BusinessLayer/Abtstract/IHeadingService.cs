using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abtstract
{
    public interface IHeadingService
    {
        List<Heading> GetCategoryList();

        void HeadingAdd(Heading heading);

        Heading GetById(int Id);

        void HeadingDelete(Heading heading);

        void HeadingUpdate(Heading heading);
    }
}
