using System.ComponentModel;

namespace PersonaMVVM
{
    class Persona : INotifyPropertyChanged
    {
        public string Nombre { get; set; }
        public int? Edad { get; set; }

        public Persona()
        {
            Nombre = "";
            Edad = null;
        }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
