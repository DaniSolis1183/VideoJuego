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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PicFondo = new System.Windows.Forms.PictureBox();
            this.LblPuntaje = new System.Windows.Forms.Label();
            this.LblPuntos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // PicNave
            // 
            this.PicNave.Location = new System.Drawing.Point(237, 182);
            this.PicNave.Name = "PicNave";
            this.PicNave.Size = new System.Drawing.Size(100, 50);
            this.PicNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicNave.TabIndex = 0;
            this.PicNave.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // LblPuntaje
            // 
            this.LblPuntaje.AutoSize = true;
            this.LblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuntaje.Location = new System.Drawing.Point(31, 409);
            this.LblPuntaje.Name = "LblPuntaje";
            this.LblPuntaje.Size = new System.Drawing.Size(121, 33);
            this.LblPuntaje.TabIndex = 2;
            this.LblPuntaje.Text = "Puntaje:";
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.LblPuntos);
            this.Controls.Add(this.LblPuntaje);
            this.Controls.Add(this.PicNave);
            this.Controls.Add(this.PicFondo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PicNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicNave;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PicFondo;
        private System.Windows.Forms.Label LblPuntaje;
        private System.Windows.Forms.Label LblPuntos;
    }
}

