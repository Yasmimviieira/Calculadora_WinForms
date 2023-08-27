namespace Calculadora_MediaAnual
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
            grpnotaAnual = new GroupBox();
            btnSair1 = new Button();
            lblnota4 = new Label();
            lblnota3 = new Label();
            lblnota2 = new Label();
            lblnota1 = new Label();
            btnCalcularMedia = new Button();
            txtnota4 = new TextBox();
            txtnota3 = new TextBox();
            txtnota2 = new TextBox();
            txtnota1 = new TextBox();
            btnSair = new Button();
            grpExame = new GroupBox();
            btnmediaFinal = new Button();
            lblnotaExame = new Label();
            lblmediaAnual = new Label();
            txtnotaExame = new TextBox();
            txtmediaAnual = new TextBox();
            grpnotaAnual.SuspendLayout();
            grpExame.SuspendLayout();
            SuspendLayout();
            // 
            // grpnotaAnual
            // 
            grpnotaAnual.Controls.Add(btnSair1);
            grpnotaAnual.Controls.Add(lblnota4);
            grpnotaAnual.Controls.Add(lblnota3);
            grpnotaAnual.Controls.Add(lblnota2);
            grpnotaAnual.Controls.Add(lblnota1);
            grpnotaAnual.Controls.Add(btnCalcularMedia);
            grpnotaAnual.Controls.Add(txtnota4);
            grpnotaAnual.Controls.Add(txtnota3);
            grpnotaAnual.Controls.Add(txtnota2);
            grpnotaAnual.Controls.Add(txtnota1);
            grpnotaAnual.Location = new Point(2, 0);
            grpnotaAnual.Name = "grpnotaAnual";
            grpnotaAnual.Size = new Size(449, 459);
            grpnotaAnual.TabIndex = 0;
            grpnotaAnual.TabStop = false;
            grpnotaAnual.Text = "Nota Anual";
            // 
            // btnSair1
            // 
            btnSair1.Location = new Point(367, 12);
            btnSair1.Name = "btnSair1";
            btnSair1.Size = new Size(78, 29);
            btnSair1.TabIndex = 7;
            btnSair1.Text = "Sair";
            btnSair1.UseVisualStyleBackColor = true;
            btnSair1.Click += btnSair1_Click;
            // 
            // lblnota4
            // 
            lblnota4.AutoSize = true;
            lblnota4.Location = new Point(74, 267);
            lblnota4.Name = "lblnota4";
            lblnota4.Size = new Size(57, 20);
            lblnota4.TabIndex = 8;
            lblnota4.Text = "Nota 4:";
            // 
            // lblnota3
            // 
            lblnota3.AutoSize = true;
            lblnota3.Location = new Point(74, 205);
            lblnota3.Name = "lblnota3";
            lblnota3.Size = new Size(57, 20);
            lblnota3.TabIndex = 7;
            lblnota3.Text = "Nota 3:";
            // 
            // lblnota2
            // 
            lblnota2.AutoSize = true;
            lblnota2.Location = new Point(74, 142);
            lblnota2.Name = "lblnota2";
            lblnota2.Size = new Size(57, 20);
            lblnota2.TabIndex = 6;
            lblnota2.Text = "Nota 2:";
            // 
            // lblnota1
            // 
            lblnota1.AutoSize = true;
            lblnota1.Location = new Point(74, 80);
            lblnota1.Name = "lblnota1";
            lblnota1.Size = new Size(57, 20);
            lblnota1.TabIndex = 5;
            lblnota1.Text = "Nota 1:";
            // 
            // btnCalcularMedia
            // 
            btnCalcularMedia.Location = new Point(129, 347);
            btnCalcularMedia.Name = "btnCalcularMedia";
            btnCalcularMedia.Size = new Size(136, 49);
            btnCalcularMedia.TabIndex = 6;
            btnCalcularMedia.Text = "Calcular Média";
            btnCalcularMedia.UseVisualStyleBackColor = true;
            btnCalcularMedia.Click += btnCalcularMedia_Click;
            // 
            // txtnota4
            // 
            txtnota4.Location = new Point(182, 260);
            txtnota4.Name = "txtnota4";
            txtnota4.Size = new Size(125, 27);
            txtnota4.TabIndex = 4;
            // 
            // txtnota3
            // 
            txtnota3.Location = new Point(183, 198);
            txtnota3.Name = "txtnota3";
            txtnota3.Size = new Size(125, 27);
            txtnota3.TabIndex = 3;
            // 
            // txtnota2
            // 
            txtnota2.Location = new Point(182, 135);
            txtnota2.Name = "txtnota2";
            txtnota2.Size = new Size(125, 27);
            txtnota2.TabIndex = 2;
            // 
            // txtnota1
            // 
            txtnota1.Location = new Point(182, 73);
            txtnota1.Name = "txtnota1";
            txtnota1.Size = new Size(125, 27);
            txtnota1.TabIndex = 1;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(370, 12);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(78, 29);
            btnSair.TabIndex = 9;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // grpExame
            // 
            grpExame.Controls.Add(btnmediaFinal);
            grpExame.Controls.Add(lblnotaExame);
            grpExame.Controls.Add(btnSair);
            grpExame.Controls.Add(lblmediaAnual);
            grpExame.Controls.Add(txtnotaExame);
            grpExame.Controls.Add(txtmediaAnual);
            grpExame.Location = new Point(453, 0);
            grpExame.Name = "grpExame";
            grpExame.Size = new Size(448, 459);
            grpExame.TabIndex = 1;
            grpExame.TabStop = false;
            grpExame.Text = "Nota Final";
            grpExame.Visible = false;
            // 
            // btnmediaFinal
            // 
            btnmediaFinal.Location = new Point(112, 216);
            btnmediaFinal.Name = "btnmediaFinal";
            btnmediaFinal.Size = new Size(170, 60);
            btnmediaFinal.TabIndex = 8;
            btnmediaFinal.Text = "Calcular Média Final";
            btnmediaFinal.UseVisualStyleBackColor = true;
            btnmediaFinal.Click += btnmediaFinal_Click;
            // 
            // lblnotaExame
            // 
            lblnotaExame.AutoSize = true;
            lblnotaExame.Location = new Point(58, 144);
            lblnotaExame.Name = "lblnotaExame";
            lblnotaExame.Size = new Size(90, 20);
            lblnotaExame.TabIndex = 5;
            lblnotaExame.Text = "Nota Exame";
            // 
            // lblmediaAnual
            // 
            lblmediaAnual.AutoSize = true;
            lblmediaAnual.Location = new Point(58, 76);
            lblmediaAnual.Name = "lblmediaAnual";
            lblmediaAnual.Size = new Size(93, 20);
            lblmediaAnual.TabIndex = 4;
            lblmediaAnual.Text = "Media Anual";
            // 
            // txtnotaExame
            // 
            txtnotaExame.Location = new Point(177, 137);
            txtnotaExame.Name = "txtnotaExame";
            txtnotaExame.Size = new Size(125, 27);
            txtnotaExame.TabIndex = 7;
            // 
            // txtmediaAnual
            // 
            txtmediaAnual.Enabled = false;
            txtmediaAnual.Location = new Point(177, 69);
            txtmediaAnual.Name = "txtmediaAnual";
            txtmediaAnual.Size = new Size(125, 27);
            txtmediaAnual.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 454);
            Controls.Add(grpExame);
            Controls.Add(grpnotaAnual);
            Name = "Form1";
            Text = "Calculadora";
            grpnotaAnual.ResumeLayout(false);
            grpnotaAnual.PerformLayout();
            grpExame.ResumeLayout(false);
            grpExame.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpnotaAnual;
        private GroupBox grpExame;
        private Label lblnota4;
        private Label lblnota3;
        private Label lblnota2;
        private Label lblnota1;
        private Button btnCalcularMedia;
        private TextBox txtnota4;
        private TextBox txtnota3;
        private TextBox txtnota2;
        private TextBox txtnota1;
        private Label lblnotaExame;
        private Label lblmediaAnual;
        private Button btnSair;
        private TextBox txtnotaExame;
        private TextBox txtmediaAnual;
        private Button btnmediaFinal;
        private Button btnSair1;
    }
}