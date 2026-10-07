using Codice.Registro;
namespace Codice.App;

public partial class Form1 : Form
{
    private readonly List<Estudiante> estudiantes = new List<Estudiante>();
    public Form1()  
    {
        InitializeComponent();
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
}
