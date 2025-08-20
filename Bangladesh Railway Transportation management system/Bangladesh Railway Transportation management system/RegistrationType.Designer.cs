namespace Bangladesh_Railway_Transportation_management_system
{
    partial class RegistrationType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationType));
            this.label1 = new System.Windows.Forms.Label();
            this.userbtn = new System.Windows.Forms.Button();
            this.adminbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Type";
            // 
            // userbtn
            // 
            this.userbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbtn.Image = ((System.Drawing.Image)(resources.GetObject("userbtn.Image")));
            this.userbtn.Location = new System.Drawing.Point(200, 192);
            this.userbtn.Name = "userbtn";
            this.userbtn.Size = new System.Drawing.Size(131, 116);
            this.userbtn.TabIndex = 1;
            this.userbtn.Text = "USER";
            this.userbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userbtn.UseVisualStyleBackColor = true;
            this.userbtn.Click += new System.EventHandler(this.userbtn_Click);
            // 
            // adminbtn
            // 
            this.adminbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbtn.Image = ((System.Drawing.Image)(resources.GetObject("adminbtn.Image")));
            this.adminbtn.Location = new System.Drawing.Point(465, 192);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(131, 116);
            this.adminbtn.TabIndex = 2;
            this.adminbtn.Text = "ADMIN";
            this.adminbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.adminbtn.UseVisualStyleBackColor = true;
            this.adminbtn.Click += new System.EventHandler(this.adminbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(219, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please choose registration type for further Progress";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Red;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(355, 345);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(90, 39);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtnclick);
            // 
            // RegistrationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminbtn);
            this.Controls.Add(this.userbtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistrationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationType";
            this.Load += new System.EventHandler(this.RegistrationType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userbtn;
        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backbtn;
    }
}