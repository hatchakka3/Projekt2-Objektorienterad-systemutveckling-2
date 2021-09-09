using System;
using BusinessLayer;
using DataLayer;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessEntities.Entities;

namespace ResponsiveGUI.Models
{
    public class Mailing : INotifyPropertyChanged
    {
        FacadeServices FacadeServices = new FacadeServices(new UnitOfWork(new OSU2Context()));

        private int mailingId;

        private MapperConfiguration config;
        private IMapper mapper;
        private MapperConfiguration config2;
        private IMapper mapper2;

        public Mailing()
        {
            config = new MapperConfiguration(cfg => cfg.CreateMap<Mailing, MailingDto>());
            mapper = config.CreateMapper();

            config2 = new MapperConfiguration(cfg => cfg.CreateMap<MailingDto, Mailing>());
            mapper2 = config2.CreateMapper();
        }

        public MailingDto Dto()
        {
            return mapper.Map<MailingDto>(this);
        }

        public Mailing ReverseDto(MailingDto m)
        {
            return mapper2.Map<Mailing>(m);
        }

        public int MailingDtoId
        {
            get { return mailingId; }
            set { mailingId = value;
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Mailing> Read()
        {
            BusinessEntities.Entities.MailingDto activity = new BusinessEntities.Entities.MailingDto();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<BusinessEntities.Entities.MailingDto, Mailing>());
            var mapper = config.CreateMapper();

            ObservableCollection<Mailing> o = new ObservableCollection<Mailing>();

            foreach (var item in FacadeServices.GetServices.GetAllMailings())
            {
                Mailing a = mapper.Map<Mailing>(item);

                o.Add(a);
            }

            return o;
        }
    }
}
