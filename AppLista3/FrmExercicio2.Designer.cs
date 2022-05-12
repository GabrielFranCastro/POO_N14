namespace AppLista3
{
    partial class FrmExercicio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_vetor = new System.Windows.Forms.Button();
            this.btn_vetor2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exercício2";
            // 
            // btn_vetor
            // 
            this.btn_vetor.Location = new System.Drawing.Point(12, 51);
            this.btn_vetor.Name = "btn_vetor";
            this.btn_vetor.Size = new System.Drawing.Size(162, 100);
            this.btn_vetor.TabIndex = 1;
            this.btn_vetor.Text = "Vetor";
            this.btn_vetor.UseVisualStyleBackColor = true;
            this.btn_vetor.Click += new System.EventHandler(this.btn_vetor_Click);
            // 
            // btn_vetor2
            // 
            this.btn_vetor2.Location = new System.Drawing.Point(180, 51);
            this.btn_vetor2.Name = "btn_vetor2";
            this.btn_vetor2.Size = new System.Drawing.Size(162, 100);
            this.btn_vetor2.TabIndex = 2;
            this.btn_vetor2.Text = "Vetor";
            this.btn_vetor2.UseVisualStyleBackColor = true;
            this.btn_vetor2.Click += new System.EventHandler(this.btn_vetor2_Click);
            // 
            // FrmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_vetor2);
            this.Controls.Add(this.btn_vetor);
            this.Controls.Add(this.label1);
            this.Name = "FrmExercicio2";
            this.Text = "Exercício02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_vetor;
        private System.Windows.Forms.Button btn_vetor2;
    }
}