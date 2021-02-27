namespace ProjetoFinal
{
    partial class UserControl1
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
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bntAltCon = new System.Windows.Forms.Button();
            this.txtAltTel = new System.Windows.Forms.TextBox();
            this.txtAltNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.txtAltEnd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pItem2.SuspendLayout();
            this.pItem1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.tabPage1.SuspendLayout();
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.panel3.Size = new System.Drawing.Size(210, 450);
            this.panel3.TabIndex = 5;
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(402, 60);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(244, 29);
            this.txtBusca.TabIndex = 9;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(311, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(398, 40);
            this.label7.TabIndex = 5;
            this.label7.Text = "Busca e alteração de cliente";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ProjetoFinal.Properties.Resources.papel_de_parede_adesivo_gourmet_paes_go_001;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.txtBusca);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(225, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 299);
            this.tabControl1.TabIndex = 25;
            this.tabControl1.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::ProjetoFinal.Properties.Resources.papel_de_parede_adesivo_gourmet_paes_go_001;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.btnRemover);
            this.tabPage2.Controls.Add(this.dgClientes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(551, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(315, 216);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 34);
            this.btnAlterar.TabIndex = 26;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemover.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(122, 216);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(110, 34);
            this.btnRemover.TabIndex = 25;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click_1);
            // 
            // dgClientes
            // 
            this.dgClientes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(0, 3);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.Size = new System.Drawing.Size(546, 194);
            this.dgClientes.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.tabPage1.BackgroundImage = global::ProjetoFinal.Properties.Resources.papel_de_parede_adesivo_gourmet_paes_go_001;
            this.tabPage1.Controls.Add(this.bntAltCon);
            this.tabPage1.Controls.Add(this.txtAltTel);
            this.tabPage1.Controls.Add(this.txtAltEnd);
            this.tabPage1.Controls.Add(this.txtAltNome);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(551, 273);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Alterar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bntAltCon
            // 
            this.bntAltCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.bntAltCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAltCon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntAltCon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAltCon.Location = new System.Drawing.Point(225, 199);
            this.bntAltCon.Name = "bntAltCon";
            this.bntAltCon.Size = new System.Drawing.Size(119, 49);
            this.bntAltCon.TabIndex = 32;
            this.bntAltCon.Text = "Confirma Alteração";
            this.bntAltCon.UseVisualStyleBackColor = false;
            this.bntAltCon.Click += new System.EventHandler(this.bntAltCon_Click);
            // 
            // txtAltTel
            // 
            this.txtAltTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltTel.Location = new System.Drawing.Point(115, 141);
            this.txtAltTel.Name = "txtAltTel";
            this.txtAltTel.Size = new System.Drawing.Size(400, 29);
            this.txtAltTel.TabIndex = 31;
            // 
            // txtAltNome
            // 
            this.txtAltNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltNome.Location = new System.Drawing.Point(115, 42);
            this.txtAltNome.Name = "txtAltNome";
            this.txtAltNome.Size = new System.Drawing.Size(400, 29);
            this.txtAltNome.TabIndex = 28;
            this.txtAltNome.TextChanged += new System.EventHandler(this.txtAltNome_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(313, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nome:";
            // 
            // txtAltEnd
            // 
            this.txtAltEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltEnd.Location = new System.Drawing.Point(115, 92);
            this.txtAltEnd.Name = "txtAltEnd";
            this.txtAltEnd.Size = new System.Drawing.Size(400, 29);
            this.txtAltEnd.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Endereço:";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.pItem2.ResumeLayout(false);
            this.pItem2.PerformLayout();
            this.pItem1.ResumeLayout(false);
            this.pItem1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pItem2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAltTel;
        private System.Windows.Forms.TextBox txtAltNome;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button bntAltCon;
        private System.Windows.Forms.TextBox txtAltEnd;
        private System.Windows.Forms.Label label10;
    }
}
