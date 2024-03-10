namespace WinDuplicados;

public static class Misc
{
    public static string DevuelveDirectorio(string titulo)
    {
        using FolderBrowserDialog dialogoDirectorio = new();

        // Establecer propiedades del cuadro de diálogo
        dialogoDirectorio.Description = titulo;
        dialogoDirectorio.RootFolder = Environment.SpecialFolder.MyComputer;
        dialogoDirectorio.UseDescriptionForTitle = true;
        
        // Mostrar el cuadro de diálogo y comprobar si se hizo clic en "Aceptar"
        DialogResult resultado = dialogoDirectorio.ShowDialog();

        if (resultado == DialogResult.OK)
            return dialogoDirectorio.SelectedPath;
        return "";
    }

}
