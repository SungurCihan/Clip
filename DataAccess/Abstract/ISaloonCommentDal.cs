using Core.DataAccess;
using Entity.Concrete;
using Entity.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ISaloonCommentDal : IEntityRepository<SaloonComment>
    {
        List<SaloonCommentDetailDto> GetSaloonCommentDetails(Expression<Func<SaloonCommentDetailDto, bool>> filter = null);

       SaloonCommentDetailDto GetSaloonCommentDetailsSingular(Expression<Func<SaloonCommentDetailDto, bool>> filter);
    }
}
