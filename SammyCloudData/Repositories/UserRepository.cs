using SammyCloudData.Contexts;
using SammyCloudData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammyCloudData.DAL
{
    public interface IUserRepository
    {
        Task<Result<User>> AuthorizeAsync(string username, string password);
    }

    public class UserRepository : IUserRepository
    {
        public async Task<Result<User>> AuthorizeAsync(string username, string password)
        {
            return await Task.Run(() =>
            {
                try
                {
                    username = username?.ToLower();

                    using (var context = new SammyCloudContext())
                    {
                        User user = context.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
                        return new Result<User>(user);
                    }
                }
                catch (Exception ex)
                {
                    return new Result<User>(ex);
                }
            });
        }
    }
}
