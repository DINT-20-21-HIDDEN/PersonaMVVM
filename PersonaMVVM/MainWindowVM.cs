using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PersonaMVVM
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public Persona NuevaPersona { get; set; }
        public Persona PersonaSeleccionada { get; set; }
        public ObservableCollection<Persona> ListaPersonas { get; set; }
        private ServicioPersona _servicio;

        public MainWindowVM()
        {
            _servicio = new ServicioPersona();
            NuevaPersona = new Persona();
            ListaPersonas = _servicio.ObtenerPersonas();
        }

        public bool ComprobarNuevaPersona()
        {
            if (NuevaPersona.Edad != null && NuevaPersona.Nombre != "")
                return true;
            else
                return false;
        }

        public bool HayDatos()
        {
            if (NuevaPersona.Edad != null || NuevaPersona.Nombre != "")
                return true;
            else
                return false;
        }

        public void AñadirPersona()
        {
            ListaPersonas.Add(NuevaPersona);
            NuevaPersona = new Persona();
        }

        public void VaciarPersona()
        {
            NuevaPersona = new Persona();
        }

        public void EliminarPersona()
        {
            ListaPersonas.Remove(PersonaSeleccionada);
        }

        public bool HayPersonaSeleccionada()
        {
            return PersonaSeleccionada != null;
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
