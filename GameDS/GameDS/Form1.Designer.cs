namespace GameDS
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
            this.components = new System.ComponentModel.Container();
            this.PicNave = new System.Windows.Forms.PictureBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.LblPuntaje = new System.Windows.Forms.Label();
            this.LblPuntos = new System.Windows.Forms.Label();
            this.LabelX = new System.Windows.Forms.Label();
            this.LabelY = new System.Windows.Forms.Label();
            this.PicEne1 = new System.Windows.Forms.PictureBox();
            this.PicEne2 = new System.Windows.Forms.PictureBox();
            this.PicEne3 = new System.Windows.Forms.PictureBox();
            this.Misil = new System.Windows.Forms.PictureBox();
            this.PicFondo = new System.Windows.Forms.PictureBox();
            this.PicEne4 = new System.Windows.Forms.PictureBox();
            this.PicEne5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEne1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEne2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEne3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Misil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEne4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEne5)).BeginInit();
            this.SuspendLayout();
            // 
            // PicNave
            // 
            this.PicNave.Location = new System.Drawing.Point(236, 340);
            this.PicNave.Name = "PicNave";
            this.PicNave.Size = new System.Drawing.Size(100, 50);
            this.PicNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicNave.TabIndex = 0;
            this.PicNave.TabStop = false;
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 20;
            this.tmr.Tick += new System.EventHandler(this.playTimer);
            // 
            // LblPuntaje
            // 
            this.LblPuntaje.AutoSize = true;
            this.LblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuntaje.Location = new System.Drawing.Point(18, 409);
            this.LblPuntaje.Name = "LblPuntaje";
            this.LblPuntaje.Size = new System.Drawing.Size(121, 33);
            this.LblPuntaje.TabIndex = 2;
            this.LblPuntaje.Text = "Puntaje:";
            this.LblPuntaje.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblPuntos
            // 
            this.LblPuntos.AutoSize = true;
            this.LblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuntos.Location = new System.Drawing.Point(145, 409);
            this.LblPuntos.Name = "LblPuntos";
            this.LblPuntos.Size = new System.Drawing.Size(105, 33);
            this.LblPuntos.TabIndex = 3;
            this.LblPuntos.Text = "Puntos";
            this.LblPuntos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Location = new System.Drawing.Point(280, 307);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(0, 13);
            this.LabelX.TabIndex = 4;
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Location = new System.Drawing.Point(283, 324);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(0, 13);
            this.LabelY.TabIndex = 5;
            // 
            // PicEne1
            // 
            this.PicEne1.Location = new System.Drawing.Point(24, 12);
            this.PicEne1.Name = "PicEne1";
            this.PicEne1.Size = new System.Drawing.Size(100, 50);
            this.PicEne1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicEne1.TabIndex = 6;
            this.PicEne1.TabStop = false;
            // 
            // PicEne2
            // 
            this.PicEne2.Location = new System.Drawing.Point(236, 12);
            this.PicEne2.Name = "PicEne2";
            this.PicEne2.Size = new System.Drawing.Size(100, 50);
            this.PicEne2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicEne2.TabIndex = 7;
            this.PicEne2.TabStop = false;
            // 
            // PicEne3
            // 
            this.PicEne3.Location = new System.Drawing.Point(472, 12);
            this.PicEne3.Name = "PicEne3";
            this.PicEne3.Size = new System.Drawing.Size(100, 50);
            this.PicEne3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicEne3.TabIndex = 8;
            this.PicEne3.TabStop = false;
            // 
            // Misil
            // 
            this.Misil.BackColor = System.Drawing.Color.Transparent;
            this.Misil.Location = new System.Drawing.Point(274, 254);
            this.Misil.Name = "Misil";
            this.Misil.Size = new System.Drawing.Size(20, 50);
            this.Misil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Misil.TabIndex = 11;
            this.Misil.TabStop = false;
            // 
            // PicFondo
            // 
            this.PicFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicFondo.Location = new System.Drawing.Point(0, 0);
            this.PicFondo.Name = "PicFondo";
            this.PicFondo.Size = new System.Drawing.Size(584, 461);
            this.PicFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFondo.TabIndex = 1;
            this.PicFondo.TabStop = false;
            // 
            // PicEne4
            // 
            this.PicEne4.Location = new System.Drawing.Point(129, 69);
            this.PicEne4.Name = "PicEne4";
            this.PicEne4.Size = new System.Drawing.Size(100, 50);
            this.PicEne4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicEne4.TabIndex = 12;
            this.PicEne4.TabStop = false;
            // 
            // PicEne5
            // 
            this.PicEne5.Location = new System.Drawing.Point(338, 69);
            this.PicEne5.Name = "PicEne5";
            this.PicEne5.Size = new System.Drawing.Size(100, 50);
            this.PicEne5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicEne5.TabIndex = 13;
            this.PicEne5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.PicEne5);
            this.Controls.Add(this.PicEne4);
            this.Controls.Add(this.PicEne3);
            this.Controls.Add(this.PicEne2);
            this.Controls.Add(this.PicEne1);
            this.Controls.Add(this.Misil);
            this.Controls.Add(this.LabelY);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.LblPuntos);
            this.Controls.Add(this.LblPuntaje);
            this.Controls.Add(this.PicNave);
            this.Controls.Add(this.PicFondo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PicNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEne1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEne2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEne3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Misil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEne4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEne5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicNave;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label LblPuntaje;
        private System.Windows.Forms.Label LblPuntos;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.Label LabelY;
        private System.Windows.Forms.PictureBox PicEne1;
        private System.Windows.Forms.PictureBox PicEne2;
        private System.Windows.Forms.PictureBox PicEne3;
        private System.Windows.Forms.PictureBox Misil;
        private System.Windows.Forms.PictureBox PicFondo;
        private System.Windows.Forms.PictureBox PicEne4;
        private System.Windows.Forms.PictureBox PicEne5;
    }
}

