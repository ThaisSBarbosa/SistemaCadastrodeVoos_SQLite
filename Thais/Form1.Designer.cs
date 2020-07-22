namespace Thais
{
    partial class acme_form
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
            this.listviewdados = new System.Windows.Forms.ListView();
            this.col_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Captura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_NiveldeDor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnincluir = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.panelincluirexcluir = new System.Windows.Forms.Panel();
            this.paneldetalhes = new System.Windows.Forms.Panel();
            this.rbcapturanao = new System.Windows.Forms.RadioButton();
            this.rbcapturasim = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtniveldor = new System.Windows.Forms.TextBox();
            this.txtdistancia = new System.Windows.Forms.TextBox();
            this.txtcusto = new System.Windows.Forms.TextBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.panelincluirexcluir.SuspendLayout();
            this.paneldetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewdados
            // 
            this.listviewdados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Data,
            this.col_Captura,
            this.col_NiveldeDor});
            this.listviewdados.HideSelection = false;
            this.listviewdados.Location = new System.Drawing.Point(37, 26);
            this.listviewdados.MultiSelect = false;
            this.listviewdados.Name = "listviewdados";
            this.listviewdados.Size = new System.Drawing.Size(280, 383);
            this.listviewdados.TabIndex = 0;
            this.listviewdados.UseCompatibleStateImageBehavior = false;
            this.listviewdados.View = System.Windows.Forms.View.Details;
            this.listviewdados.Click += new System.EventHandler(this.listviewdados_Click);
            // 
            // col_Data
            // 
            this.col_Data.Text = "Data";
            this.col_Data.Width = 90;
            // 
            // col_Captura
            // 
            this.col_Captura.Text = "Captura";
            this.col_Captura.Width = 90;
            // 
            // col_NiveldeDor
            // 
            this.col_NiveldeDor.Text = "Nivel de Dor";
            this.col_NiveldeDor.Width = 90;
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(29, 13);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(109, 36);
            this.btnincluir.TabIndex = 1;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(180, 13);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(109, 36);
            this.btnexcluir.TabIndex = 2;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(180, 282);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(109, 36);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(29, 282);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(109, 36);
            this.btnsalvar.TabIndex = 3;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // panelincluirexcluir
            // 
            this.panelincluirexcluir.Controls.Add(this.btnexcluir);
            this.panelincluirexcluir.Controls.Add(this.btnincluir);
            this.panelincluirexcluir.Location = new System.Drawing.Point(322, 13);
            this.panelincluirexcluir.Name = "panelincluirexcluir";
            this.panelincluirexcluir.Size = new System.Drawing.Size(317, 62);
            this.panelincluirexcluir.TabIndex = 5;
            // 
            // paneldetalhes
            // 
            this.paneldetalhes.Controls.Add(this.rbcapturanao);
            this.paneldetalhes.Controls.Add(this.rbcapturasim);
            this.paneldetalhes.Controls.Add(this.label5);
            this.paneldetalhes.Controls.Add(this.label4);
            this.paneldetalhes.Controls.Add(this.label3);
            this.paneldetalhes.Controls.Add(this.label2);
            this.paneldetalhes.Controls.Add(this.label1);
            this.paneldetalhes.Controls.Add(this.txtniveldor);
            this.paneldetalhes.Controls.Add(this.txtdistancia);
            this.paneldetalhes.Controls.Add(this.txtcusto);
            this.paneldetalhes.Controls.Add(this.txtdata);
            this.paneldetalhes.Controls.Add(this.btncancelar);
            this.paneldetalhes.Controls.Add(this.btnsalvar);
            this.paneldetalhes.Location = new System.Drawing.Point(322, 91);
            this.paneldetalhes.Name = "paneldetalhes";
            this.paneldetalhes.Size = new System.Drawing.Size(317, 327);
            this.paneldetalhes.TabIndex = 6;
            // 
            // rbcapturanao
            // 
            this.rbcapturanao.AutoSize = true;
            this.rbcapturanao.Location = new System.Drawing.Point(180, 170);
            this.rbcapturanao.Name = "rbcapturanao";
            this.rbcapturanao.Size = new System.Drawing.Size(45, 17);
            this.rbcapturanao.TabIndex = 15;
            this.rbcapturanao.TabStop = true;
            this.rbcapturanao.Text = "Não";
            this.rbcapturanao.UseVisualStyleBackColor = true;
            this.rbcapturanao.CheckedChanged += new System.EventHandler(this.rbcapturanao_CheckedChanged);
            this.rbcapturanao.Click += new System.EventHandler(this.rbcapturanao_Click);
            // 
            // rbcapturasim
            // 
            this.rbcapturasim.AutoSize = true;
            this.rbcapturasim.Location = new System.Drawing.Point(122, 170);
            this.rbcapturasim.Name = "rbcapturasim";
            this.rbcapturasim.Size = new System.Drawing.Size(42, 17);
            this.rbcapturasim.TabIndex = 14;
            this.rbcapturasim.TabStop = true;
            this.rbcapturasim.Text = "Sim";
            this.rbcapturasim.UseVisualStyleBackColor = true;
            this.rbcapturasim.CheckedChanged += new System.EventHandler(this.rbcapturasim_CheckedChanged);
            this.rbcapturasim.Click += new System.EventHandler(this.rbcapturasim_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nível de Dor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Captura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Distância";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Custo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data";
            // 
            // txtniveldor
            // 
            this.txtniveldor.Location = new System.Drawing.Point(122, 214);
            this.txtniveldor.Name = "txtniveldor";
            this.txtniveldor.Size = new System.Drawing.Size(165, 20);
            this.txtniveldor.TabIndex = 8;
            this.txtniveldor.TextChanged += new System.EventHandler(this.txtniveldor_TextChanged);
            this.txtniveldor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtniveldor_KeyPress);
            // 
            // txtdistancia
            // 
            this.txtdistancia.Location = new System.Drawing.Point(122, 123);
            this.txtdistancia.Name = "txtdistancia";
            this.txtdistancia.Size = new System.Drawing.Size(165, 20);
            this.txtdistancia.TabIndex = 7;
            this.txtdistancia.TextChanged += new System.EventHandler(this.txtdistancia_TextChanged);
            this.txtdistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdistancia_KeyPress);
            // 
            // txtcusto
            // 
            this.txtcusto.Location = new System.Drawing.Point(122, 73);
            this.txtcusto.Name = "txtcusto";
            this.txtcusto.Size = new System.Drawing.Size(165, 20);
            this.txtcusto.TabIndex = 6;
            this.txtcusto.TextChanged += new System.EventHandler(this.txtcusto_TextChanged);
            this.txtcusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcusto_KeyPress);
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(122, 23);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(165, 20);
            this.txtdata.TabIndex = 5;
            this.txtdata.TextChanged += new System.EventHandler(this.txtdata_TextChanged);
            this.txtdata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdata_KeyPress);
            // 
            // acme_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(653, 435);
            this.Controls.Add(this.paneldetalhes);
            this.Controls.Add(this.panelincluirexcluir);
            this.Controls.Add(this.listviewdados);
            this.Name = "acme_form";
            this.Text = "Acme Flight Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelincluirexcluir.ResumeLayout(false);
            this.paneldetalhes.ResumeLayout(false);
            this.paneldetalhes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewdados;
        private System.Windows.Forms.ColumnHeader col_Data;
        private System.Windows.Forms.ColumnHeader col_Captura;
        private System.Windows.Forms.ColumnHeader col_NiveldeDor;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Panel panelincluirexcluir;
        private System.Windows.Forms.Panel paneldetalhes;
        private System.Windows.Forms.RadioButton rbcapturanao;
        private System.Windows.Forms.RadioButton rbcapturasim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtniveldor;
        private System.Windows.Forms.TextBox txtdistancia;
        private System.Windows.Forms.TextBox txtcusto;
        private System.Windows.Forms.TextBox txtdata;
    }
}

