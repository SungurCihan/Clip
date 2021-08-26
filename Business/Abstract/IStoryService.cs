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
    public interface IStoryService
    {
        IDataResult<Story> Get(Expression<Func<Story, bool>> filter);
        IDataResult<List<Story>> GetAll();
        IResult Add(Story story);
        IResult Update(Story story);
        IResult Delete(Story story);
    }
}
