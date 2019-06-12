using SammyCloudData.Contexts;
using SammyCloudData.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SammyCloudData.DAL
{
    public interface IAccountRepository
    {
        Task<Result<Account[]>> Get();

        Task<Result<Account>> Get(int id);

    }

    public class AccountRepository : IAccountRepository
    {
        public Task<Result<Account[]>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<Result<Account>> Get(int id)
        {
            return await Task.Run(() =>
            {
                try
                {
                    using (var context = new SammyCloudContext())
                    {
                        Account account = context.Accounts.FirstOrDefault(x => x.ID == id);
                        return new Result<Account>(account);
                    }
                }
                catch (Exception ex)
                {
                    return new Result<Account>(ex);
                }
            });

        }
    }
}