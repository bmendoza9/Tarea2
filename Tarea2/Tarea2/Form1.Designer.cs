namespace Tarea2
{
    partial class Tarea2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_mostrarBMP = new System.Windows.Forms.TextBox();
            this.button_BMP = new System.Windows.Forms.Button();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_lugar = new System.Windows.Forms.TextBox();
            this.textBox_numtf = new System.Windows.Forms.TextBox();
            this.textBox_fecha = new System.Windows.Forms.TextBox();
            this.textBox_motivo = new System.Windows.Forms.TextBox();
            this.button_agendar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un archivo BMP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lugar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Motivo";
            // 
            // textBox_mostrarBMP
            // 
            this.textBox_mostrarBMP.Location = new System.Drawing.Point(104, 54);
            this.textBox_mostrarBMP.Multiline = true;
            this.textBox_mostrarBMP.Name = "textBox_mostrarBMP";
            this.textBox_mostrarBMP.Size = new System.Drawing.Size(100, 55);
            this.textBox_mostrarBMP.TabIndex = 6;
            // 
            // button_BMP
            // 
            this.button_BMP.Location = new System.Drawing.Point(117, 25);
            this.button_BMP.Name = "button_BMP";
            this.button_BMP.Size = new System.Drawing.Size(75, 23);
            this.button_BMP.TabIndex = 7;
            this.button_BMP.Text = "Seleccionar";
            this.button_BMP.UseVisualStyleBackColor = true;
            this.button_BMP.Click += new System.EventHandler(this.button_BMP_Click);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(104, 153);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 8;
            // 
            // textBox_lugar
            // 
            this.textBox_lugar.Location = new System.Drawing.Point(104, 180);
            this.textBox_lugar.Name = "textBox_lugar";
            this.textBox_lugar.Size = new System.Drawing.Size(100, 20);
            this.textBox_lugar.TabIndex = 9;
            // 
            // textBox_numtf
            // 
            this.textBox_numtf.Location = new System.Drawing.Point(104, 206);
            this.textBox_numtf.Name = "textBox_numtf";
            this.textBox_numtf.Size = new System.Drawing.Size(100, 20);
            this.textBox_numtf.TabIndex = 10;
            // 
            // textBox_fecha
            // 
            this.textBox_fecha.Location = new System.Drawing.Point(104, 234);
            this.textBox_fecha.Name = "textBox_fecha";
            this.textBox_fecha.Size = new System.Drawing.Size(100, 20);
            this.textBox_fecha.TabIndex = 11;
            // 
            // textBox_motivo
            // 
            this.textBox_motivo.Location = new System.Drawing.Point(104, 260);
            this.textBox_motivo.Name = "textBox_motivo";
            this.textBox_motivo.Size = new System.Drawing.Size(100, 20);
            this.textBox_motivo.TabIndex = 12;
            // 
            // button_agendar
            // 
            this.button_agendar.Location = new System.Drawing.Point(117, 286);
            this.button_agendar.Name = "button_agendar";
            this.button_agendar.Size = new System.Drawing.Size(75, 23);
            this.button_agendar.TabIndex = 13;
            this.button_agendar.Text = "Agendar";
            this.button_agendar.UseVisualStyleBackColor = true;
            this.button_agendar.Click += new System.EventHandler(this.button_agendar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Tarea2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 351);
            this.Controls.Add(this.button_agendar);
            this.Controls.Add(this.textBox_motivo);
            this.Controls.Add(this.textBox_fecha);
            this.Controls.Add(this.textBox_numtf);
            this.Controls.Add(this.textBox_lugar);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.button_BMP);
            this.Controls.Add(this.textBox_mostrarBMP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tarea2";
            this.Text = "Tarea2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_mostrarBMP;
        private System.Windows.Forms.Button button_BMP;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_lugar;
        private System.Windows.Forms.TextBox textBox_numtf;
        private System.Windows.Forms.TextBox textBox_fecha;
        private System.Windows.Forms.TextBox textBox_motivo;
        private System.Windows.Forms.Button button_agendar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

