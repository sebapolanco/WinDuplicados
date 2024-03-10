

using System.Diagnostics;

namespace WinDuplicados;

public partial class Principal : Form
{
    public Principal()
    {
        InitializeComponent();
        Iniciar();
    }

    private void Iniciar()
    {
        // Configura propiedas de las listview
        ListaArchivos.View = View.Details;
        ListaArchivos.GridLines = true;
        ListaArchivos.FullRowSelect = true;
        ListaUbicaciones.View = View.Details;
        ListaUbicaciones.GridLines = true;
        ListaUbicaciones.FullRowSelect = true;

        //Asignar columnas a cada uno de ellos
        AgregaColumna(ListaArchivos, "ID", 5);
        AgregaColumna(ListaArchivos, "ARCHIVO", 20);
        AgregaColumna(ListaArchivos, "LARGO", 5);

        AgregaColumna(ListaUbicaciones, "ARCHIVO", 20);
        AgregaColumna(ListaUbicaciones, "DIRECTORIO", 30);

        //Crea y configura menú contextual
        ContextMenuStrip menu = new();
        ToolStripMenuItem item = new("Abrir el explorador en Windows");
        item.Click += ComandoAbrirExplorador_Click;
        menu.Items.Add(item);

        //Asignar el menú contextual al objeto de tipo listview llamado ListaUbicaciones
        ListaUbicaciones.ContextMenuStrip = menu;

    }

    private void ComandoAbrirExplorador_Click(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void AgregaColumna(ListView lvw, string nombre, int largo, bool esNumero = false)
    {
        ColumnHeader ch = new() { Text = nombre, Width = largo * 10, TextAlign = HorizontalAlignment.Center };
        if (esNumero)
            ch.TextAlign = HorizontalAlignment.Right;
        else
            ch.TextAlign = HorizontalAlignment.Left;
        lvw.Columns.Add(ch);
    }

    private void BUSCAR_Click(object sender, EventArgs e)
    {
        string dir = Misc.DevuelveDirectorio("SELECCIONE DIRECTORIO A ANALIZAR");
        if (!string.IsNullOrWhiteSpace(dir))
        {
            if (Directory.Exists(dir))
            {
                Directorio.Text = dir;
                Buscar.Enabled = false;
                Cursor = Cursors.WaitCursor;
                AnalizarDirectorio(dir);
                Cursor = Cursors.Default;
                Buscar.Enabled = true;
            }
            else
                MessageBox.Show("Ese directorio no existe", "Error");
        }
    }

    private void AnalizarDirectorio(string dir)
    {
       
        Mensaje.Text = "";
        var reloj = new Stopwatch();
        reloj.Start();
        resultado = await Task.Run(() => Analiza(DirectorioA.Text));
        MostrarResultado();
        reloj.Stop();
        TimeSpan tt = reloj.Elapsed;
        Mensaje.Text += ". Tiempo: " + tt.ToString(@"m\:ss\.fff");
        
        MessageBox.Show("Análisis terminado");

    }
}
