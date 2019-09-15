namespace Sueldo_empleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltotalsalario = new System.Windows.Forms.Label();
            this.txthoratrabajada = new System.Windows.Forms.TextBox();
            this.txtvalorhora = new System.Windows.Forms.TextBox();
            this.btnenviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa para Calculo de Sueldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas Trabajadas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor por hora Trabajada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Su Salario es:";
            // 
            // lbltotalsalario
            // 
            this.lbltotalsalario.AutoSize = true;
            this.lbltotalsalario.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalsalario.Location = new System.Drawing.Point(266, 320);
            this.lbltotalsalario.Name = "lbltotalsalario";
            this.lbltotalsalario.Size = new System.Drawing.Size(22, 24);
            this.lbltotalsalario.TabIndex = 4;
            this.lbltotalsalario.Text = "0";
            // 
            // txthoratrabajada
            // 
            this.txthoratrabajada.Location = new System.Drawing.Point(372, 132);
            this.txthoratrabajada.Name = "txthoratrabajada";
            this.txthoratrabajada.Size = new System.Drawing.Size(100, 20);
            this.txthoratrabajada.TabIndex = 5;
            // 
            // txtvalorhora
            // 
            this.txtvalorhora.Location = new System.Drawing.Point(372, 218);
            this.txtvalorhora.Name = "txtvalorhora";
            this.txtvalorhora.Size = new System.Drawing.Size(100, 20);
            this.txtvalorhora.TabIndex = 6;
            // 
            // btnenviar
            // 
            this.btnenviar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.Location = new System.Drawing.Point(543, 165);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(108, 37);
            this.btnenviar.TabIndex = 7;
            this.btnenviar.Text = "Consultar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.txtvalorhora);
            this.Controls.Add(this.txthoratrabajada);
            this.Controls.Add(this.lbltotalsalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltotalsalario;
        private System.Windows.Forms.TextBox txthoratrabajada;
        private System.Windows.Forms.TextBox txtvalorhora;
        private System.Windows.Forms.Button btnenviar;
    }
}

