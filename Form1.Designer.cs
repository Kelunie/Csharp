namespace windowsForm;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
<<<<<<< HEAD
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
=======
>>>>>>> ea200156653cf5bc768ba6ce511ed86e905855e9
        Formulariobtn = new Button();
        Consultabtn = new Button();
        SuspendLayout();
        // 
        // Formulariobtn
        // 
        Formulariobtn.Location = new Point(78, 43);
        Formulariobtn.Name = "Formulariobtn";
        Formulariobtn.Size = new Size(111, 32);
        Formulariobtn.TabIndex = 0;
        Formulariobtn.Text = "Formulario";
        Formulariobtn.UseVisualStyleBackColor = true;
        Formulariobtn.Click += button1_Click;
        // 
        // Consultabtn
        // 
        Consultabtn.Location = new Point(78, 139);
        Consultabtn.Name = "Consultabtn";
        Consultabtn.Size = new Size(111, 32);
        Consultabtn.TabIndex = 1;
        Consultabtn.Text = "Consulta";
        Consultabtn.UseVisualStyleBackColor = true;
        Consultabtn.Click += Consultabtn_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
        BackgroundImage = Properties.Resources.background1;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(269, 232);
        Controls.Add(Consultabtn);
        Controls.Add(Formulariobtn);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "Form1";
        Text = "Windows Form con C#";
        Load += Form1_Load;
=======
        ClientSize = new Size(269, 232);
        Controls.Add(Consultabtn);
        Controls.Add(Formulariobtn);
        Name = "Form1";
        Text = "Windows Form con C#";
>>>>>>> ea200156653cf5bc768ba6ce511ed86e905855e9
        ResumeLayout(false);
    }

    #endregion

    private Button Formulariobtn;
    private Button Consultabtn;
}
