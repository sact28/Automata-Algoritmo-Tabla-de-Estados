namespace Proyecto
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
            dgvEstados = new DataGridView();
            estados = new DataGridViewTextBoxColumn();
            asterisco = new DataGridViewTextBoxColumn();
            mas = new DataGridViewTextBoxColumn();
            diagonal = new DataGridViewTextBoxColumn();
            potencia = new DataGridViewTextBoxColumn();
            digitos = new DataGridViewTextBoxColumn();
            fdc = new DataGridViewTextBoxColumn();
            txtOracion = new TextBox();
            btnValidar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstados).BeginInit();
            SuspendLayout();
            // 
            // dgvEstados
            // 
            dgvEstados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstados.Columns.AddRange(new DataGridViewColumn[] { estados, asterisco, mas, diagonal, potencia, digitos, fdc });
            dgvEstados.Location = new Point(33, 32);
            dgvEstados.Name = "dgvEstados";
            dgvEstados.RowHeadersWidth = 51;
            dgvEstados.Size = new Size(928, 275);
            dgvEstados.TabIndex = 0;
            dgvEstados.CellContentClick += dataGridView1_CellContentClick;
            // 
            // estados
            // 
            estados.HeaderText = "Estados";
            estados.MinimumWidth = 6;
            estados.Name = "estados";
            estados.Width = 125;
            // 
            // asterisco
            // 
            asterisco.HeaderText = "*";
            asterisco.MinimumWidth = 6;
            asterisco.Name = "asterisco";
            asterisco.Width = 125;
            // 
            // mas
            // 
            mas.HeaderText = "+";
            mas.MinimumWidth = 6;
            mas.Name = "mas";
            mas.Width = 125;
            // 
            // diagonal
            // 
            diagonal.HeaderText = "/";
            diagonal.MinimumWidth = 6;
            diagonal.Name = "diagonal";
            diagonal.Width = 125;
            // 
            // potencia
            // 
            potencia.HeaderText = "^";
            potencia.MinimumWidth = 6;
            potencia.Name = "potencia";
            potencia.Width = 125;
            // 
            // digitos
            // 
            digitos.HeaderText = "Digitos";
            digitos.MinimumWidth = 6;
            digitos.Name = "digitos";
            digitos.Width = 125;
            // 
            // fdc
            // 
            fdc.HeaderText = "FDC";
            fdc.MinimumWidth = 6;
            fdc.Name = "fdc";
            fdc.Width = 125;
            // 
            // txtOracion
            // 
            txtOracion.Location = new Point(236, 357);
            txtOracion.Name = "txtOracion";
            txtOracion.Size = new Size(318, 27);
            txtOracion.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(601, 347);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(122, 47);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 455);
            Controls.Add(btnValidar);
            Controls.Add(txtOracion);
            Controls.Add(dgvEstados);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEstados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEstados;
        private DataGridViewTextBoxColumn estados;
        private DataGridViewTextBoxColumn asterisco;
        private DataGridViewTextBoxColumn mas;
        private DataGridViewTextBoxColumn diagonal;
        private DataGridViewTextBoxColumn potencia;
        private DataGridViewTextBoxColumn digitos;
        private DataGridViewTextBoxColumn fdc;
        private TextBox txtOracion;
        private Button btnValidar;
    }
}
