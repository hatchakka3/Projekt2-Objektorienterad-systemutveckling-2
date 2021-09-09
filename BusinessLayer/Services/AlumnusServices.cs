using BusinessEntities;
using BusinessEntities.Sessions;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class AlumnusServices : Service
    {
        public AlumnusServices(OSU2Context osu2context) : base(osu2context)
        {

        }

        public void RegistrationAlumnus(Alumnus alumnus)
        {
            unitofwork.AlumnusRepository.Insert(alumnus);
        }

        public AlumnusSession AlumnusLogIn(string username, string password)
        {
            AlumnusSession alumnusSession = null;
            Alumnus alumnus = unitofwork.AlumnusRepository.GetAlumnusLogIn(username, password);
            if (alumnus != null && alumnus.Password == password)
                alumnusSession = new AlumnusSession(alumnus);
            return alumnusSession;
        }

        public List<Alumnus> SearchAlumnusByName(string input)
        {
            return unitofwork.EmployeeRepository.SearchAlumnusByName(input);
        }


        public List<Alumnus> SearchAlumnusByEducation(string input)
        {
            return unitofwork.EmployeeRepository.SearchAlumnusByEducation(input);
        }


        public IEnumerable<Alumnus> GetAllAlumnus()
        {
            return unitofwork.AlumnusRepository.GetAll();
        }

        public void UpdateAlumnusProfile(int id, string name, string username, string email, string description)
        {
            Alumnus alumnus = unitofwork.AlumnusRepository.GetById(id);
            alumnus.Name = name;
            alumnus.Username = username;
            alumnus.Email = email;
            alumnus.TextualDescription = description;
            if (alumnus != null)
            {
                unitofwork.AlumnusRepository.Update(alumnus);
            }
        }

        public Alumnus ValidateAlumnusPassword(string password)
        {
            Alumnus alumnus = unitofwork.AlumnusRepository.GetAlumnusPassword(password);
            if (alumnus != null)
                return alumnus;
            return null;
        }

        public void UpdateAlumnusPassword(int id, string password)
        {
            Alumnus alumnus = unitofwork.AlumnusRepository.GetById(id);
            alumnus.Password = password;
            if (alumnus != null)
            {
                unitofwork.AlumnusRepository.Update(alumnus);
            }
        }
    }
}
