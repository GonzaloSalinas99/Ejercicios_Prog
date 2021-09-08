
namespace frmRegistro
{
    partial class frmRegistro
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
            this.gbDetallesUsuario = new System.Windows.Forms.GroupBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbNoBinario = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.gbCursos = new System.Windows.Forms.GroupBox();
            this.cbCurso3 = new System.Windows.Forms.CheckBox();
            this.cbCurso2 = new System.Windows.Forms.CheckBox();
            this.cbCurso1 = new System.Windows.Forms.CheckBox();
            this.lbPais = new System.Windows.Forms.ListBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gbDetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.gbGenero.SuspendLayout();
            this.gbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetallesUsuario
            // 
            this.gbDetallesUsuario.Controls.Add(this.numEdad);
            this.gbDetallesUsuario.Controls.Add(this.textDireccion);
            this.gbDetallesUsuario.Controls.Add(this.textNombre);
            this.gbDetallesUsuario.Controls.Add(this.lblEdad);
            this.gbDetallesUsuario.Controls.Add(this.lblDireccion);
            this.gbDetallesUsuario.Controls.Add(this.lblNombre);
            this.gbDetallesUsuario.Location = new System.Drawing.Point(25, 40);
            this.gbDetallesUsuario.Name = "gbDetallesUsuario";
            this.gbDetallesUsuario.Size = new System.Drawing.Size(242, 166);
            this.gbDetallesUsuario.TabIndex = 0;
            this.gbDetallesUsuario.TabStop = false;
            this.gbDetallesUsuario.Text = "Detalles del usuario";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(115, 106);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(100, 23);
            this.numEdad.TabIndex = 5;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(115, 67);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(100, 23);
            this.textDireccion.TabIndex = 4;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(115, 31);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 23);
            this.textNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(16, 115);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(16, 75);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbNoBinario);
            this.gbGenero.Controls.Add(this.rbFemenino);
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Location = new System.Drawing.Point(369, 40);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(191, 110);
            this.gbGenero.TabIndex = 1;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Género";
            // 
            // rbNoBinario
            // 
            this.rbNoBinario.AutoSize = true;
            this.rbNoBinario.Location = new System.Drawing.Point(18, 81);
            this.rbNoBinario.Name = "rbNoBinario";
            this.rbNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rbNoBinario.TabIndex = 2;
            this.rbNoBinario.TabStop = true;
            this.rbNoBinario.Text = "No Binario";
            this.rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(18, 56);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(18, 31);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // gbCursos
            // 
            this.gbCursos.Controls.Add(this.cbCurso3);
            this.gbCursos.Controls.Add(this.cbCurso2);
            this.gbCursos.Controls.Add(this.cbCurso1);
            this.gbCursos.Location = new System.Drawing.Point(369, 222);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Size = new System.Drawing.Size(191, 121);
            this.gbCursos.TabIndex = 2;
            this.gbCursos.TabStop = false;
            this.gbCursos.Text = "Cursos";
            // 
            // cbCurso3
            // 
            this.cbCurso3.AutoSize = true;
            this.cbCurso3.Location = new System.Drawing.Point(18, 95);
            this.cbCurso3.Name = "cbCurso3";
            this.cbCurso3.Size = new System.Drawing.Size(78, 19);
            this.cbCurso3.TabIndex = 2;
            this.cbCurso3.Text = "JavaScript";
            this.cbCurso3.UseVisualStyleBackColor = true;
            // 
            // cbCurso2
            // 
            this.cbCurso2.AutoSize = true;
            this.cbCurso2.Location = new System.Drawing.Point(18, 61);
            this.cbCurso2.Name = "cbCurso2";
            this.cbCurso2.Size = new System.Drawing.Size(50, 19);
            this.cbCurso2.TabIndex = 1;
            this.cbCurso2.Text = "C++";
            this.cbCurso2.UseVisualStyleBackColor = true;
            // 
            // cbCurso1
            // 
            this.cbCurso1.AutoSize = true;
            this.cbCurso1.Location = new System.Drawing.Point(18, 22);
            this.cbCurso1.Name = "cbCurso1";
            this.cbCurso1.Size = new System.Drawing.Size(41, 19);
            this.cbCurso1.TabIndex = 0;
            this.cbCurso1.Text = "C#";
            this.cbCurso1.UseVisualStyleBackColor = true;
            // 
            // lbPais
            // 
            this.lbPais.FormattingEnabled = true;
            this.lbPais.ItemHeight = 15;
            this.lbPais.Location = new System.Drawing.Point(25, 234);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(242, 109);
            this.lbPais.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(504, 410);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.gbCursos);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.gbDetallesUsuario);
            this.Name = "frmRegistro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDetallesUsuario.ResumeLayout(false);
            this.gbDetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbCursos.ResumeLayout(false);
            this.gbCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetallesUsuario;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.GroupBox gbCursos;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RadioButton rbNoBinario;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.CheckBox cbCurso3;
        private System.Windows.Forms.CheckBox cbCurso2;
        private System.Windows.Forms.CheckBox cbCurso1;
        private System.Windows.Forms.ListBox lbPais;
        private System.Windows.Forms.Button btnIngresar;
    }
}

