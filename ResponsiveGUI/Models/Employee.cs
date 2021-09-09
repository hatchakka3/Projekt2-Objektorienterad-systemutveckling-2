using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;
using AutoMapper;
using BusinessEntities;

namespace ResponsiveGUI.Models
{
    public class Employee : Person, INotifyPropertyChanged
    {
        FacadeServices FacadeServices = new FacadeServices(new UnitOfWork(new OSU2Context()));

        private MapperConfiguration config;
        private IMapper mapper;
        private MapperConfiguration config2;
        private IMapper mapper2;

        public Employee()
        {
            config = new MapperConfiguration(cfg => cfg.CreateMap<Employee, EmployeeDto>());
            mapper = config.CreateMapper();

            config2 = new MapperConfiguration(cfg => cfg.CreateMap<EmployeeDto, Employee>());
            mapper2 = config2.CreateMapper();
        }

        public EmployeeDto Dto()
        {
            return mapper.Map<EmployeeDto>(this);
        }

        public Employee ReverseDto(EmployeeDto e)
        {
            return mapper2.Map<Employee>(e);
        }

        private int employeeId;
        private string signature;
        private string employeeNumber;

        public int EmployeeDtoId
        {
            get { return employeeId; }
            set { employeeId = value;
                Changed();
            }
        }

        public string Signature
        {
            get { return signature; }
            set { signature = value;
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


        private ObservableCollection<Mailing> Mailings = new ObservableCollection<Mailing>();

        public ObservableCollection<Mailing> mailings
        {
            get { return Mailings; }
            set { Mailings = value;
                Changed();
            }
        }

        public ObservableCollection<Employee> Read()
        {
            BusinessEntities.EmployeeDto activity = new BusinessEntities.EmployeeDto();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<BusinessEntities.EmployeeDto, Employee>());
            var mapper = config.CreateMapper();

            ObservableCollection<Employee> o = new ObservableCollection<Employee>();

            foreach (var item in FacadeServices.GetServices.DisplayAllEmployees())
            {
                Employee a = mapper.Map<Employee>(item);

                o.Add(a);
            }

            return o;
        }
    }
}
