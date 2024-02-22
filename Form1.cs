namespace windowsForm;

public partial class Form1 : Form
{
    formulario formulario;
    consulta consulta;
    public Form1()
    {
        InitializeComponent();
        formulario = new formulario();
        // agregamos el segundo formulario llamado consulta.cs
        consulta = new consulta();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        formulario.ShowDialog();
    }

    private void Consultabtn_Click(object sender, EventArgs e)
    {
        consulta.ShowDialog();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}
