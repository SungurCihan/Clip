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
    public interface IFaqService
    {
        IDataResult<Faq> Get(Expression<Func<Faq, bool>> filter);
        IDataResult<List<Faq>> GetAll();
        IResult Add(Faq faq);
        IResult Update(Faq faq);
        IResult Delete(Faq faq);
    }
}
