namespace CRUDXML
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cant_vend = new System.Windows.Forms.TextBox();
            this.btn_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOMBRE DEL PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "PRECIO";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(173, 37);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(99, 34);
            this.txt_id.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(382, 81);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(333, 34);
            this.txt_nombre.TabIndex = 2;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(175, 138);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 34);
            this.txt_precio.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "AÑADIR Y GRABAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(345, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "ACTUALIZAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(565, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "BORRAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 369);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(668, 169);
            this.dataGridView1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "CANTIDADES VENDIDAS";
            // 
            // txt_cant_vend
            // 
            this.txt_cant_vend.Location = new System.Drawing.Point(362, 197);
            this.txt_cant_vend.Name = "txt_cant_vend";
            this.txt_cant_vend.Size = new System.Drawing.Size(100, 34);
            this.txt_cant_vend.TabIndex = 10;
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(313, 319);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(110, 35);
            this.btn_excel.TabIndex = 11;
            this.btn_excel.Text = "EXCEL";
            this.btn_excel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 550);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.txt_cant_vend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cant_vend;
        private System.Windows.Forms.Button btn_excel;
    }
}

