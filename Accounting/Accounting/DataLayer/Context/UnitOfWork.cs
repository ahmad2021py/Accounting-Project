using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using Accounting.DataLayer.Services;
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
        Accounting_DbContext db = new Accounting_DbContext();
        private IUserRepository _userRepository;
        private IRegistrationRepository _RegistrationRepository;
        private ICompanyRepository _CompanyRepository;
        private ICategoryRepository _CategoryRepository;
        private IProductRepository _ProductRepository;
        private IConfigRepository _ConfigRepository;
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


        public IConfigRepository ConfigRepository
        {
            get
            {
                if (_ConfigRepository == null)
                {
                    _ConfigRepository = new ConfigRepository(db);
                }

                return _ConfigRepository;
            }
        }


        //---------Methods-----------------
        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
            db = null;
            _userRepository = null;
            _RegistrationRepository = null;
            _CompanyRepository = null;
            _CategoryRepository = null;
            _ProductRepository = null;

        }





















        //---End Block of Class And Namespace------------------------
    }
}



    
