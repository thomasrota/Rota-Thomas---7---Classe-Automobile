﻿namespace Rota_Thomas___7___Classe_Automobile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.accelleratore = new System.Windows.Forms.Button();
            this.freno = new System.Windows.Forms.Button();
            this.marciaSu = new System.Windows.Forms.Button();
            this.marciaGiu = new System.Windows.Forms.Button();
            this.labelMarce = new System.Windows.Forms.Label();
            this.onOff = new System.Windows.Forms.Button();
            this.labelOnOff = new System.Windows.Forms.Label();
            this.labelnMarcia = new System.Windows.Forms.Label();
            this.labelVelocita = new System.Windows.Forms.Label();
            this.labelNMarce = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accelleratore
            // 
            this.accelleratore.Location = new System.Drawing.Point(277, 405);
            this.accelleratore.Name = "accelleratore";
            this.accelleratore.Size = new System.Drawing.Size(90, 28);
            this.accelleratore.TabIndex = 0;
            this.accelleratore.Text = "Acceleratore";
            this.accelleratore.UseVisualStyleBackColor = true;
            this.accelleratore.Click += new System.EventHandler(this.accelleratore_Click);
            // 
            // freno
            // 
            this.freno.Location = new System.Drawing.Point(385, 405);
            this.freno.Name = "freno";
            this.freno.Size = new System.Drawing.Size(90, 28);
            this.freno.TabIndex = 1;
            this.freno.Text = "Freno";
            this.freno.UseVisualStyleBackColor = true;
            this.freno.Click += new System.EventHandler(this.freno_Click);
            // 
            // marciaSu
            // 
            this.marciaSu.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marciaSu.Location = new System.Drawing.Point(533, 327);
            this.marciaSu.Name = "marciaSu";
            this.marciaSu.Size = new System.Drawing.Size(46, 52);
            this.marciaSu.TabIndex = 2;
            this.marciaSu.Text = "↑";
            this.marciaSu.UseVisualStyleBackColor = true;
            this.marciaSu.Click += new System.EventHandler(this.marciaSu_Click);
            // 
            // marciaGiu
            // 
            this.marciaGiu.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marciaGiu.Location = new System.Drawing.Point(533, 381);
            this.marciaGiu.Name = "marciaGiu";
            this.marciaGiu.Size = new System.Drawing.Size(46, 52);
            this.marciaGiu.TabIndex = 3;
            this.marciaGiu.Text = "↓";
            this.marciaGiu.UseVisualStyleBackColor = true;
            this.marciaGiu.Click += new System.EventHandler(this.marciaGiu_Click);
            // 
            // labelMarce
            // 
            this.labelMarce.AutoSize = true;
            this.labelMarce.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMarce.Location = new System.Drawing.Point(530, 303);
            this.labelMarce.Name = "labelMarce";
            this.labelMarce.Size = new System.Drawing.Size(53, 21);
            this.labelMarce.TabIndex = 4;
            this.labelMarce.Text = "Marce";
            // 
            // onOff
            // 
            this.onOff.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.onOff.Location = new System.Drawing.Point(534, 238);
            this.onOff.Name = "onOff";
            this.onOff.Size = new System.Drawing.Size(45, 49);
            this.onOff.TabIndex = 5;
            this.onOff.Text = "⏼";
            this.onOff.UseVisualStyleBackColor = true;
            this.onOff.Click += new System.EventHandler(this.onOff_Click);
            // 
            // labelOnOff
            // 
            this.labelOnOff.AutoSize = true;
            this.labelOnOff.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOnOff.Location = new System.Drawing.Point(599, 254);
            this.labelOnOff.Name = "labelOnOff";
            this.labelOnOff.Size = new System.Drawing.Size(38, 25);
            this.labelOnOff.TabIndex = 6;
            this.labelOnOff.Text = "Off";
            // 
            // labelnMarcia
            // 
            this.labelnMarcia.AutoSize = true;
            this.labelnMarcia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelnMarcia.Location = new System.Drawing.Point(585, 359);
            this.labelnMarcia.Name = "labelnMarcia";
            this.labelnMarcia.Size = new System.Drawing.Size(0, 32);
            this.labelnMarcia.TabIndex = 7;
            // 
            // labelVelocita
            // 
            this.labelVelocita.AutoSize = true;
            this.labelVelocita.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVelocita.Location = new System.Drawing.Point(341, 240);
            this.labelVelocita.Name = "labelVelocita";
            this.labelVelocita.Size = new System.Drawing.Size(77, 47);
            this.labelVelocita.TabIndex = 8;
            this.labelVelocita.Text = "000";
            // 
            // labelNMarce
            // 
            this.labelNMarce.AutoSize = true;
            this.labelNMarce.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNMarce.Location = new System.Drawing.Point(599, 349);
            this.labelNMarce.Name = "labelNMarce";
            this.labelNMarce.Size = new System.Drawing.Size(0, 45);
            this.labelNMarce.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNMarce);
            this.Controls.Add(this.labelVelocita);
            this.Controls.Add(this.labelnMarcia);
            this.Controls.Add(this.labelOnOff);
            this.Controls.Add(this.onOff);
            this.Controls.Add(this.labelMarce);
            this.Controls.Add(this.marciaGiu);
            this.Controls.Add(this.marciaSu);
            this.Controls.Add(this.freno);
            this.Controls.Add(this.accelleratore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button accelleratore;
        private Button freno;
        private Button marciaSu;
        private Button marciaGiu;
        private Label labelMarce;
        private Button onOff;
        private Label labelOnOff;
        private Label labelnMarcia;
        private Label labelVelocita;
        private Label labelNMarce;
    }
}