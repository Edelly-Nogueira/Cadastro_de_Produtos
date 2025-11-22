namespace GerenciamentoProduto.Telas
{
    partial class FrmCadastro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.lblquant = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(31, 33);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(544, 37);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Cadastro de Produto – Gerenciamento";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(107, 126);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(56, 21);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome:";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(107, 162);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(80, 21);
            this.lbldesc.TabIndex = 2;
            this.lbldesc.Text = "Descrição:";
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreco.Location = new System.Drawing.Point(107, 197);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(52, 21);
            this.lblpreco.TabIndex = 3;
            this.lblpreco.Text = "Preço:";
            // 
            // lblquant
            // 
            this.lblquant.AutoSize = true;
            this.lblquant.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquant.Location = new System.Drawing.Point(107, 232);
            this.lblquant.Name = "lblquant";
            this.lblquant.Size = new System.Drawing.Size(94, 21);
            this.lblquant.TabIndex = 4;
            this.lblquant.Text = "Quantidade:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(106, 292);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(368, 292);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(164, 23);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar Produtos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(229, 127);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(264, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(229, 163);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(264, 20);
            this.txtDescricao.TabIndex = 8;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(229, 198);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(264, 20);
            this.txtPreco.TabIndex = 9;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(229, 233);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(264, 20);
            this.txtQuantidade.TabIndex = 10;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 361);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblquant);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lbltitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastro";
            this.Text = "Gerenciador De Produtos";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Label lblquant;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQuantidade;
    }
}
