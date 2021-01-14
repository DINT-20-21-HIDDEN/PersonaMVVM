using System.Windows;
using System.Windows.Input;

namespace PersonaMVVM
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowVM _vm;
        public MainWindow()
        {
            _vm = new MainWindowVM();
            InitializeComponent();
            DataContext = _vm;
        }

        private void Eliminar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.EliminarPersona();
            MessageBox.Show("Persona eliminada con éxito", "PersonaMVVM", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Eliminar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _vm.HayPersonaSeleccionada();
        }
        private void Añadir_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.AñadirPersona();
            MessageBox.Show("Persona añadida con éxito", "PersonaMVVM", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Añadir_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _vm.ComprobarNuevaPersona();
        }

        private void Limpiar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.VaciarPersona();
        }

        private void Limpiar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _vm.HayDatos();
        }

    }
}
