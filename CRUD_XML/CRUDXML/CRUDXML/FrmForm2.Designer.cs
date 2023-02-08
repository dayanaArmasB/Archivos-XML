namespace CRUDXML
{
    partial class FrmForm2
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
            this.txt_cant_vend = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRows = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cant_vend
            // 
            this.txt_cant_vend.Location = new System.Drawing.Point(263, 182);
            this.txt_cant_vend.Name = "txt_cant_vend";
            this.txt_cant_vend.Size = new System.Drawing.Size(100, 22);
            this.txt_cant_vend.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "CANTIDADES VENDIDAS";
            // 
            // dgvRows
            // 
            this.dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRows.Location = new System.Drawing.Point(56, 295);
            this.dgvRows.Name = "dgvRows";
            this.dgvRows.RowHeadersWidth = 51;
            this.dgvRows.Size = new System.Drawing.Size(668, 169);
            this.dgvRows.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(530, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 35);
            this.button4.TabIndex = 20;
            this.button4.Text = "BORRAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(319, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 33);
            this.button3.TabIndex = 19;
            this.button3.Text = "ACTUALIZAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "AÑADIR Y GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(148, 128);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 22);
            this.txt_precio.TabIndex = 16;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(263, 74);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(333, 22);
            this.txt_nombre.TabIndex = 15;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(194, 28);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(99, 22);
            this.txt_id.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "PRECIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "NOMBRE DEL PRODUCTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // FrmForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 493);
            this.Controls.Add(this.txt_cant_vend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvRows);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmForm2";
            this.Text = "FrmForm2";
            this.Load += new System.EventHandler(this.FrmForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cant_vend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvRows;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}