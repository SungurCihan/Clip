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
    public interface ISocialMediaLinkService
    {
        IDataResult<SocialMediaLink> Get(Expression<Func<SocialMediaLink, bool>> filter);
        IDataResult<List<SocialMediaLink>> GetAll();
        IResult Add(SocialMediaLink socialMediaLink);
        IResult Update(SocialMediaLink socialMediaLink);
        IResult Delete(SocialMediaLink socialMediaLink);
    }
}
