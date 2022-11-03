namespace ListaSE
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_insertar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_siguiente = new System.Windows.Forms.Button();
            this.button_Ultimo = new System.Windows.Forms.Button();
            this.button_anterior = new System.Windows.Forms.Button();
            this.button_primero = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Controls.Add(this.button_eliminar);
            this.panel3.Controls.Add(this.button_insertar);
            this.panel3.Location = new System.Drawing.Point(179, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(657, 102);
            this.panel3.TabIndex = 27;
            // 
            // button_eliminar
            // 
            this.button_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.Location = new System.Drawing.Point(406, 22);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(159, 59);
            this.button_eliminar.TabIndex = 3;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_insertar
            // 
            this.button_insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insertar.Location = new System.Drawing.Point(101, 22);
            this.button_insertar.Name = "button_insertar";
            this.button_insertar.Size = new System.Drawing.Size(159, 59);
            this.button_insertar.TabIndex = 0;
            this.button_insertar.Text = "Insertar";
            this.button_insertar.UseVisualStyleBackColor = true;
            this.button_insertar.Click += new System.EventHandler(this.button_insertar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.button_siguiente);
            this.panel2.Controls.Add(this.button_Ultimo);
            this.panel2.Controls.Add(this.button_anterior);
            this.panel2.Controls.Add(this.button_primero);
            this.panel2.Location = new System.Drawing.Point(147, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 98);
            this.panel2.TabIndex = 26;
            // 
            // button_siguiente
            // 
            this.button_siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_siguiente.Location = new System.Drawing.Point(362, 17);
            this.button_siguiente.Name = "button_siguiente";
            this.button_siguiente.Size = new System.Drawing.Size(159, 59);
            this.button_siguiente.TabIndex = 6;
            this.button_siguiente.Text = "Siguiente";
            this.button_siguiente.UseVisualStyleBackColor = true;
            this.button_siguiente.Click += new System.EventHandler(this.button_siguiente_Click);
            // 
            // button_Ultimo
            // 
            this.button_Ultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ultimo.Location = new System.Drawing.Point(32, 17);
            this.button_Ultimo.Name = "button_Ultimo";
            this.button_Ultimo.Size = new System.Drawing.Size(159, 59);
            this.button_Ultimo.TabIndex = 7;
            this.button_Ultimo.Text = "Ultimo";
            this.button_Ultimo.UseVisualStyleBackColor = true;
            this.button_Ultimo.Click += new System.EventHandler(this.button_Ultimo_Click);
            // 
            // button_anterior
            // 
            this.button_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_anterior.Location = new System.Drawing.Point(530, 17);
            this.button_anterior.Name = "button_anterior";
            this.button_anterior.Size = new System.Drawing.Size(159, 59);
            this.button_anterior.TabIndex = 5;
            this.button_anterior.Text = "Anterior";
            this.button_anterior.UseVisualStyleBackColor = true;
            this.button_anterior.Click += new System.EventHandler(this.button_anterior_Click);
            // 
            // button_primero
            // 
            this.button_primero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_primero.Location = new System.Drawing.Point(197, 17);
            this.button_primero.Name = "button_primero";
            this.button_primero.Size = new System.Drawing.Size(159, 59);
            this.button_primero.TabIndex = 4;
            this.button_primero.Text = "Primero";
            this.button_primero.UseVisualStyleBackColor = true;
            this.button_primero.Click += new System.EventHandler(this.button_primero_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 45);
            this.label3.TabIndex = 24;
            this.label3.Text = "Lista de Asignaturas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cantidad de Horas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre de la Asignatura";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(585, 141);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 22);
            this.txtHoras.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(585, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 505);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_insertar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_siguiente;
        private System.Windows.Forms.Button button_Ultimo;
        private System.Windows.Forms.Button button_anterior;
        private System.Windows.Forms.Button button_primero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

