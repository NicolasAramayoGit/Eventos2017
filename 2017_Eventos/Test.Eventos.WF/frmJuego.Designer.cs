﻿namespace Test.Eventos.WF
{
    partial class frmJuego
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDificultad = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.cboDificultad = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.miPanel = new System.Windows.Forms.Panel();
            this.lblExitos = new System.Windows.Forms.Label();
            this.lblFracasos = new System.Windows.Forms.Label();
            this.lblCantExitos = new System.Windows.Forms.Label();
            this.lblCantFracasos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblPista = new System.Windows.Forms.Label();
            this.miPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDificultad
            // 
            this.lblDificultad.AutoSize = true;
            this.lblDificultad.Location = new System.Drawing.Point(33, 31);
            this.lblDificultad.Name = "lblDificultad";
            this.lblDificultad.Size = new System.Drawing.Size(51, 13);
            this.lblDificultad.TabIndex = 0;
            this.lblDificultad.Text = "Dificultad";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(14, 16);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Número";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(26, 69);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "&Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.bntIniciar_Click);
            this.btnIniciar.Click += new System.EventHandler(this.otro);
            this.btnIniciar.MouseEnter += new System.EventHandler(this.btnIniciar_MouseEnter);
            // 
            // cboDificultad
            // 
            this.cboDificultad.FormattingEnabled = true;
            this.cboDificultad.Location = new System.Drawing.Point(95, 28);
            this.cboDificultad.Name = "cboDificultad";
            this.cboDificultad.Size = new System.Drawing.Size(121, 21);
            this.cboDificultad.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(76, 13);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 20);
            this.txtNumero.TabIndex = 5;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Location = new System.Drawing.Point(14, 67);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(45, 13);
            this.lblIntentos.TabIndex = 2;
            this.lblIntentos.Text = "Intentos";
            // 
            // miPanel
            // 
            this.miPanel.Controls.Add(this.lblPista);
            this.miPanel.Controls.Add(this.lblNumero);
            this.miPanel.Controls.Add(this.txtNumero);
            this.miPanel.Controls.Add(this.lblIntentos);
            this.miPanel.Location = new System.Drawing.Point(26, 140);
            this.miPanel.Name = "miPanel";
            this.miPanel.Size = new System.Drawing.Size(225, 100);
            this.miPanel.TabIndex = 6;
            // 
            // lblExitos
            // 
            this.lblExitos.AutoSize = true;
            this.lblExitos.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitos.Location = new System.Drawing.Point(20, 243);
            this.lblExitos.Name = "lblExitos";
            this.lblExitos.Size = new System.Drawing.Size(79, 33);
            this.lblExitos.TabIndex = 7;
            this.lblExitos.Text = "Éxitos";
            // 
            // lblFracasos
            // 
            this.lblFracasos.AutoSize = true;
            this.lblFracasos.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFracasos.Location = new System.Drawing.Point(160, 243);
            this.lblFracasos.Name = "lblFracasos";
            this.lblFracasos.Size = new System.Drawing.Size(99, 33);
            this.lblFracasos.TabIndex = 8;
            this.lblFracasos.Text = "Fracasos";
            // 
            // lblCantExitos
            // 
            this.lblCantExitos.AutoSize = true;
            this.lblCantExitos.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantExitos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCantExitos.Location = new System.Drawing.Point(43, 276);
            this.lblCantExitos.Name = "lblCantExitos";
            this.lblCantExitos.Size = new System.Drawing.Size(22, 25);
            this.lblCantExitos.TabIndex = 9;
            this.lblCantExitos.Text = "0";
            // 
            // lblCantFracasos
            // 
            this.lblCantFracasos.AutoSize = true;
            this.lblCantFracasos.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantFracasos.ForeColor = System.Drawing.Color.Red;
            this.lblCantFracasos.Location = new System.Drawing.Point(197, 276);
            this.lblCantFracasos.Name = "lblCantFracasos";
            this.lblCantFracasos.Size = new System.Drawing.Size(22, 25);
            this.lblCantFracasos.TabIndex = 10;
            this.lblCantFracasos.Text = "0";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(26, 98);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(152, 103);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(71, 13);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "Intentos Max.";
            // 
            // lblPista
            // 
            this.lblPista.AutoSize = true;
            this.lblPista.Location = new System.Drawing.Point(122, 67);
            this.lblPista.Name = "lblPista";
            this.lblPista.Size = new System.Drawing.Size(33, 13);
            this.lblPista.TabIndex = 12;
            this.lblPista.Text = "Pista:";
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 314);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCantFracasos);
            this.Controls.Add(this.lblCantExitos);
            this.Controls.Add(this.lblFracasos);
            this.Controls.Add(this.lblExitos);
            this.Controls.Add(this.miPanel);
            this.Controls.Add(this.cboDificultad);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblDificultad);
            this.Name = "frmJuego";
            this.Text = "Adivina el Número";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.miPanel.ResumeLayout(false);
            this.miPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDificultad;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ComboBox cboDificultad;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Panel miPanel;
        private System.Windows.Forms.Label lblExitos;
        private System.Windows.Forms.Label lblFracasos;
        private System.Windows.Forms.Label lblCantExitos;
        private System.Windows.Forms.Label lblCantFracasos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblPista;
    }
}

