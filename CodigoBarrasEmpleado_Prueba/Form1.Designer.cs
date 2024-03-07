namespace CodigoBarrasEmpleado_Prueba
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tpBase = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbCodigoBarras = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbCodigoQR = new System.Windows.Forms.PictureBox();
            this.tpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoQR)).BeginInit();
            this.SuspendLayout();
            // 
            // tpBase
            // 
            this.tpBase.ColumnCount = 4;
            this.tpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 465F));
            this.tpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpBase.Controls.Add(this.label1, 0, 0);
            this.tpBase.Controls.Add(this.txtNumeroEmpleado, 1, 0);
            this.tpBase.Controls.Add(this.btnGenerar, 0, 1);
            this.tpBase.Controls.Add(this.label2, 0, 2);
            this.tpBase.Controls.Add(this.pbCodigoBarras, 1, 1);
            this.tpBase.Controls.Add(this.label3, 1, 2);
            this.tpBase.Controls.Add(this.pbCodigoQR, 2, 1);
            this.tpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpBase.Location = new System.Drawing.Point(0, 0);
            this.tpBase.Name = "tpBase";
            this.tpBase.RowCount = 3;
            this.tpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpBase.Size = new System.Drawing.Size(1265, 451);
            this.tpBase.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Empleado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumeroEmpleado
            // 
            this.txtNumeroEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumeroEmpleado.Location = new System.Drawing.Point(141, 3);
            this.txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            this.txtNumeroEmpleado.Size = new System.Drawing.Size(636, 20);
            this.txtNumeroEmpleado.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerar.Location = new System.Drawing.Point(3, 29);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(132, 396);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Codigo de Barras";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(3, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cesat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCodigoBarras
            // 
            this.pbCodigoBarras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCodigoBarras.Location = new System.Drawing.Point(141, 29);
            this.pbCodigoBarras.Name = "pbCodigoBarras";
            this.pbCodigoBarras.Size = new System.Drawing.Size(636, 396);
            this.pbCodigoBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCodigoBarras.TabIndex = 4;
            this.pbCodigoBarras.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(636, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "PROGRAMA DE PRUEBA PARA BELDEN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbCodigoQR
            // 
            this.pbCodigoQR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCodigoQR.Location = new System.Drawing.Point(783, 29);
            this.pbCodigoQR.Name = "pbCodigoQR";
            this.pbCodigoQR.Size = new System.Drawing.Size(459, 396);
            this.pbCodigoQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCodigoQR.TabIndex = 6;
            this.pbCodigoQR.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 451);
            this.Controls.Add(this.tpBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Generador de Codigo De Barras y Codigo QR Prueba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tpBase.ResumeLayout(false);
            this.tpBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroEmpleado;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbCodigoBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbCodigoQR;
    }
}

