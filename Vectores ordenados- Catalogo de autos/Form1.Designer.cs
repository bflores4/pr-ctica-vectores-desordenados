namespace Vectores_ordenados__Catalogo_de_autos
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
            this.btnListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtAutosParaMostrar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTamañoCatalogo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreaCatalogo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtPlacaBuscar = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtPlacaBorrar = new System.Windows.Forms.TextBox();
            this.txtPosicionInsertar = new System.Windows.Forms.TextBox();
            this.lblnota = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(376, 7);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(105, 32);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(100, 27);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(160, 26);
            this.txtPlaca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Año";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(100, 60);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(160, 26);
            this.txtMarca.TabIndex = 7;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(100, 93);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(160, 26);
            this.txtModelo.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(100, 125);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(160, 26);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(100, 157);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(160, 26);
            this.txtAño.TabIndex = 10;
            // 
            // txtAutosParaMostrar
            // 
            this.txtAutosParaMostrar.Location = new System.Drawing.Point(16, 231);
            this.txtAutosParaMostrar.Multiline = true;
            this.txtAutosParaMostrar.Name = "txtAutosParaMostrar";
            this.txtAutosParaMostrar.ReadOnly = true;
            this.txtAutosParaMostrar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAutosParaMostrar.Size = new System.Drawing.Size(465, 211);
            this.txtAutosParaMostrar.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(280, 7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(76, 32);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTamañoCatalogo
            // 
            this.txtTamañoCatalogo.Location = new System.Drawing.Point(531, 30);
            this.txtTamañoCatalogo.Name = "txtTamañoCatalogo";
            this.txtTamañoCatalogo.Size = new System.Drawing.Size(90, 26);
            this.txtTamañoCatalogo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tamaño del catalógo";
            // 
            // btnCreaCatalogo
            // 
            this.btnCreaCatalogo.Location = new System.Drawing.Point(512, 66);
            this.btnCreaCatalogo.Name = "btnCreaCatalogo";
            this.btnCreaCatalogo.Size = new System.Drawing.Size(135, 33);
            this.btnCreaCatalogo.TabIndex = 15;
            this.btnCreaCatalogo.Text = "Crear catalógo";
            this.btnCreaCatalogo.UseVisualStyleBackColor = true;
            this.btnCreaCatalogo.Click += new System.EventHandler(this.btnCreaCatslogo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(280, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 31);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(280, 118);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(76, 31);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtPlacaBuscar
            // 
            this.txtPlacaBuscar.Location = new System.Drawing.Point(362, 63);
            this.txtPlacaBuscar.Name = "txtPlacaBuscar";
            this.txtPlacaBuscar.Size = new System.Drawing.Size(119, 26);
            this.txtPlacaBuscar.TabIndex = 18;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(280, 177);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(76, 31);
            this.btnInsertar.TabIndex = 19;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtPlacaBorrar
            // 
            this.txtPlacaBorrar.Location = new System.Drawing.Point(362, 118);
            this.txtPlacaBorrar.Name = "txtPlacaBorrar";
            this.txtPlacaBorrar.Size = new System.Drawing.Size(119, 26);
            this.txtPlacaBorrar.TabIndex = 20;
            // 
            // txtPosicionInsertar
            // 
            this.txtPosicionInsertar.Location = new System.Drawing.Point(362, 177);
            this.txtPosicionInsertar.Name = "txtPosicionInsertar";
            this.txtPosicionInsertar.Size = new System.Drawing.Size(119, 26);
            this.txtPosicionInsertar.TabIndex = 21;
            // 
            // lblnota
            // 
            this.lblnota.AutoSize = true;
            this.lblnota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota.Location = new System.Drawing.Point(327, 208);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(188, 15);
            this.lblnota.TabIndex = 22;
            this.lblnota.Text = "(Las posiciones comienzan en 0)";
            this.lblnota.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 458);
            this.Controls.Add(this.lblnota);
            this.Controls.Add(this.txtPosicionInsertar);
            this.Controls.Add(this.txtPlacaBorrar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtPlacaBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCreaCatalogo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTamañoCatalogo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtAutosParaMostrar);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtAutosParaMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTamañoCatalogo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreaCatalogo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtPlacaBuscar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtPlacaBorrar;
        private System.Windows.Forms.TextBox txtPosicionInsertar;
        private System.Windows.Forms.Label lblnota;
    }
}

