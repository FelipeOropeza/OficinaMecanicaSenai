namespace OficinaMecanica
{
    partial class frm_est
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_est));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnSaiMat = new System.Windows.Forms.Button();
            this.btnLoca = new System.Windows.Forms.Button();
            this.btnMov = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCodSap = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPosicao = new System.Windows.Forms.Button();
            this.btnAddEstoque = new System.Windows.Forms.Button();
            this.btnAddTurma = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(99)))), ((int)(((byte)(162)))));
            this.panelPrincipal.Controls.Add(this.btnSaiMat);
            this.panelPrincipal.Controls.Add(this.btnLoca);
            this.panelPrincipal.Controls.Add(this.btnMov);
            this.panelPrincipal.Controls.Add(this.btnProfessor);
            this.panelPrincipal.Controls.Add(this.btnMaterial);
            this.panelPrincipal.Controls.Add(this.btnHome);
            this.panelPrincipal.Controls.Add(this.panel1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(149, 450);
            this.panelPrincipal.TabIndex = 1;
            // 
            // btnSaiMat
            // 
            this.btnSaiMat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaiMat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaiMat.FlatAppearance.BorderSize = 0;
            this.btnSaiMat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnSaiMat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSaiMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaiMat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaiMat.ForeColor = System.Drawing.Color.White;
            this.btnSaiMat.Location = new System.Drawing.Point(0, 311);
            this.btnSaiMat.Name = "btnSaiMat";
            this.btnSaiMat.Size = new System.Drawing.Size(149, 45);
            this.btnSaiMat.TabIndex = 8;
            this.btnSaiMat.Text = "HISTORICO ENTRADA/SAIDA";
            this.btnSaiMat.UseVisualStyleBackColor = true;
            this.btnSaiMat.Click += new System.EventHandler(this.btnSaiMat_Click);
            // 
            // btnLoca
            // 
            this.btnLoca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLoca.FlatAppearance.BorderSize = 0;
            this.btnLoca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnLoca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnLoca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoca.ForeColor = System.Drawing.Color.White;
            this.btnLoca.Location = new System.Drawing.Point(0, 266);
            this.btnLoca.Name = "btnLoca";
            this.btnLoca.Size = new System.Drawing.Size(149, 45);
            this.btnLoca.TabIndex = 7;
            this.btnLoca.Text = "LOCALIZAÇÃO";
            this.btnLoca.UseVisualStyleBackColor = true;
            this.btnLoca.Click += new System.EventHandler(this.btnLoca_Click);
            // 
            // btnMov
            // 
            this.btnMov.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMov.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMov.FlatAppearance.BorderSize = 0;
            this.btnMov.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMov.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMov.ForeColor = System.Drawing.Color.White;
            this.btnMov.Location = new System.Drawing.Point(0, 221);
            this.btnMov.Name = "btnMov";
            this.btnMov.Size = new System.Drawing.Size(149, 45);
            this.btnMov.TabIndex = 6;
            this.btnMov.Text = "MOVIMENTAÇÃO";
            this.btnMov.UseVisualStyleBackColor = true;
            this.btnMov.Click += new System.EventHandler(this.btnMov_Click);
            // 
            // btnProfessor
            // 
            this.btnProfessor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfessor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProfessor.FlatAppearance.BorderSize = 0;
            this.btnProfessor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnProfessor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfessor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessor.ForeColor = System.Drawing.Color.White;
            this.btnProfessor.Location = new System.Drawing.Point(0, 176);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(149, 45);
            this.btnProfessor.TabIndex = 5;
            this.btnProfessor.Text = "PROFESSOR";
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMaterial.FlatAppearance.BorderSize = 0;
            this.btnMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.ForeColor = System.Drawing.Color.White;
            this.btnMaterial.Location = new System.Drawing.Point(0, 131);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(149, 45);
            this.btnMaterial.TabIndex = 4;
            this.btnMaterial.Text = "MATERIAL";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 86);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(149, 45);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(99)))), ((int)(((byte)(162)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 86);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelForm.Controls.Add(this.btnLimpar);
            this.panelForm.Controls.Add(this.txtCodSap);
            this.panelForm.Controls.Add(this.btnPesquisar);
            this.panelForm.Controls.Add(this.lblText);
            this.panelForm.Controls.Add(this.dgvMaterial);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelForm.Location = new System.Drawing.Point(149, 46);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(651, 404);
            this.panelForm.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SlateGray;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(458, 40);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(56, 25);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCodSap
            // 
            this.txtCodSap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodSap.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSap.Location = new System.Drawing.Point(181, 42);
            this.txtCodSap.MaxLength = 18;
            this.txtCodSap.Name = "txtCodSap";
            this.txtCodSap.Size = new System.Drawing.Size(174, 23);
            this.txtCodSap.TabIndex = 3;
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
            this.btnPesquisar.Location = new System.Drawing.Point(371, 40);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(73, 25);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(81, 44);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(94, 18);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Codigo Sap:";
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.AllowUserToAddRows = false;
            this.dgvMaterial.AllowUserToDeleteRows = false;
            this.dgvMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvMaterial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterial.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvMaterial.Location = new System.Drawing.Point(54, 150);
            this.dgvMaterial.MultiSelect = false;
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMaterial.RowHeadersVisible = false;
            this.dgvMaterial.Size = new System.Drawing.Size(545, 224);
            this.dgvMaterial.TabIndex = 0;
            this.dgvMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterial_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(99)))), ((int)(((byte)(162)))));
            this.panel2.Controls.Add(this.btnPosicao);
            this.panel2.Controls.Add(this.btnAddEstoque);
            this.panel2.Controls.Add(this.btnAddTurma);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(149, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 47);
            this.panel2.TabIndex = 3;
            // 
            // btnPosicao
            // 
            this.btnPosicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.btnPosicao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPosicao.FlatAppearance.BorderSize = 0;
            this.btnPosicao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPosicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnPosicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosicao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosicao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPosicao.Location = new System.Drawing.Point(255, 12);
            this.btnPosicao.Name = "btnPosicao";
            this.btnPosicao.Size = new System.Drawing.Size(111, 23);
            this.btnPosicao.TabIndex = 2;
            this.btnPosicao.Text = "ADD POSICAO";
            this.btnPosicao.UseVisualStyleBackColor = false;
            this.btnPosicao.Click += new System.EventHandler(this.btnAddPosicao_Click);
            // 
            // btnAddEstoque
            // 
            this.btnAddEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.btnAddEstoque.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddEstoque.FlatAppearance.BorderSize = 0;
            this.btnAddEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnAddEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEstoque.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEstoque.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddEstoque.Location = new System.Drawing.Point(387, 12);
            this.btnAddEstoque.Name = "btnAddEstoque";
            this.btnAddEstoque.Size = new System.Drawing.Size(111, 23);
            this.btnAddEstoque.TabIndex = 1;
            this.btnAddEstoque.Text = "ADD ESTOQUE";
            this.btnAddEstoque.UseVisualStyleBackColor = false;
            this.btnAddEstoque.Click += new System.EventHandler(this.btnAddEstoque_Click);
            // 
            // btnAddTurma
            // 
            this.btnAddTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.btnAddTurma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddTurma.FlatAppearance.BorderSize = 0;
            this.btnAddTurma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddTurma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnAddTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTurma.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTurma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTurma.Location = new System.Drawing.Point(519, 12);
            this.btnAddTurma.Name = "btnAddTurma";
            this.btnAddTurma.Size = new System.Drawing.Size(95, 23);
            this.btnAddTurma.TabIndex = 0;
            this.btnAddTurma.Text = "ADD TURMA";
            this.btnAddTurma.UseVisualStyleBackColor = false;
            this.btnAddTurma.Click += new System.EventHandler(this.btnAddTurma_Click);
            // 
            // frm_est
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_est";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque Senai";
            this.panelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.TextBox txtCodSap;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddTurma;
        private System.Windows.Forms.Button btnAddEstoque;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private System.Windows.Forms.Button btnPosicao;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnLoca;
        private System.Windows.Forms.Button btnMov;
        private System.Windows.Forms.Button btnSaiMat;
    }
}

