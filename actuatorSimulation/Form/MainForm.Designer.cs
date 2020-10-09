namespace actuatorSimulation
{
    partial class MainForm
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
            this.pBar2 = new System.Windows.Forms.ProgressBar();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.lblOpen2 = new System.Windows.Forms.Label();
            this.lblClose2 = new System.Windows.Forms.Label();
            this.gBx2 = new System.Windows.Forms.GroupBox();
            this.gBx3 = new System.Windows.Forms.GroupBox();
            this.btnStop3 = new System.Windows.Forms.Button();
            this.pBar3 = new System.Windows.Forms.ProgressBar();
            this.lblClose3 = new System.Windows.Forms.Label();
            this.btnOpen3 = new System.Windows.Forms.Button();
            this.lblOpen3 = new System.Windows.Forms.Label();
            this.btnClose3 = new System.Windows.Forms.Button();
            this.gBx4 = new System.Windows.Forms.GroupBox();
            this.btnStop4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrent4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBar4 = new System.Windows.Forms.ProgressBar();
            this.lblClose4 = new System.Windows.Forms.Label();
            this.btnOpen4 = new System.Windows.Forms.Button();
            this.lblOpen4 = new System.Windows.Forms.Label();
            this.btnClose4 = new System.Windows.Forms.Button();
            this.gBx1 = new System.Windows.Forms.GroupBox();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.lblClose1 = new System.Windows.Forms.Label();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.lblOpen1 = new System.Windows.Forms.Label();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.gBx2.SuspendLayout();
            this.gBx3.SuspendLayout();
            this.gBx4.SuspendLayout();
            this.gBx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBar2
            // 
            this.pBar2.Location = new System.Drawing.Point(66, 19);
            this.pBar2.Name = "pBar2";
            this.pBar2.Size = new System.Drawing.Size(320, 23);
            this.pBar2.TabIndex = 1;
            // 
            // btnOpen2
            // 
            this.btnOpen2.Location = new System.Drawing.Point(66, 48);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(75, 23);
            this.btnOpen2.TabIndex = 2;
            this.btnOpen2.Text = "Open";
            this.btnOpen2.UseVisualStyleBackColor = true;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2Click);
            // 
            // btnClose2
            // 
            this.btnClose2.Location = new System.Drawing.Point(311, 48);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(75, 23);
            this.btnClose2.TabIndex = 3;
            this.btnClose2.Text = "Close";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2Click);
            // 
            // lblOpen2
            // 
            this.lblOpen2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblOpen2.Location = new System.Drawing.Point(21, 19);
            this.lblOpen2.Name = "lblOpen2";
            this.lblOpen2.Size = new System.Drawing.Size(25, 25);
            this.lblOpen2.TabIndex = 4;
            // 
            // lblClose2
            // 
            this.lblClose2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblClose2.Location = new System.Drawing.Point(406, 18);
            this.lblClose2.Name = "lblClose2";
            this.lblClose2.Size = new System.Drawing.Size(25, 25);
            this.lblClose2.TabIndex = 5;
            // 
            // gBx2
            // 
            this.gBx2.Controls.Add(this.pBar2);
            this.gBx2.Controls.Add(this.lblClose2);
            this.gBx2.Controls.Add(this.btnOpen2);
            this.gBx2.Controls.Add(this.lblOpen2);
            this.gBx2.Controls.Add(this.btnClose2);
            this.gBx2.Location = new System.Drawing.Point(11, 110);
            this.gBx2.Name = "gBx2";
            this.gBx2.Size = new System.Drawing.Size(453, 92);
            this.gBx2.TabIndex = 6;
            this.gBx2.TabStop = false;
            this.gBx2.Text = "Valve 2";
            // 
            // gBx3
            // 
            this.gBx3.Controls.Add(this.btnStop3);
            this.gBx3.Controls.Add(this.pBar3);
            this.gBx3.Controls.Add(this.lblClose3);
            this.gBx3.Controls.Add(this.btnOpen3);
            this.gBx3.Controls.Add(this.lblOpen3);
            this.gBx3.Controls.Add(this.btnClose3);
            this.gBx3.Location = new System.Drawing.Point(12, 208);
            this.gBx3.Name = "gBx3";
            this.gBx3.Size = new System.Drawing.Size(453, 92);
            this.gBx3.TabIndex = 7;
            this.gBx3.TabStop = false;
            this.gBx3.Text = "Valve 3";
            // 
            // btnStop3
            // 
            this.btnStop3.Location = new System.Drawing.Point(189, 48);
            this.btnStop3.Name = "btnStop3";
            this.btnStop3.Size = new System.Drawing.Size(75, 23);
            this.btnStop3.TabIndex = 6;
            this.btnStop3.Text = "Stop";
            this.btnStop3.UseVisualStyleBackColor = true;
            this.btnStop3.Click += new System.EventHandler(this.btnStop3Click);
            // 
            // pBar3
            // 
            this.pBar3.Location = new System.Drawing.Point(66, 19);
            this.pBar3.Name = "pBar3";
            this.pBar3.Size = new System.Drawing.Size(320, 23);
            this.pBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar3.TabIndex = 1;
            // 
            // lblClose3
            // 
            this.lblClose3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblClose3.Location = new System.Drawing.Point(406, 18);
            this.lblClose3.Name = "lblClose3";
            this.lblClose3.Size = new System.Drawing.Size(25, 25);
            this.lblClose3.TabIndex = 5;
            // 
            // btnOpen3
            // 
            this.btnOpen3.Location = new System.Drawing.Point(66, 48);
            this.btnOpen3.Name = "btnOpen3";
            this.btnOpen3.Size = new System.Drawing.Size(75, 23);
            this.btnOpen3.TabIndex = 2;
            this.btnOpen3.Text = "Open";
            this.btnOpen3.UseVisualStyleBackColor = true;
            this.btnOpen3.Click += new System.EventHandler(this.btnOpen3Click);
            // 
            // lblOpen3
            // 
            this.lblOpen3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblOpen3.Location = new System.Drawing.Point(21, 19);
            this.lblOpen3.Name = "lblOpen3";
            this.lblOpen3.Size = new System.Drawing.Size(25, 25);
            this.lblOpen3.TabIndex = 4;
            // 
            // btnClose3
            // 
            this.btnClose3.Location = new System.Drawing.Point(311, 48);
            this.btnClose3.Name = "btnClose3";
            this.btnClose3.Size = new System.Drawing.Size(75, 23);
            this.btnClose3.TabIndex = 3;
            this.btnClose3.Text = "Close";
            this.btnClose3.UseVisualStyleBackColor = true;
            this.btnClose3.Click += new System.EventHandler(this.btnClose3Click);
            // 
            // gBx4
            // 
            this.gBx4.Controls.Add(this.btnStop4);
            this.gBx4.Controls.Add(this.label2);
            this.gBx4.Controls.Add(this.txtCurrent4);
            this.gBx4.Controls.Add(this.label1);
            this.gBx4.Controls.Add(this.pBar4);
            this.gBx4.Controls.Add(this.lblClose4);
            this.gBx4.Controls.Add(this.btnOpen4);
            this.gBx4.Controls.Add(this.lblOpen4);
            this.gBx4.Controls.Add(this.btnClose4);
            this.gBx4.Location = new System.Drawing.Point(12, 308);
            this.gBx4.Name = "gBx4";
            this.gBx4.Size = new System.Drawing.Size(453, 119);
            this.gBx4.TabIndex = 8;
            this.gBx4.TabStop = false;
            this.gBx4.Text = "Valve 4";
            // 
            // btnStop4
            // 
            this.btnStop4.Location = new System.Drawing.Point(189, 76);
            this.btnStop4.Name = "btnStop4";
            this.btnStop4.Size = new System.Drawing.Size(75, 23);
            this.btnStop4.TabIndex = 7;
            this.btnStop4.Text = "Stop";
            this.btnStop4.UseVisualStyleBackColor = true;
            this.btnStop4.Click += new System.EventHandler(this.btnStop4Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Position:";
            // 
            // txtCurrent4
            // 
            this.txtCurrent4.Location = new System.Drawing.Point(203, 18);
            this.txtCurrent4.Name = "txtCurrent4";
            this.txtCurrent4.Size = new System.Drawing.Size(54, 20);
            this.txtCurrent4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "mA";
          
            // 
            // pBar4
            // 
            this.pBar4.Location = new System.Drawing.Point(66, 47);
            this.pBar4.Name = "pBar4";
            this.pBar4.Size = new System.Drawing.Size(320, 23);
            this.pBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar4.TabIndex = 1;
            // 
            // lblClose4
            // 
            this.lblClose4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblClose4.Location = new System.Drawing.Point(406, 46);
            this.lblClose4.Name = "lblClose4";
            this.lblClose4.Size = new System.Drawing.Size(25, 25);
            this.lblClose4.TabIndex = 5;
            // 
            // btnOpen4
            // 
            this.btnOpen4.Location = new System.Drawing.Point(66, 76);
            this.btnOpen4.Name = "btnOpen4";
            this.btnOpen4.Size = new System.Drawing.Size(75, 23);
            this.btnOpen4.TabIndex = 2;
            this.btnOpen4.Text = "Open";
            this.btnOpen4.UseVisualStyleBackColor = true;
            this.btnOpen4.Click += new System.EventHandler(this.btnOpen4Click);
            // 
            // lblOpen4
            // 
            this.lblOpen4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblOpen4.Location = new System.Drawing.Point(21, 47);
            this.lblOpen4.Name = "lblOpen4";
            this.lblOpen4.Size = new System.Drawing.Size(25, 25);
            this.lblOpen4.TabIndex = 4;
            // 
            // btnClose4
            // 
            this.btnClose4.Location = new System.Drawing.Point(311, 76);
            this.btnClose4.Name = "btnClose4";
            this.btnClose4.Size = new System.Drawing.Size(75, 23);
            this.btnClose4.TabIndex = 3;
            this.btnClose4.Text = "Close";
            this.btnClose4.UseVisualStyleBackColor = true;
            this.btnClose4.Click += new System.EventHandler(this.btnClose4Click);
            // 
            // gBx1
            // 
            this.gBx1.Controls.Add(this.pBar1);
            this.gBx1.Controls.Add(this.lblClose1);
            this.gBx1.Controls.Add(this.btnOpen1);
            this.gBx1.Controls.Add(this.lblOpen1);
            this.gBx1.Controls.Add(this.btnClose1);
            this.gBx1.Location = new System.Drawing.Point(12, 10);
            this.gBx1.Name = "gBx1";
            this.gBx1.Size = new System.Drawing.Size(453, 94);
            this.gBx1.TabIndex = 7;
            this.gBx1.TabStop = false;
            this.gBx1.Text = "Valve 1";
            // 
            // pBar1
            // 
            this.pBar1.Location = new System.Drawing.Point(65, 19);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(320, 23);
            this.pBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar1.TabIndex = 6;
            // 
            // lblClose1
            // 
            this.lblClose1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblClose1.Location = new System.Drawing.Point(406, 18);
            this.lblClose1.Name = "lblClose1";
            this.lblClose1.Size = new System.Drawing.Size(25, 25);
            this.lblClose1.TabIndex = 5;
            // 
            // btnOpen1
            // 
            this.btnOpen1.Location = new System.Drawing.Point(66, 48);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(75, 23);
            this.btnOpen1.TabIndex = 2;
            this.btnOpen1.Text = "Open";
            this.btnOpen1.UseVisualStyleBackColor = true;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1Click);
            // 
            // lblOpen1
            // 
            this.lblOpen1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblOpen1.Location = new System.Drawing.Point(21, 19);
            this.lblOpen1.Name = "lblOpen1";
            this.lblOpen1.Size = new System.Drawing.Size(25, 25);
            this.lblOpen1.TabIndex = 4;
            // 
            // btnClose1
            // 
            this.btnClose1.Location = new System.Drawing.Point(311, 48);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(75, 23);
            this.btnClose1.TabIndex = 3;
            this.btnClose1.Text = "Close";
            this.btnClose1.UseVisualStyleBackColor = true;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 441);
            this.Controls.Add(this.gBx1);
            this.Controls.Add(this.gBx4);
            this.Controls.Add(this.gBx3);
            this.Controls.Add(this.gBx2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Actuators";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.gBx2.ResumeLayout(false);
            this.gBx3.ResumeLayout(false);
            this.gBx4.ResumeLayout(false);
            this.gBx4.PerformLayout();
            this.gBx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBar2;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Label lblOpen2;
        private System.Windows.Forms.Label lblClose2;
        private System.Windows.Forms.GroupBox gBx2;
        private System.Windows.Forms.GroupBox gBx3;
        private System.Windows.Forms.ProgressBar pBar3;
        private System.Windows.Forms.Label lblClose3;
        private System.Windows.Forms.Button btnOpen3;
        private System.Windows.Forms.Label lblOpen3;
        private System.Windows.Forms.Button btnClose3;
        private System.Windows.Forms.GroupBox gBx4;
        private System.Windows.Forms.ProgressBar pBar4;
        private System.Windows.Forms.Label lblClose4;
        private System.Windows.Forms.Button btnOpen4;
        private System.Windows.Forms.Label lblOpen4;
        private System.Windows.Forms.Button btnClose4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrent4;
        private System.Windows.Forms.GroupBox gBx1;
        private System.Windows.Forms.Label lblClose1;
        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.Label lblOpen1;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.Button btnStop3;
        private System.Windows.Forms.Button btnStop4;
        private System.Windows.Forms.Label label2;
    }
}

