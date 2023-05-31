using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Context
{
  public  class UnitOfWork:IDisposable
    {

        //--------Fields--------------
        Accounting_DbContext db = new Accounting_DbContext( );
        public UnitOfWork()
        {
            //db.Configuration.LazyLoadingEnabled = false;
        }
       
        private IUserRepository _userRepository;
        private IRegistrationRepository _RegistrationRepository;
        private ICompanyRepository _CompanyRepository;
        private ICategoryRepository _CategoryRepository;
        private IProductRepository _ProductRepository;
        private ICustomerRepository _CustomerRepository;
        private IStockRepository _stockRepository;
        //-----------Properties---------------
        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(db);
                }

                return _userRepository;
            }
        }

        public IRegistrationRepository RegistrationRepository
        {
            get
            {
                if (_RegistrationRepository == null)
                {
                    _RegistrationRepository = new RegistrationRepository(db);
                }

                return _RegistrationRepository;
            }
        }
      
        public ICompanyRepository CompanyRepository
        {
            get
            {
                if (_CompanyRepository == null)
                {
                    _CompanyRepository = new CompanyRepository(db);
                }

                return _CompanyRepository;
            }
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (_CategoryRepository == null)
                {
                    _CategoryRepository = new CategoryRepository(db);
                }

                return _CategoryRepository;
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (_ProductRepository == null)
                {
                    _ProductRepository = new ProductRepository(db);
                }

                return _ProductRepository;
            }
        }


       


        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_CustomerRepository == null)
                {
                    _CustomerRepository = new CustomerRepository(db);
                }

                return _CustomerRepository;
            }
        }


        public IStockRepository StockRepository
        {
            get
            {
                if (_stockRepository == null)
                {
                    _stockRepository = new StockRepository(db);
                }

                return _stockRepository;
            }
        }


        //---------Methods-----------------
        public void Save()
        {
            db.SaveChanges();
        }



























        public void Dispose()//if Using Method Not Use . I Could Call this Method to Dispose all Resources .   
        {
         //   db.Dispose();
         //   db = null;
         ////   _userRepository.Dispose();
         //   _userRepository = null;
         //   _RegistrationRepository = null;
         //   _CompanyRepository = null;
         //   _CategoryRepository = null;
         //   _ProductRepository = null;
         //   _CustomerRepository = null;

        }




        ~UnitOfWork()
        {
            Dispose();
        }
















        //---End Block of Class And Namespace------------------------
    }
}



    
