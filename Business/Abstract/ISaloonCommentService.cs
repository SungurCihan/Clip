using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISaloonCommentService
    {
        IDataResult<SaloonComment> Get(Expression<Func<SaloonComment, bool>> filter);
        IDataResult<List<SaloonComment>> GetAll();
        IResult Add(SaloonComment saloonComment);
        IResult Update(SaloonComment saloonComment);
        IResult Delete(SaloonComment saloonComment);
        IDataResult<List<SaloonCommentDetailDto>> GetSaloonCommentDetails();
    }
}
