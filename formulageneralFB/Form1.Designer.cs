namespace formulageneralFB
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
            this.txta = new System.Windows.Forms.TextBox();
            this.btnresultado = new System.Windows.Forms.Button();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.lblx1 = new System.Windows.Forms.Label();
            this.lblx2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(67, 44);
            this.txta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(148, 26);
            this.txta.TabIndex = 0;
            // 
            // btnresultado
            // 
            this.btnresultado.Location = new System.Drawing.Point(37, 187);
            this.btnresultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnresultado.Name = "btnresultado";
            this.btnresultado.Size = new System.Drawing.Size(112, 35);
            this.btnresultado.TabIndex = 1;
            this.btnresultado.Text = "Respuesta";
            this.btnresultado.UseVisualStyleBackColor = true;
            this.btnresultado.Click += new System.EventHandler(this.btnresultado_Click);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(67, 84);
            this.txtb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(148, 26);
            this.txtb.TabIndex = 2;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(67, 124);
            this.txtc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(148, 26);
            this.txtc.TabIndex = 3;
            // 
            // lblx1
            // 
            this.lblx1.AutoSize = true;
            this.lblx1.Location = new System.Drawing.Point(260, 47);
            this.lblx1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblx1.Name = "lblx1";
            this.lblx1.Size = new System.Drawing.Size(13, 20);
            this.lblx1.TabIndex = 4;
            this.lblx1.Text = " ";
            // 
            // lblx2
            // 
            this.lblx2.AutoSize = true;
            this.lblx2.Location = new System.Drawing.Point(260, 87);
            this.lblx2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblx2.Name = "lblx2";
            this.lblx2.Size = new System.Drawing.Size(13, 20);
            this.lblx2.TabIndex = 5;
            this.lblx2.Text = " ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(264, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(923, 416);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(37, 253);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(112, 35);
            this.btnrefresh.TabIndex = 7;
            this.btnrefresh.Text = "refrescar";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblx2);
            this.Controls.Add(this.lblx1);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.btnresultado);
            this.Controls.Add(this.txta);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Button btnresultado;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label lblx1;
        private System.Windows.Forms.Label lblx2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

