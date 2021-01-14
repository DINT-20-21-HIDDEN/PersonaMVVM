using System.Collections.ObjectModel;

namespace PersonaMVVM
{
    internal class ServicioPersona
    {
        internal ObservableCollection<Persona> ObtenerPersonas()
        {
            return new ObservableCollection<Persona>
            {
            new Persona("Pedro",32),
            new Persona("Ana",25),
            new Persona("Clara",28)
            };
        }
    }
}