namespace VendasApp.Forms.Generico
{
    partial class FrmCrudGenerico
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btProximo = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btProximo);
            this.panel1.Controls.Add(this.btAnterior);
            this.panel1.Controls.Add(this.btExcluir);
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.btIncluir);
            this.panel1.Controls.Add(this.btPesquisar);
            this.panel1.Controls.Add(this.btLocalizar);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 42);
            this.panel1.TabIndex = 0;
            // 
            // btProximo
            // 
            this.btProximo.Image = global::VendasApp.Properties.Resources.proximo_registro;
            this.btProximo.Location = new System.Drawing.Point(259, 3);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(36, 35);
            this.btProximo.TabIndex = 6;
            this.btProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btProximo.UseVisualStyleBackColor = true;
            this.btProximo.Click += new System.EventHandler(this.btProximo_Click);
            // 
            // btAnterior
            // 
            this.btAnterior.Image = global::VendasApp.Properties.Resources.anterior;
            this.btAnterior.Location = new System.Drawing.Point(217, 3);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(36, 35);
            this.btAnterior.TabIndex = 5;
            this.btAnterior.UseVisualStyleBackColor = true;
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = global::VendasApp.Properties.Resources.excluir;
            this.btExcluir.Location = new System.Drawing.Point(175, 3);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(36, 35);
            this.btExcluir.TabIndex = 4;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.brExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::VendasApp.Properties.Resources.salvar;
            this.btSalvar.Location = new System.Drawing.Point(133, 3);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(36, 35);
            this.btSalvar.TabIndex = 3;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Image = global::VendasApp.Properties.Resources.incluir;
            this.btIncluir.Location = new System.Drawing.Point(91, 3);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(36, 35);
            this.btIncluir.TabIndex = 2;
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = global::VendasApp.Properties.Resources.pesquisar;
            this.btPesquisar.Location = new System.Drawing.Point(50, 3);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(36, 35);
            this.btPesquisar.TabIndex = 1;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Image = global::VendasApp.Properties.Resources.icons8_search_24;
            this.btLocalizar.Location = new System.Drawing.Point(11, 3);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(33, 35);
            this.btLocalizar.TabIndex = 0;
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // FrmCrudGenerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCrudGenerico";
            this.Text = "FrmCrudGenerico";
            this.Shown += new System.EventHandler(this.FrmCrudGenerico_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Button btProximo;
    }
}