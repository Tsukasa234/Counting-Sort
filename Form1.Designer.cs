namespace CountingSort
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
            txtNumero = new TextBox();
            btnAgregar = new Button();
            label1 = new Label();
            btnOrdenar = new Button();
            label2 = new Label();
            dgvOrdenar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenar).BeginInit();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(126, 259);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(139, 315);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 259);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 3;
            label1.Text = "Numero";
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(139, 369);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(94, 29);
            btnOrdenar.TabIndex = 4;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pixel Operator 8", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 20);
            label2.Name = "label2";
            label2.Size = new Size(558, 43);
            label2.TabIndex = 5;
            label2.Text = "COUNTING SORT";
            // 
            // dgvOrdenar
            // 
            dgvOrdenar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenar.Location = new Point(294, 106);
            dgvOrdenar.Name = "dgvOrdenar";
            dgvOrdenar.RowHeadersWidth = 51;
            dgvOrdenar.Size = new Size(300, 440);
            dgvOrdenar.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 576);
            Controls.Add(dgvOrdenar);
            Controls.Add(label2);
            Controls.Add(btnOrdenar);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvOrdenar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNumero;
        private Button btnAgregar;
        private Label label1;
        private Button btnOrdenar;
        private Label label2;
        private DataGridView dgvOrdenar;
    }
}
