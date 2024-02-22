namespace windowsForm;

public partial class Form1 : Form
{
    formulario formulario;
    public Form1()
    {
        InitializeComponent();
        formulario = new formulario();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        formulario.ShowDialog();
    }

    private void Consultabtn_Click(object sender, EventArgs e)
    {

    }
}
