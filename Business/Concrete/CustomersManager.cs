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
    public class CustomersManager : ICustomersService
    {
        ICustomersDal _customersDal;
        public CustomersManager(ICustomersDal customersDal)
        {
            _customersDal = customersDal;
        }

        [ValidationAspect(typeof(CustomersValidator))]
        public IResult Add(Customers customers)
        {
            _customersDal.Add(customers);
            return new SuccessResult(Messages.CustomersAdded);
        }

        public IResult Delete(Customers customers)
        {
            _customersDal.Delete(customers);
            return new SuccessResult(Messages.CustomersDeleted);
        }

        public IDataResult<List<Customers>> GetAll()
        {
            return new SuccessDataResult<List<Customers>>(_customersDal.GetAll(),Messages.CustomersListed) ;
        }

        public IResult Update(Customers customers)
        {
            _customersDal.Update(customers);
            return new SuccessResult(Messages.CustomersUpdated);
        }
    }
}
