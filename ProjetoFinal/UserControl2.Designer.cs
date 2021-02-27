namespace ProjetoFinal
{
    partial class UserControl2
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.pItem2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pItem1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pItem2.SuspendLayout();
            this.pItem1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buscar";
            // 
            // pItem2
            // 
            this.pItem2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pItem2.Controls.Add(this.label3);
            this.pItem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pItem2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pItem2.Location = new System.Drawing.Point(3, 91);
            this.pItem2.Name = "pItem2";
            this.pItem2.Size = new System.Drawing.Size(204, 82);
            this.pItem2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cadastrar";
            // 
            // pItem1
            // 
            this.pItem1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pItem1.Controls.Add(this.label2);
            this.pItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pItem1.Location = new System.Drawing.Point(3, 3);
            this.pItem1.Name = "pItem1";
            this.pItem1.Size = new System.Drawing.Size(204, 82);
            this.pItem1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pItem1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pItem2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 264);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 403);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ProjetoFinal.Properties.Resources.papel_de_parede_adesivo_gourmet_paes_go_001;
            this.panel2.Controls.Add(this.panelHome);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 403);
            this.panel2.TabIndex = 6;
            // 
            // panelHome
            // 
            this.panelHome.BackgroundImage = global::ProjetoFinal.Properties.Resources.papel_de_parede_adesivo_gourmet_paes_go_001;
            this.panelHome.Controls.Add(this.txtTel);
            this.panelHome.Controls.Add(this.label6);
            this.panelHome.Controls.Add(this.btnCad);
            this.panelHome.Controls.Add(this.txtEnd);
            this.panelHome.Controls.Add(this.txtCpf);
            this.panelHome.Controls.Add(this.txtNome);
            this.panelHome.Controls.Add(this.label10);
            this.panelHome.Controls.Add(this.label9);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.label5);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(797, 403);
            this.panelHome.TabIndex = 14;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(390, 257);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(244, 32);
            this.txtTel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefone:";
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.btnCad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.Location = new System.Drawing.Point(449, 303);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(124, 46);
            this.btnCad.TabIndex = 12;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Location = new System.Drawing.Point(390, 192);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(244, 32);
            this.txtEnd.TabIndex = 11;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(390, 127);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(244, 32);
            this.txtCpf.TabIndex = 10;
            this.txtCpf.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(390, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(244, 32);
            this.txtNome.TabIndex = 9;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(266, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 31);
            this.label10.TabIndex = 8;
            this.label10.Text = "Endereço:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(323, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 31);
            this.label9.TabIndex = 7;
            this.label9.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 40);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cadastrar Cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(240, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 173);
            this.dataGridView1.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(409, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 32);
            this.textBox1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(320, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(359, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 40);
            this.label7.TabIndex = 5;
            this.label7.Text = "Buscar Cliente";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(797, 403);
            this.pItem2.ResumeLayout(false);
            this.pItem2.PerformLayout();
            this.pItem1.ResumeLayout(false);
            this.pItem1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pItem2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label6;
    }
}
