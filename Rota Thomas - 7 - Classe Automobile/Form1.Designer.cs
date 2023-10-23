namespace Rota_Thomas___7___Classe_Automobile
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
			accelleratore=new Button();
			freno=new Button();
			marciaSu=new Button();
			marciaGiu=new Button();
			labelMarce=new Label();
			onOff=new Button();
			labelOnOff=new Label();
			labelnMarcia=new Label();
			labelVelocita=new Label();
			labelNMarce=new Label();
			buttonGuidaAuto=new Button();
			SuspendLayout();
			// 
			// accelleratore
			// 
			accelleratore.Location=new Point(317, 540);
			accelleratore.Margin=new Padding(3, 4, 3, 4);
			accelleratore.Name="accelleratore";
			accelleratore.Size=new Size(103, 37);
			accelleratore.TabIndex=0;
			accelleratore.Text="Acceleratore";
			accelleratore.UseVisualStyleBackColor=true;
			accelleratore.Click+=accelleratore_Click;
			// 
			// freno
			// 
			freno.Location=new Point(440, 540);
			freno.Margin=new Padding(3, 4, 3, 4);
			freno.Name="freno";
			freno.Size=new Size(103, 37);
			freno.TabIndex=1;
			freno.Text="Freno";
			freno.UseVisualStyleBackColor=true;
			freno.Click+=freno_Click;
			// 
			// marciaSu
			// 
			marciaSu.Font=new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
			marciaSu.Location=new Point(609, 436);
			marciaSu.Margin=new Padding(3, 4, 3, 4);
			marciaSu.Name="marciaSu";
			marciaSu.Size=new Size(53, 69);
			marciaSu.TabIndex=2;
			marciaSu.Text="↑";
			marciaSu.UseVisualStyleBackColor=true;
			marciaSu.Click+=marciaSu_Click;
			// 
			// marciaGiu
			// 
			marciaGiu.Font=new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
			marciaGiu.Location=new Point(609, 508);
			marciaGiu.Margin=new Padding(3, 4, 3, 4);
			marciaGiu.Name="marciaGiu";
			marciaGiu.Size=new Size(53, 69);
			marciaGiu.TabIndex=3;
			marciaGiu.Text="↓";
			marciaGiu.UseVisualStyleBackColor=true;
			marciaGiu.Click+=marciaGiu_Click;
			// 
			// labelMarce
			// 
			labelMarce.AutoSize=true;
			labelMarce.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelMarce.Location=new Point(606, 404);
			labelMarce.Name="labelMarce";
			labelMarce.Size=new Size(66, 28);
			labelMarce.TabIndex=4;
			labelMarce.Text="Marce";
			// 
			// onOff
			// 
			onOff.Font=new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
			onOff.Location=new Point(610, 317);
			onOff.Margin=new Padding(3, 4, 3, 4);
			onOff.Name="onOff";
			onOff.Size=new Size(51, 65);
			onOff.TabIndex=5;
			onOff.Text="\u23fc";
			onOff.UseVisualStyleBackColor=true;
			onOff.Click+=onOff_Click;
			// 
			// labelOnOff
			// 
			labelOnOff.AutoSize=true;
			labelOnOff.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			labelOnOff.Location=new Point(685, 339);
			labelOnOff.Name="labelOnOff";
			labelOnOff.Size=new Size(48, 32);
			labelOnOff.TabIndex=6;
			labelOnOff.Text="Off";
			// 
			// labelnMarcia
			// 
			labelnMarcia.AutoSize=true;
			labelnMarcia.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			labelnMarcia.Location=new Point(669, 479);
			labelnMarcia.Name="labelnMarcia";
			labelnMarcia.Size=new Size(0, 41);
			labelnMarcia.TabIndex=7;
			// 
			// labelVelocita
			// 
			labelVelocita.AutoSize=true;
			labelVelocita.Font=new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
			labelVelocita.Location=new Point(390, 320);
			labelVelocita.Name="labelVelocita";
			labelVelocita.Size=new Size(97, 60);
			labelVelocita.TabIndex=8;
			labelVelocita.Text="000";
			// 
			// labelNMarce
			// 
			labelNMarce.AutoSize=true;
			labelNMarce.Font=new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			labelNMarce.Location=new Point(685, 465);
			labelNMarce.Name="labelNMarce";
			labelNMarce.Size=new Size(0, 54);
			labelNMarce.TabIndex=9;
			// 
			// buttonGuidaAuto
			// 
			buttonGuidaAuto.Location=new Point(738, 559);
			buttonGuidaAuto.Name="buttonGuidaAuto";
			buttonGuidaAuto.Size=new Size(164, 29);
			buttonGuidaAuto.TabIndex=10;
			buttonGuidaAuto.Text="Guida Automatica";
			buttonGuidaAuto.UseVisualStyleBackColor=true;
			buttonGuidaAuto.Click+=buttonGuidaAuto_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions=new SizeF(8F, 20F);
			AutoScaleMode=AutoScaleMode.Font;
			ClientSize=new Size(914, 600);
			Controls.Add(buttonGuidaAuto);
			Controls.Add(labelNMarce);
			Controls.Add(labelVelocita);
			Controls.Add(labelnMarcia);
			Controls.Add(labelOnOff);
			Controls.Add(onOff);
			Controls.Add(labelMarce);
			Controls.Add(marciaGiu);
			Controls.Add(marciaSu);
			Controls.Add(freno);
			Controls.Add(accelleratore);
			Margin=new Padding(3, 4, 3, 4);
			Name="Form1";
			Text="Form1";
			Load+=Form1_Load;
			ResumeLayout(false);
			PerformLayout();
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
		private Button buttonGuidaAuto;
	}
}