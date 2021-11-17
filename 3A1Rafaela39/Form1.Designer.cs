
namespace _3A1Rafaela39
{
    partial class Form1
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
            this.BtnInserir = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtJogo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnInserir
            // 
            this.BtnInserir.Location = new System.Drawing.Point(12, 180);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 33);
            this.BtnInserir.TabIndex = 0;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = true;
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(93, 180);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 33);
            this.BtnListar.TabIndex = 1;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(6, 19);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(15, 14);
            this.CheckBox1.TabIndex = 2;
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(174, 180);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 33);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(255, 180);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 33);
            this.BtnExcluir.TabIndex = 4;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(12, 375);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(318, 44);
            this.BtnLimpar.TabIndex = 5;
            this.BtnLimpar.Text = "Limpar Tudo";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // Dgv
            // 
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(12, 219);
            this.Dgv.Name = "Dgv";
            this.Dgv.Size = new System.Drawing.Size(318, 150);
            this.Dgv.TabIndex = 6;
            this.Dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(81, 13);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Nome completo";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 48);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(169, 13);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Nome do jogo que deseja comprar";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(3, 39);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(53, 13);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "Endereço";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.CheckBox1);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 84);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comprar para presente";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(6, 55);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(306, 20);
            this.txtEndereco.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(318, 20);
            this.txtNome.TabIndex = 11;
            // 
            // txtJogo
            // 
            this.txtJogo.Location = new System.Drawing.Point(12, 64);
            this.txtJogo.Name = "txtJogo";
            this.txtJogo.Size = new System.Drawing.Size(318, 20);
            this.txtJogo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.txtJogo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.BtnInserir);
            this.Name = "Form1";
            this.Text = "Comprar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtJogo;
    }
}

