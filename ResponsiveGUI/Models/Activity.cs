using System;
using System.Collections.Generic;
using DataLayer;
using BusinessLayer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using AutoMapper;
using BusinessEntities;

namespace ResponsiveGUI.Models
{
    public class Activity : INotifyPropertyChanged
    {
        FacadeServices FacadeServices = new FacadeServices(new UnitOfWork(new OSU2Context()));

        private int activityID;
        private string description;
        private bool available;
        private DateTime startDate;
        private DateTime endDate;

        private MapperConfiguration config;
        private IMapper mapper;

        private MapperConfiguration config2;
        private IMapper mapper2;

        public Activity()
        {
            config = new MapperConfiguration(cfg => cfg.CreateMap<Activity, ActivityDto>());
            mapper = config.CreateMapper();

            config2 = new MapperConfiguration(cfg => cfg.CreateMap<ActivityDto, Activity>());
            mapper2 = config2.CreateMapper();

            Available = true;
        }

        public ActivityDto Dto()
        {
            return mapper.Map<ActivityDto>(this);
        }

        public Activity ReverseDto(ActivityDto a)
        {
            return mapper2.Map<Activity>(a);
        }

        public int ActivityDtoID
        {
            get { return activityID; }
            set { activityID = value;
                Changed(); }
        }

        public string Description
        {
            get { return description; }
            set { description = value;
                Changed(); }
        }

        public bool Available
        {
            get { return available; }
            set { available = value;
                Changed(); }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value;
                Changed();
            }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set
            {
                endDate = value;
                Changed();
            }
        }

        private ObservableCollection<Alumnus> alumni = new ObservableCollection<Alumnus>();

        public ObservableCollection<Alumnus> Alumni
        {
            get { return alumni; }
            set { alumni = value;
                Changed();
            }
        }

        public ObservableCollection<Activity> Read()
        {
            BusinessEntities.ActivityDto activity = new BusinessEntities.ActivityDto();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<BusinessEntities.ActivityDto, Activity>());
            var mapper = config.CreateMapper();

            ObservableCollection<Activity> o = new ObservableCollection<Activity>();

            foreach(var item in FacadeServices.GetServices.GetAllActivities())
            {
                Activity a = mapper.Map<Activity>(item);

                o.Add(a);
            }

            return o;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
