using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class AlumnusRepository : GenericRepository<Alumnus>
    {
        public AlumnusRepository(OSU2Context osu2context) : base(osu2context)
        {
            
        }

        public IEnumerable<Alumnus> GetUsername(string username)
        {
            return context.Alumni.Where(a => a.Username == username).ToList();
        }

        public IEnumerable<Alumnus> GetPassword(string password)
        {
            return context.Alumni.Where(a => a.Password == password).ToList();
        }

        public List<Alumnus> Search(string input)
        {
            return context.Alumni.Where(a => a.Name.Equals(input)).ToList();
        }
    }
}
