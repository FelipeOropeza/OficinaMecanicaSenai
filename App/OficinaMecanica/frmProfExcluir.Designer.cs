namespace OficinaMecanica
{
    partial class frmProfExcluir
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
            this.txtSN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeProf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnExluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSN
            // 
            this.txtSN.Enabled = false;
            this.txtSN.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.Location = new System.Drawing.Point(78, 101);
            this.txtSN.MaxLength = 18;
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(162, 23);
            this.txtSN.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "SN:";
            // 
            // txtNomeProf
            // 
            this.txtNomeProf.Enabled = false;
            this.txtNomeProf.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProf.Location = new System.Drawing.Point(78, 67);
            this.txtNomeProf.MaxLength = 18;
            this.txtNomeProf.Name = "txtNomeProf";
            this.txtNomeProf.Size = new System.Drawing.Size(162, 23);
            this.txtNomeProf.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nome:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(78, 31);
            this.txtId.MaxLength = 18;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(162, 23);
            this.txtId.TabIndex = 26;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(47, 33);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(25, 18);
            this.lblText.TabIndex = 25;
            this.lblText.Text = "Id:";
            // 
            // btnExluir
            // 
            this.btnExluir.BackColor = System.Drawing.Color.Red;
            this.btnExluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExluir.FlatAppearance.BorderSize = 0;
            this.btnExluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnExluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExluir.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExluir.Location = new System.Drawing.Point(99, 174);
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(73, 25);
            this.btnExluir.TabIndex = 24;
            this.btnExluir.Text = "Excluir";
            this.btnExluir.UseVisualStyleBackColor = false;
            this.btnExluir.Click += new System.EventHandler(this.btnExluir_Click);
            // 
            // frmProfExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(281, 221);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeProf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnExluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProfExcluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Exclusão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeProf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnExluir;
    }
}