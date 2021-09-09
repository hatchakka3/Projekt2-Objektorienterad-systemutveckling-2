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

namespace ResponsiveGUI.Models
{
    public class AdminSession : INotifyPropertyChanged
    {
        FacadeServices FacadeServices = new FacadeServices(new UnitOfWork(new OSU2Context()));

        private Admin admin;

        public Admin Admin
        {
            get { return admin; }
            set { admin = value;
                Changed();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //public AdminSession Read()
        //{
        //    BusinessEntities.Sessions.AdminSession adminSession = new BusinessEntities.Sessions.AdminSession();

        //    //var config = new MapperConfiguration(cfg => cfg.CreateMap<BusinessEntities.Sessions.AdminSession, AdminSession>());
        //    //var mapper = config.CreateMapper();

        //    var mapper = new Mapper(config);
        //}
    }
}
