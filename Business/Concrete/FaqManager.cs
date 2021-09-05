using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FaqManager : IFaqService
    {
        IFaqDal _faqDal;

        public FaqManager(IFaqDal faqDal)
        {
            _faqDal = faqDal;
        }

        public IResult Add(Faq faq)
        {
            _faqDal.Add(faq);
            return new SuccessResult(Messages.FaqAdded);
        }

        public IResult Delete(Faq faq)
        {
            _faqDal.Delete(faq);
            return new SuccessResult(Messages.FaqDeleted);
        }

        public IDataResult<Faq> Get(Expression<Func<Faq, bool>> filter)
        {
            return new SuccessDataResult<Faq>(_faqDal.Get(filter));
        }

        public IDataResult<List<Faq>> GetAll()
        {
            return new SuccessDataResult<List<Faq>>(_faqDal.GetAll());
        }

        public IResult Update(Faq faq)
        {
            _faqDal.Update(faq);
            return new SuccessResult(Messages.FaqUpdated);
        }
    }
}
