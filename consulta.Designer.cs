namespace windowsForm
{
    partial class consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consulta));
            databtn = new Button();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            papellido = new DataGridViewTextBoxColumn();
            sapellido = new DataGridViewTextBoxColumn();
            provin = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // databtn
            // 
            databtn.AutoSize = true;
            databtn.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            databtn.Location = new Point(281, 299);
            databtn.Name = "databtn";
            databtn.Size = new Size(112, 33);
            databtn.TabIndex = 0;
            databtn.Text = "Cargar Datos";
            databtn.UseVisualStyleBackColor = true;
            databtn.Click += databtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, papellido, sapellido, provin });
            dataGridView1.Location = new Point(115, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(458, 259);
            dataGridView1.TabIndex = 2;
            // 
            // name
            // 
            name.HeaderText = "Nombre";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // papellido
            // 
            papellido.HeaderText = "Primer Apellido";
            papellido.Name = "papellido";
            papellido.ReadOnly = true;
            // 
            // sapellido
            // 
            sapellido.HeaderText = "Segundo Apellido";
            sapellido.Name = "sapellido";
            sapellido.ReadOnly = true;
            // 
            // provin
            // 
            provin.HeaderText = "Provincia";
            provin.Name = "provin";
            provin.ReadOnly = true;
            // 
            // consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(688, 418);
            Controls.Add(dataGridView1);
            Controls.Add(databtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "consulta";
            Text = "consulta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button databtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn papellido;
        private DataGridViewTextBoxColumn sapellido;
        private DataGridViewTextBoxColumn provin;
    }
}