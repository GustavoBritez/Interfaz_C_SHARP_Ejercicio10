namespace Ejercicio10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LB_ENUNCIADO = new System.Windows.Forms.Label();
            this.GR_1 = new System.Windows.Forms.GroupBox();
            this.GR_2 = new System.Windows.Forms.GroupBox();
            this.RD1_Celcius = new System.Windows.Forms.RadioButton();
            this.RD1_Fahrenheit = new System.Windows.Forms.RadioButton();
            this.RD1_Kelvin = new System.Windows.Forms.RadioButton();
            this.RD1_Rankine = new System.Windows.Forms.RadioButton();
            this.RD2_Celcius = new System.Windows.Forms.RadioButton();
            this.RD2_Fahrenheit = new System.Windows.Forms.RadioButton();
            this.RD2_Kelvin = new System.Windows.Forms.RadioButton();
            this.RD2_Rankine = new System.Windows.Forms.RadioButton();
            this.BTN_TRANSFORMAR = new System.Windows.Forms.Button();
            this.DT_1 = new System.Windows.Forms.DataGridView();
            this.Escala_Inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GR_1.SuspendLayout();
            this.GR_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_ENUNCIADO
            // 
            this.LB_ENUNCIADO.Location = new System.Drawing.Point(12, 9);
            this.LB_ENUNCIADO.Name = "LB_ENUNCIADO";
            this.LB_ENUNCIADO.Size = new System.Drawing.Size(597, 50);
            this.LB_ENUNCIADO.TabIndex = 0;
            this.LB_ENUNCIADO.Text = resources.GetString("LB_ENUNCIADO.Text");
            // 
            // GR_1
            // 
            this.GR_1.Controls.Add(this.RD1_Rankine);
            this.GR_1.Controls.Add(this.RD1_Kelvin);
            this.GR_1.Controls.Add(this.RD1_Fahrenheit);
            this.GR_1.Controls.Add(this.RD1_Celcius);
            this.GR_1.Location = new System.Drawing.Point(15, 62);
            this.GR_1.Name = "GR_1";
            this.GR_1.Size = new System.Drawing.Size(131, 141);
            this.GR_1.TabIndex = 1;
            this.GR_1.TabStop = false;
            this.GR_1.Text = "Escala Inicial";
            // 
            // GR_2
            // 
            this.GR_2.Controls.Add(this.RD2_Rankine);
            this.GR_2.Controls.Add(this.RD2_Kelvin);
            this.GR_2.Controls.Add(this.RD2_Fahrenheit);
            this.GR_2.Controls.Add(this.RD2_Celcius);
            this.GR_2.Location = new System.Drawing.Point(466, 62);
            this.GR_2.Name = "GR_2";
            this.GR_2.Size = new System.Drawing.Size(143, 141);
            this.GR_2.TabIndex = 2;
            this.GR_2.TabStop = false;
            this.GR_2.Text = "Escala final";
            // 
            // RD1_Celcius
            // 
            this.RD1_Celcius.AutoSize = true;
            this.RD1_Celcius.Location = new System.Drawing.Point(19, 28);
            this.RD1_Celcius.Name = "RD1_Celcius";
            this.RD1_Celcius.Size = new System.Drawing.Size(59, 17);
            this.RD1_Celcius.TabIndex = 0;
            this.RD1_Celcius.TabStop = true;
            this.RD1_Celcius.Text = "Celcius";
            this.RD1_Celcius.UseVisualStyleBackColor = true;
            // 
            // RD1_Fahrenheit
            // 
            this.RD1_Fahrenheit.AutoSize = true;
            this.RD1_Fahrenheit.Location = new System.Drawing.Point(19, 51);
            this.RD1_Fahrenheit.Name = "RD1_Fahrenheit";
            this.RD1_Fahrenheit.Size = new System.Drawing.Size(75, 17);
            this.RD1_Fahrenheit.TabIndex = 1;
            this.RD1_Fahrenheit.TabStop = true;
            this.RD1_Fahrenheit.Text = "Fahrenheit";
            this.RD1_Fahrenheit.UseVisualStyleBackColor = true;
            // 
            // RD1_Kelvin
            // 
            this.RD1_Kelvin.AutoSize = true;
            this.RD1_Kelvin.Location = new System.Drawing.Point(19, 74);
            this.RD1_Kelvin.Name = "RD1_Kelvin";
            this.RD1_Kelvin.Size = new System.Drawing.Size(54, 17);
            this.RD1_Kelvin.TabIndex = 2;
            this.RD1_Kelvin.TabStop = true;
            this.RD1_Kelvin.Text = "Kelvin";
            this.RD1_Kelvin.UseVisualStyleBackColor = true;
            // 
            // RD1_Rankine
            // 
            this.RD1_Rankine.AutoSize = true;
            this.RD1_Rankine.Location = new System.Drawing.Point(19, 97);
            this.RD1_Rankine.Name = "RD1_Rankine";
            this.RD1_Rankine.Size = new System.Drawing.Size(65, 17);
            this.RD1_Rankine.TabIndex = 3;
            this.RD1_Rankine.TabStop = true;
            this.RD1_Rankine.Text = "Rankine";
            this.RD1_Rankine.UseVisualStyleBackColor = true;
            // 
            // RD2_Celcius
            // 
            this.RD2_Celcius.AutoSize = true;
            this.RD2_Celcius.Location = new System.Drawing.Point(18, 28);
            this.RD2_Celcius.Name = "RD2_Celcius";
            this.RD2_Celcius.Size = new System.Drawing.Size(59, 17);
            this.RD2_Celcius.TabIndex = 4;
            this.RD2_Celcius.TabStop = true;
            this.RD2_Celcius.Text = "Celcius";
            this.RD2_Celcius.UseVisualStyleBackColor = true;
            // 
            // RD2_Fahrenheit
            // 
            this.RD2_Fahrenheit.AutoSize = true;
            this.RD2_Fahrenheit.Location = new System.Drawing.Point(18, 51);
            this.RD2_Fahrenheit.Name = "RD2_Fahrenheit";
            this.RD2_Fahrenheit.Size = new System.Drawing.Size(75, 17);
            this.RD2_Fahrenheit.TabIndex = 4;
            this.RD2_Fahrenheit.TabStop = true;
            this.RD2_Fahrenheit.Text = "Fahrenheit";
            this.RD2_Fahrenheit.UseVisualStyleBackColor = true;
            // 
            // RD2_Kelvin
            // 
            this.RD2_Kelvin.AutoSize = true;
            this.RD2_Kelvin.Location = new System.Drawing.Point(18, 74);
            this.RD2_Kelvin.Name = "RD2_Kelvin";
            this.RD2_Kelvin.Size = new System.Drawing.Size(54, 17);
            this.RD2_Kelvin.TabIndex = 4;
            this.RD2_Kelvin.TabStop = true;
            this.RD2_Kelvin.Text = "Kelvin";
            this.RD2_Kelvin.UseVisualStyleBackColor = true;
            // 
            // RD2_Rankine
            // 
            this.RD2_Rankine.AutoSize = true;
            this.RD2_Rankine.Location = new System.Drawing.Point(18, 97);
            this.RD2_Rankine.Name = "RD2_Rankine";
            this.RD2_Rankine.Size = new System.Drawing.Size(65, 17);
            this.RD2_Rankine.TabIndex = 4;
            this.RD2_Rankine.TabStop = true;
            this.RD2_Rankine.Text = "Rankine";
            this.RD2_Rankine.UseVisualStyleBackColor = true;
            // 
            // BTN_TRANSFORMAR
            // 
            this.BTN_TRANSFORMAR.Location = new System.Drawing.Point(253, 130);
            this.BTN_TRANSFORMAR.Name = "BTN_TRANSFORMAR";
            this.BTN_TRANSFORMAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_TRANSFORMAR.TabIndex = 3;
            this.BTN_TRANSFORMAR.Text = "Transformar";
            this.BTN_TRANSFORMAR.UseVisualStyleBackColor = true;
            this.BTN_TRANSFORMAR.Click += new System.EventHandler(this.BTN_TRANSFORMAR_Click);
            // 
            // DT_1
            // 
            this.DT_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DT_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Escala_Inicial,
            this.Cantidad_I,
            this.Final,
            this.Cantidad_F});
            this.DT_1.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DT_1.Location = new System.Drawing.Point(147, 209);
            this.DT_1.Name = "DT_1";
            this.DT_1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DT_1.Size = new System.Drawing.Size(319, 141);
            this.DT_1.TabIndex = 4;
            // 
            // Escala_Inicial
            // 
            this.Escala_Inicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Escala_Inicial.HeaderText = "Inicial";
            this.Escala_Inicial.Name = "Escala_Inicial";
            this.Escala_Inicial.Width = 59;
            // 
            // Cantidad_I
            // 
            this.Cantidad_I.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad_I.HeaderText = "Cantidad I";
            this.Cantidad_I.Name = "Cantidad_I";
            this.Cantidad_I.Width = 80;
            // 
            // Final
            // 
            this.Final.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Final.HeaderText = "Final";
            this.Final.Name = "Final";
            this.Final.Width = 54;
            // 
            // Cantidad_F
            // 
            this.Cantidad_F.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cantidad_F.HeaderText = "Cantidad F";
            this.Cantidad_F.Name = "Cantidad_F";
            this.Cantidad_F.Width = 83;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 352);
            this.Controls.Add(this.DT_1);
            this.Controls.Add(this.BTN_TRANSFORMAR);
            this.Controls.Add(this.GR_2);
            this.Controls.Add(this.GR_1);
            this.Controls.Add(this.LB_ENUNCIADO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GR_1.ResumeLayout(false);
            this.GR_1.PerformLayout();
            this.GR_2.ResumeLayout(false);
            this.GR_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LB_ENUNCIADO;
        private System.Windows.Forms.GroupBox GR_1;
        private System.Windows.Forms.GroupBox GR_2;
        private System.Windows.Forms.RadioButton RD1_Rankine;
        private System.Windows.Forms.RadioButton RD1_Kelvin;
        private System.Windows.Forms.RadioButton RD1_Fahrenheit;
        private System.Windows.Forms.RadioButton RD1_Celcius;
        private System.Windows.Forms.RadioButton RD2_Rankine;
        private System.Windows.Forms.RadioButton RD2_Kelvin;
        private System.Windows.Forms.RadioButton RD2_Fahrenheit;
        private System.Windows.Forms.RadioButton RD2_Celcius;
        private System.Windows.Forms.Button BTN_TRANSFORMAR;
        private System.Windows.Forms.DataGridView DT_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Escala_Inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_I;
        private System.Windows.Forms.DataGridViewTextBoxColumn Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_F;
    }
}

