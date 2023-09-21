namespace Euclides_MSAC
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
            this.gv1 = new System.Windows.Forms.DataGridView();
            this.Paso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ecuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).BeginInit();
            this.SuspendLayout();
            // 
            // gv1
            // 
            this.gv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Paso,
            this.Operacion,
            this.Ecuacion});
            this.gv1.Location = new System.Drawing.Point(65, 195);
            this.gv1.Name = "gv1";
            this.gv1.RowHeadersWidth = 62;
            this.gv1.RowTemplate.Height = 33;
            this.gv1.Size = new System.Drawing.Size(568, 225);
            this.gv1.TabIndex = 0;
            // 
            // Paso
            // 
            this.Paso.HeaderText = "Paso";
            this.Paso.MinimumWidth = 8;
            this.Paso.Name = "Paso";
            this.Paso.Width = 150;
            // 
            // Operacion
            // 
            this.Operacion.HeaderText = "Operacion";
            this.Operacion.MinimumWidth = 8;
            this.Operacion.Name = "Operacion";
            this.Operacion.Width = 150;
            // 
            // Ecuacion
            // 
            this.Ecuacion.HeaderText = "Ecuacion";
            this.Ecuacion.MinimumWidth = 8;
            this.Ecuacion.Name = "Ecuacion";
            this.Ecuacion.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "numero 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(200, 47);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(219, 31);
            this.txtnum1.TabIndex = 4;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(199, 101);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(227, 31);
            this.txtnum2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gv1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gv1;
        private DataGridViewTextBoxColumn Paso;
        private DataGridViewTextBoxColumn Operacion;
        private DataGridViewTextBoxColumn Ecuacion;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox txtnum1;
        private TextBox txtnum2;
    }
}