using System;
using DataLayer;
using BusinessLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using AutoMapper;
using BusinessEntities;

namespace ResponsiveGUI.Models
{
    public class Admin : Person, INotifyPropertyChanged
    {
        FacadeServices FacadeServices = new FacadeServices(new UnitOfWork(new OSU2Context()));

        private MapperConfiguration config;
        private IMapper mapper;

        private MapperConfiguration config2;
        private IMapper mapper2;

        public Admin()
        {
            config = new MapperConfiguration(cfg => cfg.CreateMap<Admin, AdminDto>());
            mapper = config.CreateMapper();

            config2 = new MapperConfiguration(cfg => cfg.CreateMap<AdminDto, Admin>());
            mapper2 = config2.CreateMapper();
        }

        public BusinessEntities.AdminDto Dto()
        {
            return mapper.Map<AdminDto>(this);
        }

        public Admin ReverseDto(AdminDto a)
        {
            return mapper2.Map<Admin>(a);
        }

        private int adminId;
        private string employeeNumber;

        public int AdminDtoId
        {
            get { return adminId; }
            set { adminId = value;
                Changed();
            }
        }

        public string EmployeeNumber
        {
            get { return employeeNumber; }
            set { employeeNumber = value;
                Changed();
            }
        }

        private ObservableCollection<Activity> activities = new ObservableCollection<Activity>();

        public ObservableCollection<Activity> Activities
        {
            get { return activities; }
            set { activities = value;
                Changed();
            }
        }

        private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public ObservableCollection<Employee> Employees
        {
            get { return employees; }
            set { employees = value;
                Changed();
            }
        }

        private ObservableCollection<Alumnus> alumni = new ObservableCollection<Alumnus>();

        public ObservableCollection<Alumnus> Alumni
        {
            get { return alumni; }
            set
            {
                alumni = value;
                Changed();
            }
        }

        public ObservableCollection<Admin> Read()
        {
            BusinessEntities.AdminDto admin = new BusinessEntities.AdminDto();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<BusinessEntities.AdminDto, Admin>());
            var mapper = config.CreateMapper();

            ObservableCollection<Admin> o = new ObservableCollection<Admin>();

            foreach (var item in FacadeServices.GetServices.GetAllAdmins())
            {
                Admin a = mapper.Map<Admin>(item);

                o.Add(a);
            }

            return o;
        }
    }
}
