namespace VendasApp.Forms.Crud
{
    partial class FrmCliente
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
            this.components = new System.ComponentModel.Container();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextNome = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextCodigoCidade = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextDocumento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextCodigo = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.maskedTextNome);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 390);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome ";
            // 
            // maskedTextNome
            // 
            this.maskedTextNome.Location = new System.Drawing.Point(14, 93);
            this.maskedTextNome.Name = "maskedTextNome";
            this.maskedTextNome.Size = new System.Drawing.Size(376, 20);
            this.maskedTextNome.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.maskedTextCodigoCidade);
            this.panel3.Controls.Add(this.checkBoxAtivo);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dateTimePickerData);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.maskedTextDocumento);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.maskedTextCodigo);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 390);
            this.panel3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Codigo Cidade";
            // 
            // maskedTextCodigoCidade
            // 
            this.maskedTextCodigoCidade.Location = new System.Drawing.Point(13, 254);
            this.maskedTextCodigoCidade.Name = "maskedTextCodigoCidade";
            this.maskedTextCodigoCidade.Size = new System.Drawing.Size(100, 20);
            this.maskedTextCodigoCidade.TabIndex = 17;
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Location = new System.Drawing.Point(17, 307);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(50, 17);
            this.checkBoxAtivo.TabIndex = 15;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "DataNascimento";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(14, 203);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerData.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Documento";
            // 
            // maskedTextDocumento
            // 
            this.maskedTextDocumento.Location = new System.Drawing.Point(13, 151);
            this.maskedTextDocumento.Name = "maskedTextDocumento";
            this.maskedTextDocumento.Size = new System.Drawing.Size(231, 20);
            this.maskedTextDocumento.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // maskedTextCodigo
            // 
            this.maskedTextCodigo.Location = new System.Drawing.Point(15, 43);
            this.maskedTextCodigo.Name = "maskedTextCodigo";
            this.maskedTextCodigo.Size = new System.Drawing.Size(86, 20);
            this.maskedTextCodigo.TabIndex = 5;
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "FrmCadastroCliente";
            this.Text = "FrmCadastroCliente";
            this.Load += new System.EventHandler(this.FrmCadastroCliente_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextNome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextCodigo;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.MaskedTextBox maskedTextCodigoCidade;
        private System.Windows.Forms.Label label5;
    }
}