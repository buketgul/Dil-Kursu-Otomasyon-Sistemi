namespace DilKursuOtomasyon
{
    partial class HataMenusu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HataMenusu));
            this.labelMesaj = new System.Windows.Forms.Label();
            this.buttonTamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMesaj
            // 
            resources.ApplyResources(this.labelMesaj, "labelMesaj");
            this.labelMesaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.labelMesaj.Name = "labelMesaj";
            // 
            // buttonTamam
            // 
            this.buttonTamam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.buttonTamam, "buttonTamam");
            this.buttonTamam.FlatAppearance.BorderSize = 0;
            this.buttonTamam.ForeColor = System.Drawing.Color.Gold;
            this.buttonTamam.Name = "buttonTamam";
            this.buttonTamam.UseVisualStyleBackColor = false;
            this.buttonTamam.Click += new System.EventHandler(this.buttonTamam_Click);
            // 
            // HataMenusu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.buttonTamam);
            this.Controls.Add(this.labelMesaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HataMenusu";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelMesaj;
        private System.Windows.Forms.Button buttonTamam;
    }
}