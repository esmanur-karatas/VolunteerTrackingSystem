using DataAccessLayer;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class VoluntaryService
    {
        private readonly VoluntaryRepository _repository;

        public VoluntaryService()
        {
            _repository = new VoluntaryRepository();
        }

        public List<User> GetValuntaryList()
        {
            return _repository.GetAllValuntary();
        }

        public bool UserVerify(string userName, string password)
        {
            var personeller = _repository.GetAllValuntary();
            return personeller.Exists(p => p.UserName == userName && p.Password == password);
        }
    }
}
