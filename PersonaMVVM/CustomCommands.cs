using System.Windows.Input;

namespace PersonaMVVM
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand Eliminar = new RoutedUICommand(
            "Eliminar","Eliminar",
            typeof(CustomCommands),
            new InputGestureCollection
            { new KeyGesture(Key.E,ModifierKeys.Control)}
            );

        public static readonly RoutedUICommand Añadir = new RoutedUICommand(
            "Añadir", "Añadir",
            typeof(CustomCommands),
            new InputGestureCollection
            { new KeyGesture(Key.A,ModifierKeys.Control)}
            );

        public static readonly RoutedUICommand Limpiar = new RoutedUICommand(
            "Limpiar", "Limpiar",
            typeof(CustomCommands),
            new InputGestureCollection
            { new KeyGesture(Key.L,ModifierKeys.Control)}
            );
    }
}
