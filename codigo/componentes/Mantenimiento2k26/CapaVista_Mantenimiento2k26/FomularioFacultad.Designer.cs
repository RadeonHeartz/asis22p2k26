namespace CapaVista_Mantenimiento2k26
{
    partial class FomularioFacultad
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Guardarbtn = new System.Windows.Forms.Button();
            this.Estadp = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ayudabtn = new System.Windows.Forms.Button();
            this.Imprimirbtn = new System.Windows.Forms.Button();
            this.Nuevobtn = new System.Windows.Forms.Button();
            this.Editarbtn = new System.Windows.Forms.Button();
            this.borrarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(853, 445);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Guardarbtn);
            this.panel1.Controls.Add(this.Estadp);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Controls.Add(this.Codigo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(913, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 262);
            this.panel1.TabIndex = 2;
            // 
            // Guardarbtn
            // 
            this.Guardarbtn.Location = new System.Drawing.Point(97, 214);
            this.Guardarbtn.Name = "Guardarbtn";
            this.Guardarbtn.Size = new System.Drawing.Size(75, 33);
            this.Guardarbtn.TabIndex = 6;
            this.Guardarbtn.Text = "grabar";
            this.Guardarbtn.UseVisualStyleBackColor = true;
            this.Guardarbtn.Click += new System.EventHandler(this.Guardarbtn_Click);
            // 
            // Estadp
            // 
            this.Estadp.Location = new System.Drawing.Point(150, 166);
            this.Estadp.Name = "Estadp";
            this.Estadp.Size = new System.Drawing.Size(100, 22);
            this.Estadp.TabIndex = 5;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(150, 119);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 22);
            this.Nombre.TabIndex = 4;
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(150, 58);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(100, 22);
            this.Codigo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estado de facultad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre de facultad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo de facultad";
            // 
            // ayudabtn
            // 
            this.ayudabtn.Location = new System.Drawing.Point(913, 328);
            this.ayudabtn.Name = "ayudabtn";
            this.ayudabtn.Size = new System.Drawing.Size(75, 23);
            this.ayudabtn.TabIndex = 6;
            this.ayudabtn.Text = "ayuda";
            this.ayudabtn.UseVisualStyleBackColor = true;
            // 
            // Imprimirbtn
            // 
            this.Imprimirbtn.Location = new System.Drawing.Point(998, 328);
            this.Imprimirbtn.Name = "Imprimirbtn";
            this.Imprimirbtn.Size = new System.Drawing.Size(75, 23);
            this.Imprimirbtn.TabIndex = 7;
            this.Imprimirbtn.Text = "Imprimir";
            this.Imprimirbtn.UseVisualStyleBackColor = true;
            this.Imprimirbtn.Click += new System.EventHandler(this.Imprimirbtn_Click);
            // 
            // Nuevobtn
            // 
            this.Nuevobtn.Location = new System.Drawing.Point(1088, 328);
            this.Nuevobtn.Name = "Nuevobtn";
            this.Nuevobtn.Size = new System.Drawing.Size(75, 23);
            this.Nuevobtn.TabIndex = 8;
            this.Nuevobtn.Text = "Nuevo";
            this.Nuevobtn.UseVisualStyleBackColor = true;
            this.Nuevobtn.Click += new System.EventHandler(this.Nuevobtn_Click);
            // 
            // Editarbtn
            // 
            this.Editarbtn.Location = new System.Drawing.Point(913, 368);
            this.Editarbtn.Name = "Editarbtn";
            this.Editarbtn.Size = new System.Drawing.Size(75, 23);
            this.Editarbtn.TabIndex = 9;
            this.Editarbtn.Text = "Editar";
            this.Editarbtn.UseVisualStyleBackColor = true;
            this.Editarbtn.Click += new System.EventHandler(this.Editarbtn_Click);
            // 
            // borrarbtn
            // 
            this.borrarbtn.Location = new System.Drawing.Point(998, 368);
            this.borrarbtn.Name = "borrarbtn";
            this.borrarbtn.Size = new System.Drawing.Size(75, 23);
            this.borrarbtn.TabIndex = 10;
            this.borrarbtn.Text = "borrar";
            this.borrarbtn.UseVisualStyleBackColor = true;
            this.borrarbtn.Click += new System.EventHandler(this.borrarbtn_Click);
            // 
            // FomularioFacultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 643);
            this.Controls.Add(this.borrarbtn);
            this.Controls.Add(this.Editarbtn);
            this.Controls.Add(this.Nuevobtn);
            this.Controls.Add(this.Imprimirbtn);
            this.Controls.Add(this.ayudabtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FomularioFacultad";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Estadp;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ayudabtn;
        private System.Windows.Forms.Button Imprimirbtn;
        private System.Windows.Forms.Button Nuevobtn;
        private System.Windows.Forms.Button Editarbtn;
        private System.Windows.Forms.Button borrarbtn;
        private System.Windows.Forms.Button Guardarbtn;
    }
}