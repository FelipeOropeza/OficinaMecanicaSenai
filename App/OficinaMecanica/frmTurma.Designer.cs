namespace OficinaMecanica
{
    partial class frmTurma
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
            this.lblTurma = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblSN = new System.Windows.Forms.Label();
            this.cbProf = new System.Windows.Forms.ComboBox();
            this.btnAddTurma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTurma.Location = new System.Drawing.Point(58, 19);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(122, 18);
            this.lblTurma.TabIndex = 1;
            this.lblTurma.Text = "Nome da Turma:";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNome.Location = new System.Drawing.Point(61, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 23);
            this.txtNome.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblMessage.Location = new System.Drawing.Point(69, 80);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(207, 15);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Vincule a turma com um professor:";
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblSN.Location = new System.Drawing.Point(67, 122);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(33, 18);
            this.lblSN.TabIndex = 4;
            this.lblSN.Text = "SN:";
            // 
            // cbProf
            // 
            this.cbProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProf.FormattingEnabled = true;
            this.cbProf.Location = new System.Drawing.Point(106, 122);
            this.cbProf.Name = "cbProf";
            this.cbProf.Size = new System.Drawing.Size(121, 21);
            this.cbProf.TabIndex = 5;
            // 
            // btnAddTurma
            // 
            this.btnAddTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.btnAddTurma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddTurma.FlatAppearance.BorderSize = 0;
            this.btnAddTurma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddTurma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnAddTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTurma.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddTurma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTurma.Location = new System.Drawing.Point(128, 188);
            this.btnAddTurma.Name = "btnAddTurma";
            this.btnAddTurma.Size = new System.Drawing.Size(69, 23);
            this.btnAddTurma.TabIndex = 6;
            this.btnAddTurma.Text = "Vincular";
            this.btnAddTurma.UseVisualStyleBackColor = false;
            this.btnAddTurma.Click += new System.EventHandler(this.btnAddTurma_Click);
            // 
            // frmTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(341, 236);
            this.Controls.Add(this.btnAddTurma);
            this.Controls.Add(this.cbProf);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTurma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulário Turma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.ComboBox cbProf;
        private System.Windows.Forms.Button btnAddTurma;
    }
}