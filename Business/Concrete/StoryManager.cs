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
    public class StoryManager : IStoryService
    {
        IStoryDal _storyDal;

        public StoryManager(IStoryDal storyDal)
        {
            _storyDal = storyDal;
        }

        public IResult Add(Story story)
        {
            _storyDal.Add(story);
            return new SuccessResult(Messages.StoryAdded);
        }

        public IResult Delete(Story story)
        {
            _storyDal.Delete(story);
            return new SuccessResult(Messages.StoryDeleted);
        }

        public IDataResult<Story> Get(Expression<Func<Story, bool>> filter)
        {
            return new SuccessDataResult<Story>(_storyDal.Get(filter));
        }

        public IDataResult<List<Story>> GetAll()
        {
            return new SuccessDataResult<List<Story>>(_storyDal.GetAll());
        }

        public IResult Update(Story story)
        {
            _storyDal.Update(story);
            return new SuccessResult(Messages.StoryUpdated);
        }
    }
}
