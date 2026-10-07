using Codice.Registro;
using System.Globalization;
namespace Codice.App;

public partial class Form1 : Form
{
    private readonly List<Estudiante> estudiantes = new List<Estudiante>();

    private readonly List<Asignatura> asignaturas = new List<Asignatura>
    {
        new Asignatura("PRO205", "Taller de Programación"),
        new Asignatura("BDD101", "Base de Datos"),
        new Asignatura("MAT101", "Matemática")
    };
    public Form1()
    {
        InitializeComponent();

        foreach (var asignatura in asignaturas)
        {
            cmbAsignatura.Items.Add(asignatura.Nombre);
        }
    }
    private void btnAgregarEstudiante_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtRut.Text) ||
            string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text))
        {
            MessageBox.Show("Completa RUT, nombre y email.");
            return;
        }

        var estudiante = new Estudiante(txtRut.Text, txtNombre.Text, txtEmail.Text);
        estudiantes.Add(estudiante);
        lstEstudiantes.Items.Add($"{estudiante.Rut} - {estudiante.Nombre}");

        txtRut.Clear();
        txtNombre.Clear();
        txtEmail.Clear();
    }

    private void btnAgregarNota_Click(object sender, EventArgs e)
    {
        if (lstEstudiantes.SelectedIndex == -1)
        {
            MessageBox.Show("Selecciona un estudiante de la lista.");
            return;
        }
        if (cmbAsignatura.SelectedIndex == -1)
        {
            MessageBox.Show("Selecciona una asignatura.");
            return;
        }
        string textoNota = txtNota.Text.Replace(',', '.');
        if (!double.TryParse(textoNota, NumberStyles.Number, CultureInfo.InvariantCulture, out double valor))
        {
            MessageBox.Show("La nota debe ser un número, por ejemplo 6,5.");
            return;
        }
        var estudiante = estudiantes[lstEstudiantes.SelectedIndex];
        var asignatura = asignaturas[cmbAsignatura.SelectedIndex];
        var calificacion = new Calificacion(valor, DateTime.Today, asignatura);
        if (!calificacion.EsValida())
        {
            MessageBox.Show("La nota debe estar entre 1,0 y 7,0.");
            return;
        }
        estudiante.AgregarCalificacion(calificacion);
        MessageBox.Show($"Nota {valor:0.0} registrada para {estudiante.Nombre} en {asignatura.Nombre}.");
        txtNota.Clear();
    }
}
