using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuckyContractMgr.Models.Repository;
using LuckyContractMgr.Models;

namespace LuckyContractMgr.Models.DataManager
{
    public class LoginManager : IDataRepository<LoginModel>
    {
        readonly ContractContext _contractContext;
        public LoginManager(ContractContext context)
        {
            _contractContext = context;
        }
        public IEnumerable<LoginModel> GetAll()
        {
            return _contractContext.LoginModels.ToList();
        }
        public LoginModel Get(long id)
        {
            return _contractContext.LoginModels
                  .FirstOrDefault(e => e.Id == id);
        }
        public LoginModel GetByUsernamePassword(string Username, string UserPassword)
        {
            return _contractContext.LoginModels
                  .FirstOrDefault(e => e.UserName == Username && e.Password == UserPassword);
        }
        public void Add(LoginModel entity)
        {
            _contractContext.LoginModels.Add(entity);
            _contractContext.SaveChanges();
        }
        public void Update(LoginModel loginmodel, LoginModel entity)
        {
            loginmodel.FullName = entity.FullName;
            loginmodel.EmailAddress = entity.EmailAddress;
            loginmodel.Telephone = entity.Telephone;
            loginmodel.UserName = entity.UserName;
            loginmodel.Password = entity.Password;
           
            _contractContext.SaveChanges();
        }
        public void Delete(LoginModel loginmodel)
        {
            _contractContext.LoginModels.Remove(loginmodel);
            _contractContext.SaveChanges();
        }

    }
}
