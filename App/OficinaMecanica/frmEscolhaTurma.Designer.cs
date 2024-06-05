namespace OficinaMecanica
{
    partial class frmEscolhaTurma
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
            this.lblTurma = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSN
            // 
            this.txtSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSN.Enabled = false;
            this.txtSN.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSN.Location = new System.Drawing.Point(90, 25);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(176, 23);
            this.txtSN.TabIndex = 4;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTurma.Location = new System.Drawing.Point(51, 27);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(33, 18);
            this.lblTurma.TabIndex = 3;
            this.lblTurma.Text = "SN:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblMessage.Location = new System.Drawing.Point(70, 75);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(196, 15);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Escolha uma turma do professor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Turma:";
            // 
            // cbTur
            // 
            this.cbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Location = new System.Drawing.Point(90, 129);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(176, 21);
            this.cbTur.TabIndex = 33;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(131, 184);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(73, 25);
            this.btnCadastrar.TabIndex = 35;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmEscolhaTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 231);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.lblTurma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEscolhaTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Escolha de Turma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.Button btnCadastrar;
    }
}