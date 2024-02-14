using System;

namespace Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textProcurar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewContatos = new System.Windows.Forms.ListView();
            this.btncCrescente = new System.Windows.Forms.Button();
            this.btnDecrecente = new System.Windows.Forms.Button();
            this.bntCalcel = new System.Windows.Forms.Button();
            this.lblContagemUsuarios = new System.Windows.Forms.Label();
            this.btnMostrarErros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(71, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(750, 13);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 34);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(16, 25);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(172, 22);
            this.textName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(303, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname:";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(207, 25);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(254, 22);
            this.textSurname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(596, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-mail:";
            // 
            // textEmail
            // 
            this.textEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textEmail.Location = new System.Drawing.Point(480, 25);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(254, 22);
            this.textEmail.TabIndex = 2;
            // 
            // textProcurar
            // 
            this.textProcurar.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textProcurar.Location = new System.Drawing.Point(113, 167);
            this.textProcurar.Name = "textProcurar";
            this.textProcurar.Size = new System.Drawing.Size(254, 22);
            this.textProcurar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(509, 160);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 36);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Search";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search e-mail:";
            // 
            // listViewContatos
            // 
            this.listViewContatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listViewContatos.HideSelection = false;
            this.listViewContatos.Location = new System.Drawing.Point(16, 210);
            this.listViewContatos.Name = "listViewContatos";
            this.listViewContatos.Size = new System.Drawing.Size(583, 232);
            this.listViewContatos.TabIndex = 4;
            this.listViewContatos.UseCompatibleStateImageBehavior = false;
            // 
            // btncCrescente
            // 
            this.btncCrescente.Location = new System.Drawing.Point(16, 460);
            this.btncCrescente.Name = "btncCrescente";
            this.btncCrescente.Size = new System.Drawing.Size(102, 30);
            this.btncCrescente.TabIndex = 5;
            this.btncCrescente.Text = "Increasing";
            this.btncCrescente.UseVisualStyleBackColor = true;
            this.btncCrescente.Click += new System.EventHandler(this.btncCrescente_Click);
            // 
            // btnDecrecente
            // 
            this.btnDecrecente.Location = new System.Drawing.Point(134, 460);
            this.btnDecrecente.Name = "btnDecrecente";
            this.btnDecrecente.Size = new System.Drawing.Size(102, 30);
            this.btnDecrecente.TabIndex = 5;
            this.btnDecrecente.Text = "Decreaing";
            this.btnDecrecente.UseVisualStyleBackColor = true;
            this.btnDecrecente.Click += new System.EventHandler(this.btnDecrecente_Click);
            // 
            // bntCalcel
            // 
            this.bntCalcel.Location = new System.Drawing.Point(494, 460);
            this.bntCalcel.Name = "bntCalcel";
            this.bntCalcel.Size = new System.Drawing.Size(105, 30);
            this.bntCalcel.TabIndex = 6;
            this.bntCalcel.Text = "Calcel";
            this.bntCalcel.UseVisualStyleBackColor = true;
            this.bntCalcel.Click += new System.EventHandler(this.bntCalcel_Click);
            // 
            // lblContagemUsuarios
            // 
            this.lblContagemUsuarios.AutoSize = true;
            this.lblContagemUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContagemUsuarios.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblContagemUsuarios.Location = new System.Drawing.Point(12, 517);
            this.lblContagemUsuarios.Name = "lblContagemUsuarios";
            this.lblContagemUsuarios.Size = new System.Drawing.Size(134, 20);
            this.lblContagemUsuarios.TabIndex = 8;
            this.lblContagemUsuarios.Text = "Total de usuario:";
            // 
            // btnMostrarErros
            // 
            this.btnMostrarErros.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMostrarErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarErros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarErros.Location = new System.Drawing.Point(765, 460);
            this.btnMostrarErros.Name = "btnMostrarErros";
            this.btnMostrarErros.Size = new System.Drawing.Size(156, 35);
            this.btnMostrarErros.TabIndex = 10;
            this.btnMostrarErros.Text = "ErrorMessages";
            this.btnMostrarErros.UseVisualStyleBackColor = false;
            this.btnMostrarErros.Click += new System.EventHandler(this.btnMostrarErros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(965, 568);
            this.Controls.Add(this.btnMostrarErros);
            this.Controls.Add(this.lblContagemUsuarios);
            this.Controls.Add(this.bntCalcel);
            this.Controls.Add(this.btnDecrecente);
            this.Controls.Add(this.btncCrescente);
            this.Controls.Add(this.listViewContatos);
            this.Controls.Add(this.textProcurar);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button teste;
        private System.Windows.Forms.TextBox textProcurar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewContatos;
        private System.Windows.Forms.RadioButton btnIncreasing;
        private System.Windows.Forms.Button btncCrescente;
        private System.Windows.Forms.Button btnDecrecente;
        private System.Windows.Forms.Button bntCalcel;
        private System.Windows.Forms.Label lblContagemUsuarios;
        private System.Windows.Forms.Button btnMostrarErros;
    }
}

