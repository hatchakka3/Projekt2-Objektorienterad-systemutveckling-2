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
    public class Alumnus : Person, INotifyPropertyChanged
    {
        FacadeServices FacadeServices = new FacadeServices(new UnitOfWork(new OSU2Context()));

        private MapperConfiguration config;
        private IMapper mapper;

        private MapperConfiguration config2;
        private IMapper mapper2;

        public Alumnus()
        {
            config = new MapperConfiguration(cfg => cfg.CreateMap<Alumnus, AlumnusDto>());
            mapper = config.CreateMapper();

            config2 = new MapperConfiguration(cfg => cfg.CreateMap<AlumnusDto, Alumnus>());
            mapper2 = config2.CreateMapper();
        }

        public AlumnusDto Dto()
        {
            return mapper.Map<AlumnusDto>(this);
        }

        public Alumnus ReverseDto(AlumnusDto a)
        {
            return mapper2.Map<Alumnus>(a);
        }

        private int alumnusId;
        private string education;
        private string degree;
        private string textualDescription;
        private bool registered;

        public int AlumnusDtoId
        {
            get { return alumnusId; }
            set { alumnusId = value;
                Changed();
            }
        }

        public string Education
        {
            get { return education; }
            set { education = value;
                Changed();
            }
        }

        public string Degree
        {
            get { return degree; }
            set { degree = value;
                Changed();
            }
        }

        public string TextualDescription
        {
            get { return textualDescription; }
            set { textualDescription = value;
                Changed();
            }
        }

        public bool Registered
        {
            get { return registered; }
            set { registered = true;
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

        public ObservableCollection<Alumnus> Read()
        {
            BusinessEntities.AlumnusDto Alumnus = new BusinessEntities.AlumnusDto();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<BusinessEntities.AlumnusDto, Alumnus>());
            var mapper = config.CreateMapper();

            ObservableCollection<Alumnus> o = new ObservableCollection<Alumnus>();

            foreach (var item in FacadeServices.GetServices.GetAllAlumnus())
            {
                Alumnus a = mapper.Map<Alumnus>(item);

                o.Add(a);
            }

            return o;
        }
    }
}
