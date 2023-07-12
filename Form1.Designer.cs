
namespace Aula03Login
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuario2 = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblUsuario2 = new System.Windows.Forms.Label();
            this.btnSenha = new System.Windows.Forms.Button();
            this.panelSaldo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Aumentar = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(55, 143);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(342, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtUsuario2
            // 
            this.txtUsuario2.Location = new System.Drawing.Point(55, 242);
            this.txtUsuario2.Name = "txtUsuario2";
            this.txtUsuario2.PasswordChar = '*';
            this.txtUsuario2.Size = new System.Drawing.Size(342, 20);
            this.txtUsuario2.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(166, 124);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(118, 16);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Digite seu usuário:";
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUsuario2
            // 
            this.lblUsuario2.AutoSize = true;
            this.lblUsuario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario2.Location = new System.Drawing.Point(166, 223);
            this.lblUsuario2.Name = "lblUsuario2";
            this.lblUsuario2.Size = new System.Drawing.Size(111, 16);
            this.lblUsuario2.TabIndex = 3;
            this.lblUsuario2.Text = "Digite sua senha:";
            // 
            // btnSenha
            // 
            this.btnSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenha.Location = new System.Drawing.Point(150, 305);
            this.btnSenha.Name = "btnSenha";
            this.btnSenha.Size = new System.Drawing.Size(145, 52);
            this.btnSenha.TabIndex = 4;
            this.btnSenha.Text = "Conectar";
            this.btnSenha.UseVisualStyleBackColor = true;
            this.btnSenha.Click += new System.EventHandler(this.btnSenha_Click);
            // 
            // panelSaldo
            // 
            this.panelSaldo.Controls.Add(this.button1);
            this.panelSaldo.Controls.Add(this.Aumentar);
            this.panelSaldo.Controls.Add(this.textBox1);
            this.panelSaldo.Controls.Add(this.label1);
            this.panelSaldo.Location = new System.Drawing.Point(460, 86);
            this.panelSaldo.Name = "panelSaldo";
            this.panelSaldo.Size = new System.Drawing.Size(317, 314);
            this.panelSaldo.TabIndex = 5;
            this.panelSaldo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seu saldo: R$ 0";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Aumentar
            // 
            this.Aumentar.AutoSize = true;
            this.Aumentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aumentar.Location = new System.Drawing.Point(36, 156);
            this.Aumentar.Name = "Aumentar";
            this.Aumentar.Size = new System.Drawing.Size(84, 20);
            this.Aumentar.TabIndex = 3;
            this.Aumentar.Text = "Aumentar";
            this.Aumentar.UseVisualStyleBackColor = true;
            this.Aumentar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.panelSaldo);
            this.Controls.Add(this.btnSenha);
            this.Controls.Add(this.lblUsuario2);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario2);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSaldo.ResumeLayout(false);
            this.panelSaldo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtUsuario2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblUsuario2;
        private System.Windows.Forms.Button btnSenha;
        private System.Windows.Forms.Panel panelSaldo;
        private System.Windows.Forms.CheckBox Aumentar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

