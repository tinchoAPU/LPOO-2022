namespace Vistas
{
    partial class FrmNuevoCliente
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewClientCarnet = new System.Windows.Forms.TextBox();
            this.txtNewClientCUIT = new System.Windows.Forms.TextBox();
            this.txtNewClientDireccion = new System.Windows.Forms.TextBox();
            this.txtNewClientNombre = new System.Windows.Forms.TextBox();
            this.txtNewClientApellido = new System.Windows.Forms.TextBox();
            this.txtNewClientDNI = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccíon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "N° de CUIT:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "N° de Carnet:";
            // 
            // txtNewClientCarnet
            // 
            this.txtNewClientCarnet.Location = new System.Drawing.Point(15, 298);
            this.txtNewClientCarnet.Name = "txtNewClientCarnet";
            this.txtNewClientCarnet.Size = new System.Drawing.Size(193, 20);
            this.txtNewClientCarnet.TabIndex = 6;
            this.txtNewClientCarnet.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewClientCarnetValidating);
            // 
            // txtNewClientCUIT
            // 
            this.txtNewClientCUIT.Location = new System.Drawing.Point(15, 248);
            this.txtNewClientCUIT.Name = "txtNewClientCUIT";
            this.txtNewClientCUIT.Size = new System.Drawing.Size(193, 20);
            this.txtNewClientCUIT.TabIndex = 5;
            this.txtNewClientCUIT.TextChanged += new System.EventHandler(this.txtNewClientCUIT_TextChanged);
            this.txtNewClientCUIT.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewClientCUITValidating);
            // 
            // txtNewClientDireccion
            // 
            this.txtNewClientDireccion.Location = new System.Drawing.Point(15, 199);
            this.txtNewClientDireccion.Name = "txtNewClientDireccion";
            this.txtNewClientDireccion.Size = new System.Drawing.Size(193, 20);
            this.txtNewClientDireccion.TabIndex = 4;
            this.txtNewClientDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewClientValidatingDireccion);
            // 
            // txtNewClientNombre
            // 
            this.txtNewClientNombre.Location = new System.Drawing.Point(15, 103);
            this.txtNewClientNombre.Name = "txtNewClientNombre";
            this.txtNewClientNombre.Size = new System.Drawing.Size(193, 20);
            this.txtNewClientNombre.TabIndex = 2;
            this.txtNewClientNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewClientNombreValidating);
            // 
            // txtNewClientApellido
            // 
            this.txtNewClientApellido.Location = new System.Drawing.Point(15, 53);
            this.txtNewClientApellido.Name = "txtNewClientApellido";
            this.txtNewClientApellido.Size = new System.Drawing.Size(193, 20);
            this.txtNewClientApellido.TabIndex = 1;
            this.txtNewClientApellido.TextChanged += new System.EventHandler(this.txtNewClientApellido_TextChanged);
            this.txtNewClientApellido.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewClientApellidoValidating);
            // 
            // txtNewClientDNI
            // 
            this.txtNewClientDNI.Location = new System.Drawing.Point(15, 151);
            this.txtNewClientDNI.Name = "txtNewClientDNI";
            this.txtNewClientDNI.Size = new System.Drawing.Size(193, 20);
            this.txtNewClientDNI.TabIndex = 3;
            this.txtNewClientDNI.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewClientDNIValidating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtNewClientApellido);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNewClientCarnet);
            this.panel1.Controls.Add(this.txtNewClientCUIT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNewClientDireccion);
            this.panel1.Controls.Add(this.txtNewClientDNI);
            this.panel1.Controls.Add(this.txtNewClientNombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(21, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 376);
            this.panel1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nuevo Cliente";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(271, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 376);
            this.panel2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(100, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Busquedas";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(589, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 376);
            this.panel3.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Filtros";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "Clientes";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(774, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 26);
            this.button3.TabIndex = 18;
            this.button3.Text = "CERRAR SESION";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(636, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 26);
            this.button4.TabIndex = 19;
            this.button4.Text = "<< MENU PRINCIPAL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 502);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmNuevoCliente";
            this.Text = "Nuevo Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox txtNewClientCarnet;
        private System.Windows.Forms.TextBox txtNewClientCUIT;
        private System.Windows.Forms.TextBox txtNewClientDireccion;
        private System.Windows.Forms.TextBox txtNewClientNombre;
        private System.Windows.Forms.TextBox txtNewClientApellido;
        private System.Windows.Forms.TextBox txtNewClientDNI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}