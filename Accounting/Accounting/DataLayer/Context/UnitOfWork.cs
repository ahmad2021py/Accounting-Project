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

        // ############# فیلد های کلاس  ##########
        Accounting_DbContext db = new Accounting_DbContext();

        private IUserRepository _userRepository;
        private IRegistrationRepository _RegistrationRepository;


        //#############پراپرتی های کلاس#############
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

        //--------------------------------------------------
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

        //############متد های کلاس ##################

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}



    
