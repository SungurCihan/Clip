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
    public class SocialMediaLinkManager : ISocialMediaLinkService
    {
        ISocialMediaLinkDal _socialMediaLinkDal;

        public SocialMediaLinkManager(ISocialMediaLinkDal socialMediaLinkDal)
        {
            _socialMediaLinkDal = socialMediaLinkDal;
        }

        public IResult Add(SocialMediaLink socialMediaLink)
        {
            _socialMediaLinkDal.Add(socialMediaLink);
            return new SuccessResult(Messages.SocialMediaLinkAdded);
        }

        public IResult Delete(SocialMediaLink socialMediaLink)
        {
            _socialMediaLinkDal.Delete(socialMediaLink);
            return new SuccessResult(Messages.SocialMediaLinkDeleted);
        }

        public IDataResult<SocialMediaLink> Get(Expression<Func<SocialMediaLink, bool>> filter)
        {
            return new SuccessDataResult<SocialMediaLink>(_socialMediaLinkDal.Get(filter));
        }

        public IDataResult<List<SocialMediaLink>> GetAll()
        {
            return new SuccessDataResult<List<SocialMediaLink>>(_socialMediaLinkDal.GetAll());
        }

        public IResult Update(SocialMediaLink socialMediaLink)
        {
            _socialMediaLinkDal.Update(socialMediaLink);
            return new SuccessResult(Messages.SocialMediaLinkUpdated);
        }
    }
}
