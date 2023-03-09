using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastracture.Models.Repositories
{
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }

        public void CreateUser(User user);

        public void UpdateUser(User user);

        public void DeleteUser(User user);
    }
}
