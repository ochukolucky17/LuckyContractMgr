using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuckyContractMgr.Models.Repository;
using LuckyContractMgr.Models;

namespace LuckyContractMgr.Models.DataManager
{
    public class ContractManager : IDataRepository<Contract>
    {
        readonly ContractContext _contractContext;
        public ContractManager(ContractContext context)
        {
            _contractContext = context;
        }
        public IEnumerable<Contract> GetAll()
        {
            return _contractContext.Contracts.ToList();
        }
        public Contract Get(long id)
        {
            return _contractContext.Contracts
                  .FirstOrDefault(e => e.Id == id);
        }
        public void Add(Contract entity)
        {
            _contractContext.Contracts.Add(entity);
            _contractContext.SaveChanges();
        }
        public void Update(Contract contract, Contract entity)
        {
            contract.VendorCompanyName = entity.VendorCompanyName;
            contract.PaymentTerms = entity.PaymentTerms;
            contract.PONumber = entity.PONumber;
            contract.RFQNumber = entity.RFQNumber;
            contract.ScopeOfWork = entity.ScopeOfWork;
            contract.TerminationTerms = entity.TerminationTerms;
            contract.VendorContactPerson = entity.VendorContactPerson;
            contract.ContractExecutedOn = entity.ContractExecutedOn;
            contract.ContractTerminateOn = entity.ContractTerminateOn;
            _contractContext.SaveChanges();
        }
        public void Delete(Contract employee)
        {
            _contractContext.Contracts.Remove(employee);
            _contractContext.SaveChanges();
        }

        public Contract GetByUsernamePassword(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
