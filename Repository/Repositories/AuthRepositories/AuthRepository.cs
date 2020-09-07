using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AuthRepositories
{
    public class AuthRepository :IAuthRepository

    {
        private readonly TravelDbContext _context;
    public AuthRepository(TravelDbContext context)
    {
        _context = context;
    }

    public User CheckByToken(string token)
    {
        return _context.Users.FirstOrDefault(u => u.Token == token);
    }

        public bool CheckEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

        public User Login(string email, string password)
    {
        User user = _context.Users.FirstOrDefault(u => u.Email == email);
        if (user != null && CryptoHelper.Crypto.VerifyHashedPassword(user.Password, password))
        {
            return user;
        }

        return null;
    }

    public User Register(User user)
    {
        user.Password = CryptoHelper.Crypto.HashPassword(user.Password);
        user.AddedDate = DateTime.Now;
        user.ModifiedDate = DateTime.Now;
        user.AddedBy = "System";
        user.ModifiedBy = "System";

        _context.Users.Add(user);
        _context.SaveChanges();
        return user;

    }

    public void UpdateToken(int id, string token)
    {
        User user = _context.Users.Find(id);
        user.Token = token;
        _context.SaveChanges();
    }

    public bool UserExsist(string email)
    {
        return _context.Users.Any(u => u.Email == email);
    }
}
}
