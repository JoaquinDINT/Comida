using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> _listaPlatos;

        public ObservableCollection<Plato> ListaPlatos
        {
            get { return _listaPlatos; }
            set { if(value != _listaPlatos) {
                    _listaPlatos = value;
                    this.NotifyPropertyChanged("ListaPlatos");
                    }  
                }
        }

    public MainWindowVM()
        {
            ListaPlatos = Plato.GetSamples("assets/");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
