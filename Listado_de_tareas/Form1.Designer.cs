namespace Listado_de_tareas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEntrada = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.btnMartes = new System.Windows.Forms.CheckBox();
            this.btnMiercoles = new System.Windows.Forms.CheckBox();
            this.btnViernes = new System.Windows.Forms.CheckBox();
            this.btnLunes = new System.Windows.Forms.CheckBox();
            this.btnJueves = new System.Windows.Forms.CheckBox();
            this.btnSabado = new System.Windows.Forms.CheckBox();
            this.btnDomingo = new System.Windows.Forms.CheckBox();
            this.btnTimpo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Listado_de_tareas.Properties.Resources.imagen2;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEntrada.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Location = new System.Drawing.Point(46, 474);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(219, 29);
            this.btnEntrada.TabIndex = 12;
            this.btnEntrada.TextChanged += new System.EventHandler(this.btnEntrada_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(280, 474);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 30);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.White;
            this.titulo.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(116, 52);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(209, 32);
            this.titulo.TabIndex = 14;
            this.titulo.Text = "Lista de Tareas";
            // 
            // btnMartes
            // 
            this.btnMartes.AutoSize = true;
            this.btnMartes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMartes.Location = new System.Drawing.Point(133, 384);
            this.btnMartes.Name = "btnMartes";
            this.btnMartes.Size = new System.Drawing.Size(58, 17);
            this.btnMartes.TabIndex = 15;
            this.btnMartes.Text = "Martes";
            this.btnMartes.UseVisualStyleBackColor = false;
            // 
            // btnMiercoles
            // 
            this.btnMiercoles.AutoSize = true;
            this.btnMiercoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMiercoles.Location = new System.Drawing.Point(197, 384);
            this.btnMiercoles.Name = "btnMiercoles";
            this.btnMiercoles.Size = new System.Drawing.Size(71, 17);
            this.btnMiercoles.TabIndex = 16;
            this.btnMiercoles.Text = "Miercoles";
            this.btnMiercoles.UseVisualStyleBackColor = false;
            this.btnMiercoles.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnViernes
            // 
            this.btnViernes.AutoSize = true;
            this.btnViernes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnViernes.Location = new System.Drawing.Point(133, 413);
            this.btnViernes.Name = "btnViernes";
            this.btnViernes.Size = new System.Drawing.Size(61, 17);
            this.btnViernes.TabIndex = 17;
            this.btnViernes.Text = "Viernes";
            this.btnViernes.UseVisualStyleBackColor = false;
            // 
            // btnLunes
            // 
            this.btnLunes.AutoSize = true;
            this.btnLunes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLunes.Location = new System.Drawing.Point(64, 384);
            this.btnLunes.Name = "btnLunes";
            this.btnLunes.Size = new System.Drawing.Size(55, 17);
            this.btnLunes.TabIndex = 18;
            this.btnLunes.Text = "Lunes";
            this.btnLunes.UseVisualStyleBackColor = false;
            // 
            // btnJueves
            // 
            this.btnJueves.AutoSize = true;
            this.btnJueves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnJueves.Location = new System.Drawing.Point(64, 413);
            this.btnJueves.Name = "btnJueves";
            this.btnJueves.Size = new System.Drawing.Size(60, 17);
            this.btnJueves.TabIndex = 19;
            this.btnJueves.Text = "Jueves";
            this.btnJueves.UseVisualStyleBackColor = false;
            // 
            // btnSabado
            // 
            this.btnSabado.AutoSize = true;
            this.btnSabado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSabado.Location = new System.Drawing.Point(64, 436);
            this.btnSabado.Name = "btnSabado";
            this.btnSabado.Size = new System.Drawing.Size(63, 17);
            this.btnSabado.TabIndex = 20;
            this.btnSabado.Text = "Sabado";
            this.btnSabado.UseVisualStyleBackColor = false;
            // 
            // btnDomingo
            // 
            this.btnDomingo.AutoSize = true;
            this.btnDomingo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDomingo.Location = new System.Drawing.Point(133, 436);
            this.btnDomingo.Name = "btnDomingo";
            this.btnDomingo.Size = new System.Drawing.Size(68, 17);
            this.btnDomingo.TabIndex = 21;
            this.btnDomingo.Text = "Domingo";
            this.btnDomingo.UseVisualStyleBackColor = false;
            // 
            // btnTimpo
            // 
            this.btnTimpo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimpo.Location = new System.Drawing.Point(270, 433);
            this.btnTimpo.Name = "btnTimpo";
            this.btnTimpo.Size = new System.Drawing.Size(100, 26);
            this.btnTimpo.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Hora y minuto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 563);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimpo);
            this.Controls.Add(this.btnDomingo);
            this.Controls.Add(this.btnSabado);
            this.Controls.Add(this.btnJueves);
            this.Controls.Add(this.btnLunes);
            this.Controls.Add(this.btnViernes);
            this.Controls.Add(this.btnMiercoles);
            this.Controls.Add(this.btnMartes);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox btnEntrada;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.CheckBox btnMartes;
        private System.Windows.Forms.CheckBox btnMiercoles;
        private System.Windows.Forms.CheckBox btnViernes;
        private System.Windows.Forms.CheckBox btnLunes;
        private System.Windows.Forms.CheckBox btnJueves;
        private System.Windows.Forms.CheckBox btnSabado;
        private System.Windows.Forms.CheckBox btnDomingo;
        private System.Windows.Forms.TextBox btnTimpo;
        private System.Windows.Forms.Label label1;
    }
}

