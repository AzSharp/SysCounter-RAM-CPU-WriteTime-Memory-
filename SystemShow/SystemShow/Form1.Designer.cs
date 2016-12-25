namespace SystemShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuGauge1 = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuGauge2 = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuGauge3 = new Bunifu.Framework.UI.BunifuGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pMEMORY = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.bunifuGauge4 = new Bunifu.Framework.UI.BunifuGauge();
            this.pWRITE = new System.Diagnostics.PerformanceCounter();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pMEMORY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWRITE)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGauge1
            // 
            this.bunifuGauge1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge1.BackgroundImage")));
            this.bunifuGauge1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuGauge1.ForeColor = System.Drawing.Color.Orange;
            this.bunifuGauge1.Location = new System.Drawing.Point(201, 76);
            this.bunifuGauge1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuGauge1.Name = "bunifuGauge1";
            this.bunifuGauge1.ProgressBgColor = System.Drawing.Color.Gray;
            this.bunifuGauge1.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.bunifuGauge1.ProgressColor2 = System.Drawing.Color.Tomato;
            this.bunifuGauge1.Size = new System.Drawing.Size(199, 139);
            this.bunifuGauge1.TabIndex = 0;
            this.bunifuGauge1.Thickness = 30;
            this.bunifuGauge1.Value = 0;
            // 
            // bunifuGauge2
            // 
            this.bunifuGauge2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge2.BackgroundImage")));
            this.bunifuGauge2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuGauge2.ForeColor = System.Drawing.Color.Orange;
            this.bunifuGauge2.Location = new System.Drawing.Point(393, 76);
            this.bunifuGauge2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuGauge2.Name = "bunifuGauge2";
            this.bunifuGauge2.ProgressBgColor = System.Drawing.Color.Gray;
            this.bunifuGauge2.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.bunifuGauge2.ProgressColor2 = System.Drawing.Color.Tomato;
            this.bunifuGauge2.Size = new System.Drawing.Size(199, 139);
            this.bunifuGauge2.TabIndex = 1;
            this.bunifuGauge2.Thickness = 30;
            this.bunifuGauge2.Value = 0;
            // 
            // bunifuGauge3
            // 
            this.bunifuGauge3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge3.BackgroundImage")));
            this.bunifuGauge3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuGauge3.ForeColor = System.Drawing.Color.Orange;
            this.bunifuGauge3.Location = new System.Drawing.Point(5, 76);
            this.bunifuGauge3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuGauge3.Name = "bunifuGauge3";
            this.bunifuGauge3.ProgressBgColor = System.Drawing.Color.Gray;
            this.bunifuGauge3.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.bunifuGauge3.ProgressColor2 = System.Drawing.Color.Tomato;
            this.bunifuGauge3.Size = new System.Drawing.Size(199, 139);
            this.bunifuGauge3.TabIndex = 2;
            this.bunifuGauge3.Thickness = 30;
            this.bunifuGauge3.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(87, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(471, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "RAM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(232, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = " Memory in use:";
            // 
            // pMEMORY
            // 
            this.pMEMORY.CategoryName = "Memory";
            this.pMEMORY.CounterName = "% Committed Bytes In Use";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "Available MBytes";
            // 
            // bunifuGauge4
            // 
            this.bunifuGauge4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge4.BackgroundImage")));
            this.bunifuGauge4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuGauge4.ForeColor = System.Drawing.Color.Orange;
            this.bunifuGauge4.Location = new System.Drawing.Point(591, 76);
            this.bunifuGauge4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuGauge4.Name = "bunifuGauge4";
            this.bunifuGauge4.ProgressBgColor = System.Drawing.Color.Gray;
            this.bunifuGauge4.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.bunifuGauge4.ProgressColor2 = System.Drawing.Color.Tomato;
            this.bunifuGauge4.Size = new System.Drawing.Size(199, 139);
            this.bunifuGauge4.TabIndex = 7;
            this.bunifuGauge4.Thickness = 30;
            this.bunifuGauge4.Value = 0;
            // 
            // pWRITE
            // 
            this.pWRITE.CategoryName = "PhysicalDisk";
            this.pWRITE.CounterName = "% Disk Write Time";
            this.pWRITE.InstanceName = "_Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(637, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Write time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 221);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuGauge4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuGauge3);
            this.Controls.Add(this.bunifuGauge2);
            this.Controls.Add(this.bunifuGauge1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pMEMORY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWRITE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGauge bunifuGauge1;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge2;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Diagnostics.PerformanceCounter pMEMORY;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Diagnostics.PerformanceCounter pRAM;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge4;
        private System.Diagnostics.PerformanceCounter pWRITE;
        private System.Windows.Forms.Label label5;
    }
}

