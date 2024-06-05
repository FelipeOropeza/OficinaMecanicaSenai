namespace OficinaMecanica
{
    partial class frmMovimentacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLoc = new System.Windows.Forms.DataGridView();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbArm = new System.Windows.Forms.ComboBox();
            this.cbPos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProf = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbTipo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoc
            // 
            this.dgvLoc.AllowUserToAddRows = false;
            this.dgvLoc.AllowUserToDeleteRows = false;
            this.dgvLoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoc.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLoc.Location = new System.Drawing.Point(54, 150);
            this.dgvLoc.MultiSelect = false;
            this.dgvLoc.Name = "dgvLoc";
            this.dgvLoc.RowHeadersVisible = false;
            this.dgvLoc.Size = new System.Drawing.Size(545, 224);
            this.dgvLoc.TabIndex = 11;
            this.dgvLoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoc_CellContentClick);
            // 
            // txtPesq
            // 
            this.txtPesq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesq.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesq.Location = new System.Drawing.Point(151, 19);
            this.txtPesq.MaxLength = 18;
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(176, 23);
            this.txtPesq.TabIndex = 35;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(84, 21);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(61, 18);
            this.lblText.TabIndex = 20;
            this.lblText.Text = "Campo:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Blue;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Location = new System.Drawing.Point(333, 18);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(73, 25);
            this.btnPesquisar.TabIndex = 22;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbArm
            // 
            this.cbArm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArm.FormattingEnabled = true;
            this.cbArm.Location = new System.Drawing.Point(151, 59);
            this.cbArm.Name = "cbArm";
            this.cbArm.Size = new System.Drawing.Size(112, 21);
            this.cbArm.TabIndex = 33;
            // 
            // cbPos
            // 
            this.cbPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPos.FormattingEnabled = true;
            this.cbPos.Location = new System.Drawing.Point(151, 98);
            this.cbPos.Name = "cbPos";
            this.cbPos.Size = new System.Drawing.Size(112, 21);
            this.cbPos.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Armazem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Posição:";
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
            this.btnCadastrar.Location = new System.Drawing.Point(526, 119);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(73, 25);
            this.btnCadastrar.TabIndex = 34;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(390, 59);
            this.txtQtd.MaxLength = 18;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(112, 23);
            this.txtQtd.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Quantidade:";
            // 
            // cbProf
            // 
            this.cbProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProf.FormattingEnabled = true;
            this.cbProf.Location = new System.Drawing.Point(390, 98);
            this.cbProf.Name = "cbProf";
            this.cbProf.Size = new System.Drawing.Size(112, 21);
            this.cbProf.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Professor:";
            // 
            // chbTipo
            // 
            this.chbTipo.AutoSize = true;
            this.chbTipo.Location = new System.Drawing.Point(429, 23);
            this.chbTipo.Name = "chbTipo";
            this.chbTipo.Size = new System.Drawing.Size(95, 17);
            this.chbTipo.TabIndex = 39;
            this.chbTipo.Text = "Entrada/Saida";
            this.chbTipo.UseVisualStyleBackColor = true;
            // 
            // frmMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(651, 404);
            this.Controls.Add(this.chbTipo);
            this.Controls.Add(this.cbProf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbArm);
            this.Controls.Add(this.cbPos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesq);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.dgvLoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMovimentacao";
            this.Text = "frmMovimentacao";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoc;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbArm;
        private System.Windows.Forms.ComboBox cbPos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbTipo;
    }
}