using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.AutoFact.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UsersManager : IUsersService
    {
        IUsersDal _usersDal;
        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }

        [ValidationAspect(typeof(UsersValidator))]
        public IResult Add(Users users)
        {
            _usersDal.Add(users);
            return new SuccessResult(Messages.UsersAdded);
        }

        public IResult Delete(Users users)
        {
            _usersDal.Delete(users);
            return new SuccessResult(Messages.UsersDeleted);
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_usersDal.GetAll(),Messages.RentalsListed);
        }

        public IResult Update(Users users)
        {
            _usersDal.Delete(users);
            return new SuccessResult(Messages.UsersUpdated);
        }
    }
}
