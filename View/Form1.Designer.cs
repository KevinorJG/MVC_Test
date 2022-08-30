namespace View
{
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nombre = new System.Windows.Forms.ColumnHeader();
            this.Apellido = new System.Windows.Forms.ColumnHeader();
            this.Cédula = new System.Windows.Forms.ColumnHeader();
            this.Descripción = new System.Windows.Forms.ColumnHeader();
            this.Ciudad = new System.Windows.Forms.ColumnHeader();
            this.Estado = new System.Windows.Forms.ColumnHeader();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btUpdate);
            this.groupBox1.Controls.Add(this.btRegister);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(28, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(147, 138);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PlaceholderText = "Estado";
            this.txtEstado.Size = new System.Drawing.Size(115, 23);
            this.txtEstado.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(291, 137);
            this.txtCity.Name = "txtCity";
            this.txtCity.PlaceholderText = "Ciudad";
            this.txtCity.Size = new System.Drawing.Size(126, 23);
            this.txtCity.TabIndex = 7;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(470, 68);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Borrar";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(370, 92);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 5;
            this.btUpdate.Text = "Actualizar";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(370, 42);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(75, 23);
            this.btRegister.TabIndex = 4;
            this.btRegister.Text = "Registrar";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(147, 43);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "Dirección";
            this.txtDireccion.Size = new System.Drawing.Size(182, 73);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(24, 138);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.PlaceholderText = "Cédula";
            this.txtDNI.Size = new System.Drawing.Size(100, 23);
            this.txtDNI.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(24, 93);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Apellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(24, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(61, 69);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Cédula";
            this.txtSearch.Size = new System.Drawing.Size(150, 23);
            this.txtSearch.TabIndex = 4;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(98, 126);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 6;
            this.btSearch.Text = "Buscar";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(633, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 193);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Apellido,
            this.Cédula,
            this.Descripción,
            this.Ciudad,
            this.Estado});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 244);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(700, 139);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 100;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 80;
            // 
            // Cédula
            // 
            this.Cédula.Text = "Cédula";
            this.Cédula.Width = 150;
            // 
            // Descripción
            // 
            this.Descripción.Text = "Descripción";
            this.Descripción.Width = 150;
            // 
            // Ciudad
            // 
            this.Ciudad.Text = "Ciudad";
            this.Ciudad.Width = 100;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 100;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(769, 301);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "Salir";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 411);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Cédula;
        private System.Windows.Forms.ColumnHeader Descripción;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ColumnHeader Ciudad;
        private System.Windows.Forms.ColumnHeader Estado;
    }
}
