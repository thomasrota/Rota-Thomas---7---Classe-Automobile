namespace Rota_Thomas___7___Classe_Automobile
{
	partial class Form2
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
			labelNMarce=new Label();
			labelVelocita=new Label();
			labelnMarcia=new Label();
			labelOnOff=new Label();
			onOff=new Button();
			labelMarce=new Label();
			freno=new Button();
			accelleratore=new Button();
			SuspendLayout();
			// 
			// labelNMarce
			// 
			labelNMarce.AutoSize=true;
			labelNMarce.Font=new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			labelNMarce.Location=new Point(569, 312);
			labelNMarce.Name="labelNMarce";
			labelNMarce.Size=new Size(0, 54);
			labelNMarce.TabIndex=19;
			// 
			// labelVelocita
			// 
			labelVelocita.AutoSize=true;
			labelVelocita.Font=new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
			labelVelocita.Location=new Point(274, 167);
			labelVelocita.Name="labelVelocita";
			labelVelocita.Size=new Size(97, 60);
			labelVelocita.TabIndex=18;
			labelVelocita.Text="000";
			// 
			// labelnMarcia
			// 
			labelnMarcia.AutoSize=true;
			labelnMarcia.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			labelnMarcia.Location=new Point(553, 326);
			labelnMarcia.Name="labelnMarcia";
			labelnMarcia.Size=new Size(0, 41);
			labelnMarcia.TabIndex=17;
			// 
			// labelOnOff
			// 
			labelOnOff.AutoSize=true;
			labelOnOff.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			labelOnOff.Location=new Point(569, 186);
			labelOnOff.Name="labelOnOff";
			labelOnOff.Size=new Size(48, 32);
			labelOnOff.TabIndex=16;
			labelOnOff.Text="Off";
			// 
			// onOff
			// 
			onOff.Font=new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
			onOff.Location=new Point(494, 164);
			onOff.Margin=new Padding(3, 4, 3, 4);
			onOff.Name="onOff";
			onOff.Size=new Size(51, 65);
			onOff.TabIndex=15;
			onOff.Text="\u23fc";
			onOff.UseVisualStyleBackColor=true;
			onOff.Click+=onOff_Click;
			// 
			// labelMarce
			// 
			labelMarce.AutoSize=true;
			labelMarce.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelMarce.Location=new Point(481, 326);
			labelMarce.Name="labelMarce";
			labelMarce.Size=new Size(66, 28);
			labelMarce.TabIndex=14;
			labelMarce.Text="Marce";
			// 
			// freno
			// 
			freno.Location=new Point(324, 387);
			freno.Margin=new Padding(3, 4, 3, 4);
			freno.Name="freno";
			freno.Size=new Size(103, 37);
			freno.TabIndex=11;
			freno.Text="Freno";
			freno.UseVisualStyleBackColor=true;
			freno.Click+=freno_Click;
			// 
			// accelleratore
			// 
			accelleratore.Location=new Point(201, 387);
			accelleratore.Margin=new Padding(3, 4, 3, 4);
			accelleratore.Name="accelleratore";
			accelleratore.Size=new Size(103, 37);
			accelleratore.TabIndex=10;
			accelleratore.Text="Acceleratore";
			accelleratore.UseVisualStyleBackColor=true;
			accelleratore.Click+=accelleratore_Click;
			// 
			// Form2
			// 
			AutoScaleDimensions=new SizeF(8F, 20F);
			AutoScaleMode=AutoScaleMode.Font;
			ClientSize=new Size(800, 450);
			Controls.Add(labelNMarce);
			Controls.Add(labelVelocita);
			Controls.Add(labelnMarcia);
			Controls.Add(labelOnOff);
			Controls.Add(onOff);
			Controls.Add(labelMarce);
			Controls.Add(freno);
			Controls.Add(accelleratore);
			Name="Form2";
			Text="Form2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelNMarce;
		private Label labelVelocita;
		private Label labelnMarcia;
		private Label labelOnOff;
		private Button onOff;
		private Label labelMarce;
		private Button freno;
		private Button accelleratore;
	}
}