namespace windowsForm
{
    partial class formulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulario));
=======
>>>>>>> ea200156653cf5bc768ba6ce511ed86e905855e9
            NameFormulario = new Label();
            FLname = new Label();
            SLname = new Label();
            provincia = new Label();
            provinciacombobox = new ComboBox();
            nametxt = new TextBox();
            FLnametxt = new TextBox();
            SLnametxt = new TextBox();
            addbtn = new Button();
            savebtn = new Button();
            SuspendLayout();
            // 
            // NameFormulario
            // 
            NameFormulario.AutoSize = true;
<<<<<<< HEAD
            NameFormulario.BackColor = Color.Transparent;
            NameFormulario.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameFormulario.ForeColor = Color.Black;
            NameFormulario.Location = new Point(25, 34);
            NameFormulario.Name = "NameFormulario";
            NameFormulario.Size = new Size(62, 23);
=======
            NameFormulario.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameFormulario.Location = new Point(25, 34);
            NameFormulario.Name = "NameFormulario";
            NameFormulario.Size = new Size(60, 23);
>>>>>>> ea200156653cf5bc768ba6ce511ed86e905855e9
            NameFormulario.TabIndex = 0;
            NameFormulario.Text = "Name :";
            // 
            // FLname
            // 
            FLname.AutoSize = true;
<<<<<<< HEAD
            FLname.BackColor = Color.Transparent;
            FLname.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FLname.Location = new Point(25, 99);
            FLname.Name = "FLname";
            FLname.Size = new Size(137, 23);
=======
            FLname.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FLname.Location = new Point(25, 99);
            FLname.Name = "FLname";
            FLname.Size = new Size(126, 23);
>>>>>>> ea200156653cf5bc768ba6ce511ed86e905855e9
            FLname.TabIndex = 1;
            FLname.Text = "First Last Name :";
            // 
            // SLname
            // 
            SLname.AutoSize = true;
<<<<<<< HEAD
            SLname.BackColor = Color.Transparent;
            SLname.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SLname.Location = new Point(25, 165);
            SLname.Name = "SLname";
            SLname.Size = new Size(157, 23);
=======
            SLname.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SLname.Location = new Point(25, 165);
            SLname.Name = "SLname";
            SLname.Size = new Size(147, 23);
>>>>>>> ea200156653cf5bc768ba6ce511ed86e905855e9
            SLname.TabIndex = 2;
            SLname.Text = "Second Last Name:";
            // 
            // provincia
            // 
            provincia.AutoSize = true;
<<<<<<< HEAD
            provincia.BackColor = Color.Transparent;
            provincia.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            provincia.Location = new Point(25, 220);
            provincia.Name = "provincia";
            provincia.Size = new Size(90, 23);
=======
            provincia.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            provincia.Location = new Point(25, 220);
            provincia.Name = "provincia";
            provincia.Size = new Size(81, 23);
>>>>>>> ea200156653cf5bc768ba6ce511ed86e905855e9
            provincia.TabIndex = 3;
            provincia.Text = "Provincia :";
            // 
            // provinciacombobox
            // 
            provinciacombobox.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            provinciacombobox.FormattingEnabled = true;
            provinciacombobox.Items.AddRange(new object[] { "San Jose", "Alajuela", "Puntarenas", "Cartago", "Heredia", "Guanacaste", "Limón", "Extranjero" });
            provinciacombobox.Location = new Point(200, 220);
            provinciacombobox.Name = "provinciacombobox";
            provinciacombobox.Size = new Size(158, 31);
            provinciacombobox.TabIndex = 4;
            // 
            // nametxt
            // 
            nametxt.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nametxt.Location = new Point(200, 28);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(158, 29);
            nametxt.TabIndex = 5;
            // 
            // FLnametxt
            // 
            FLnametxt.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FLnametxt.Location = new Point(200, 93);
            FLnametxt.Name = "FLnametxt";
            FLnametxt.Size = new Size(158, 29);
            FLnametxt.TabIndex = 6;
            // 
            // SLnametxt
            // 
            SLnametxt.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SLnametxt.Location = new Point(200, 159);
            SLnametxt.Name = "SLnametxt";
            SLnametxt.Size = new Size(158, 29);
            SLnametxt.TabIndex = 7;
            // 
            // addbtn
            // 
            addbtn.AutoSize = true;
            addbtn.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addbtn.Location = new Point(76, 302);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(75, 33);
            addbtn.TabIndex = 8;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // savebtn
            // 
            savebtn.AutoSize = true;
            savebtn.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            savebtn.Location = new Point(238, 302);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(75, 33);
            savebtn.TabIndex = 9;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // formulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            BackgroundImage = Properties.Resources.background2;
            BackgroundImageLayout = ImageLayout.Stretch;
=======
>>>>>>> ea200156653cf5bc768ba6ce511ed86e905855e9
            ClientSize = new Size(393, 367);
            Controls.Add(savebtn);
            Controls.Add(addbtn);
            Controls.Add(SLnametxt);
            Controls.Add(FLnametxt);
            Controls.Add(nametxt);
            Controls.Add(provinciacombobox);
            Controls.Add(provincia);
            Controls.Add(SLname);
            Controls.Add(FLname);
            Controls.Add(NameFormulario);
<<<<<<< HEAD
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
=======
>>>>>>> ea200156653cf5bc768ba6ce511ed86e905855e9
            Name = "formulario";
            Text = "formulario";
            Load += formulario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameFormulario;
        private Label FLname;
        private Label SLname;
        private Label provincia;
        private ComboBox provinciacombobox;
        private TextBox nametxt;
        private TextBox FLnametxt;
        private TextBox SLnametxt;
        private Button addbtn;
        private Button savebtn;
    }
}