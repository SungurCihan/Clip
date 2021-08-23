using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IImageService
    {
        IDataResult<Image> Get(Expression<Func<Image, bool>> filter);
        IDataResult<List<Image>> GetAll();
        IResult Add(Image image);
        IResult Update(Image image);
        IResult Delete(Image image);
    }
}
