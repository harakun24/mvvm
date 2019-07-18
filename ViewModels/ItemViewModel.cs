using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using mode2.Models;
using Prism.Commands;

namespace mode2.ViewModels
{
    class ItemViewModel:INotifyPropertyChanged
    {
        private void ChangeProps(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public string Namous { get; set; }
        public ObservableCollection<string> temp { get; set; }
        public int Ccount { get { return Baru.isCount; } set {  Baru.isCount = value; ChangeProps("Ccount"); } }
        public ObservableCollection<string> Nama  { get{ return Baru.name; }set{ Baru.name = value; ChangeProps("Nama"); } }

        public ItemViewModel()
        {
            Btn_i = new DelegateCommand(Increase);
            Btn_d = new DelegateCommand(Decrease);
            Btn_a = new DelegateCommand(Addus);
            Btn_r = new DelegateCommand(Minous);
            Namous = "Satu";
        }

        private ItemModel Baru = new ItemModel();
        public void Increase()
        {
            Ccount++;
            
        }
        public void Decrease()
        {
            
            if (Ccount-1 < 0)
                Ccount = 0;
            else
                Ccount--;
        }
        public void Addus()
        {
            Nama.Add(Namous);
        }
        public void Minous()
        {
            int counn=0;
            //Nama.Remove(Namous);
            foreach(var item in Nama)
            {
                if (item == Namous)
                    counn++;
            }
            while (counn > 0)
            {
                Nama.Remove(Namous);
                counn--;
            }
        }
        public void load()
        {
            Ccount = 0;
        }
        private ICommand btn_i;
        private ICommand btn_d;
        private ICommand btn_a;
        private ICommand btn_r;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand Btn_i
        {
            get
            {
                return btn_i;
            }
            set
            {
                btn_i = value;
            }

        }
        public ICommand Btn_d
        {
            get
            {
                return btn_d;
            }
            set
            {
                btn_d = value;
            }

        }
        public ICommand Btn_a
        {
            get
            {
                return btn_a;
            }
            set
            {
                btn_a = value;
            }
        }
        public ICommand Btn_r
        {
            get
            {
                return btn_r;
            }
            set
            {
                btn_r = value;
            }
        }

    }
}
