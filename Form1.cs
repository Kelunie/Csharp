namespace windowsForm;

public partial class Form1 : Form
{
    formulario formulario;
<<<<<<< HEAD
    consulta consulta;
=======
>>>>>>> ea200156653cf5bc768ba6ce511ed86e905855e9
    public Form1()
    {
        InitializeComponent();
        formulario = new formulario();
<<<<<<< HEAD
        // agregamos el segundo formulario llamado consulta.cs
        consulta = new consulta();
=======
>>>>>>> ea200156653cf5bc768ba6ce511ed86e905855e9
    }

    private void button1_Click(object sender, EventArgs e)
    {
        formulario.ShowDialog();
    }

    private void Consultabtn_Click(object sender, EventArgs e)
    {
<<<<<<< HEAD
        consulta.ShowDialog();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
=======
>>>>>>> ea200156653cf5bc768ba6ce511ed86e905855e9

    }
}
