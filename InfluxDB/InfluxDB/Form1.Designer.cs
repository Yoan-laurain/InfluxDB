
namespace InfluxDB
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Titre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Stat = new System.Windows.Forms.Button();
            this.Btn_Dashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Zeus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.Color.Silver;
            this.Titre.Location = new System.Drawing.Point(26, 23);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(241, 39);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Liste de dieux";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.MaximumSize = new System.Drawing.Size(1280, 720);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(1280, 720);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.splitContainer1.Panel1.Controls.Add(this.btn_Close);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Settings);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Stat);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_Dashboard);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseMove);
            this.splitContainer1.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseUp);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Titre);
            this.splitContainer1.Panel2.Click += new System.EventHandler(this.splitContainer1_Panel2_Click);
            this.splitContainer1.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseDown);
            this.splitContainer1.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseMove);
            this.splitContainer1.Panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseUp);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(1280, 720);
            this.splitContainer1.SplitterDistance = 426;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseDown);
            this.splitContainer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseMove);
            this.splitContainer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseUp);
            // 
            // btn_Close
            // 
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(0, 595);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(426, 125);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Close";
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.ForeColor = System.Drawing.Color.White;
            this.btn_Settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_Settings.Image")));
            this.btn_Settings.Location = new System.Drawing.Point(0, 470);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(426, 125);
            this.btn_Settings.TabIndex = 4;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Settings.UseVisualStyleBackColor = true;
            // 
            // btn_Stat
            // 
            this.btn_Stat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Stat.FlatAppearance.BorderSize = 0;
            this.btn_Stat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stat.ForeColor = System.Drawing.Color.White;
            this.btn_Stat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Stat.Image")));
            this.btn_Stat.Location = new System.Drawing.Point(0, 345);
            this.btn_Stat.Name = "btn_Stat";
            this.btn_Stat.Size = new System.Drawing.Size(426, 125);
            this.btn_Stat.TabIndex = 3;
            this.btn_Stat.Text = "Statistics";
            this.btn_Stat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Stat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Stat.UseVisualStyleBackColor = true;
            // 
            // Btn_Dashboard
            // 
            this.Btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.Btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.Btn_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Dashboard.Image")));
            this.Btn_Dashboard.Location = new System.Drawing.Point(0, 220);
            this.Btn_Dashboard.Name = "Btn_Dashboard";
            this.Btn_Dashboard.Size = new System.Drawing.Size(426, 125);
            this.Btn_Dashboard.TabIndex = 2;
            this.Btn_Dashboard.Text = "DashBoard";
            this.Btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Dashboard.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Zeus);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 220);
            this.panel1.TabIndex = 1;
            // 
            // Zeus
            // 
            this.Zeus.AutoSize = true;
            this.Zeus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zeus.ForeColor = System.Drawing.Color.White;
            this.Zeus.Location = new System.Drawing.Point(182, 135);
            this.Zeus.Name = "Zeus";
            this.Zeus.Size = new System.Drawing.Size(49, 20);
            this.Zeus.TabIndex = 1;
            this.Zeus.Text = "Zeus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Stat;
        private System.Windows.Forms.Button Btn_Dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Zeus;
    }
}

