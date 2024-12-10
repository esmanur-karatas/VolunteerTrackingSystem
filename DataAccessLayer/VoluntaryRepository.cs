using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class VoluntaryRepository
    {
        private readonly DatabaseContext _context;

        public VoluntaryRepository()
        {
            _context = new DatabaseContext();
        }

        public List<User> GetAllValuntary()
        {
            // Entity Framework ile doğrudan DbSet üzerinden veri çekme
            return _context.Users.ToList();
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges(); // Veritabanına değişiklikleri uygular
        }
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
        public void UpdateUser(User user)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.UserName = user.UserName;
                existingUser.Password = user.Password;
                existingUser.FullName = user.FullName;
                _context.SaveChanges(); // Değişiklikleri kaydet
            }
        }
        public void DeleteUser(int userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges(); // Veritabanından kaydı sil
            }
        }

        public User GetUserByCredentials(string userName, string password)
        {
            return _context.Users.FirstOrDefault(u => u.UserName == userName && u.Password == password);
        }

        public void AddLog(Log log)
        {
            _context.Logs.Add(log);
            _context.SaveChanges();
        }


    }
}
