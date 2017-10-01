using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fogvent.Models.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace Fogvent.Security
{
    public class SecurityRepository:IUserStore<IdentityUser>,IUserPasswordStore<IdentityUser>,IUserSecurityStampStore<IdentityUser>
    {
        private readonly DbContext _context;
        private readonly IUserStore<IdentityUser> _userStore;

        public SecurityRepository(DbContext context)
        {
            _context = context;
            this._userStore = new UserStore<IdentityUser>(_context);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        Task<IdentityUser> IUserStore<IdentityUser, string>.FindByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        Task<IdentityUser> IUserStore<IdentityUser, string>.FindByNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindByNameAsync(string userName)
        {
            throw new NotImplementedException();
        }


        //Password


        public Task SetPasswordHashAsync(User user, string passwordHash)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetPasswordHashAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasPasswordAsync(User user)
        {
            throw new NotImplementedException();
        }

        //Security Stamp
        public Task SetSecurityStampAsync(User user, string stamp)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetSecurityStampAsync(User user)
        {
            throw new NotImplementedException();
        }


        public Task SetPasswordHashAsync(IdentityUser user, string passwordHash)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetPasswordHashAsync(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasPasswordAsync(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task SetSecurityStampAsync(IdentityUser user, string stamp)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetSecurityStampAsync(IdentityUser user)
        {
            throw new NotImplementedException();
        }
    }
}
