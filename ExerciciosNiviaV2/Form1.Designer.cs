﻿namespace ExerciciosNiviaV2
{
    partial class Form1
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtpar = new System.Windows.Forms.RichTextBox();
            this.lblpar = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnmudar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(125, 335);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(112, 45);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtpar
            // 
            this.txtpar.Location = new System.Drawing.Point(505, 132);
            this.txtpar.Name = "txtpar";
            this.txtpar.Size = new System.Drawing.Size(100, 96);
            this.txtpar.TabIndex = 1;
            this.txtpar.Text = "";
            // 
            // lblpar
            // 
            this.lblpar.AutoSize = true;
            this.lblpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpar.Location = new System.Drawing.Point(54, 127);
            this.lblpar.Name = "lblpar";
            this.lblpar.Size = new System.Drawing.Size(356, 24);
            this.lblpar.TabIndex = 2;
            this.lblpar.Text = "Os numeros nas posições pares são:";
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(306, 335);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(119, 45);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnmudar
            // 
            this.btnmudar.Location = new System.Drawing.Point(505, 335);
            this.btnmudar.Name = "btnmudar";
            this.btnmudar.Size = new System.Drawing.Size(112, 45);
            this.btnmudar.TabIndex = 4;
            this.btnmudar.Text = "Mudar";
            this.btnmudar.UseVisualStyleBackColor = true;
            this.btnmudar.Click += new System.EventHandler(this.btnmudar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(668, 335);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(109, 45);
            this.btnfechar.TabIndex = 5;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnmudar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.lblpar);
            this.Controls.Add(this.txtpar);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.RichTextBox txtpar;
        private System.Windows.Forms.Label lblpar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnmudar;
        private System.Windows.Forms.Button btnfechar;
    }
}

