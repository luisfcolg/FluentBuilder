namespace FluentBuilder
{
    partial class GUI
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
            this.textBoxPropietario = new System.Windows.Forms.TextBox();
            this.numericUpDownSaldo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTasa = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownNumero = new System.Windows.Forms.NumericUpDown();
            this.crear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Propietario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tasa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo inicial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de cuenta:";
            // 
            // textBoxPropietario
            // 
            this.textBoxPropietario.Location = new System.Drawing.Point(181, 64);
            this.textBoxPropietario.Name = "textBoxPropietario";
            this.textBoxPropietario.Size = new System.Drawing.Size(148, 20);
            this.textBoxPropietario.TabIndex = 6;
            // 
            // numericUpDownSaldo
            // 
            this.numericUpDownSaldo.DecimalPlaces = 2;
            this.numericUpDownSaldo.Location = new System.Drawing.Point(181, 131);
            this.numericUpDownSaldo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownSaldo.Name = "numericUpDownSaldo";
            this.numericUpDownSaldo.Size = new System.Drawing.Size(148, 20);
            this.numericUpDownSaldo.TabIndex = 7;
            // 
            // numericUpDownTasa
            // 
            this.numericUpDownTasa.DecimalPlaces = 2;
            this.numericUpDownTasa.Location = new System.Drawing.Point(181, 97);
            this.numericUpDownTasa.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownTasa.Name = "numericUpDownTasa";
            this.numericUpDownTasa.Size = new System.Drawing.Size(148, 20);
            this.numericUpDownTasa.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Platinum",
            "Basic",
            "Golden",
            "Black"});
            this.comboBox1.Location = new System.Drawing.Point(181, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 255);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Listado de cuentas generadas:";
            // 
            // numericUpDownNumero
            // 
            this.numericUpDownNumero.Location = new System.Drawing.Point(181, 33);
            this.numericUpDownNumero.Name = "numericUpDownNumero";
            this.numericUpDownNumero.Size = new System.Drawing.Size(148, 20);
            this.numericUpDownNumero.TabIndex = 12;
            // 
            // crear
            // 
            this.crear.Location = new System.Drawing.Point(254, 199);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(75, 23);
            this.crear.TabIndex = 13;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 417);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.numericUpDownNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDownTasa);
            this.Controls.Add(this.numericUpDownSaldo);
            this.Controls.Add(this.textBoxPropietario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPropietario;
        private System.Windows.Forms.NumericUpDown numericUpDownSaldo;
        private System.Windows.Forms.NumericUpDown numericUpDownTasa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownNumero;
        private System.Windows.Forms.Button crear;
    }
}

