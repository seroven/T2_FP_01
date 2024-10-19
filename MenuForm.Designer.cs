namespace T2_FP_01
{
    partial class MenuForm
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
            this.G2_Title_Lbl = new System.Windows.Forms.Label();
            this.G2_Owner_Btn = new System.Windows.Forms.Button();
            this.G2_Pet_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // G2_Title_Lbl
            // 
            this.G2_Title_Lbl.AutoSize = true;
            this.G2_Title_Lbl.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2_Title_Lbl.Location = new System.Drawing.Point(257, 24);
            this.G2_Title_Lbl.Name = "G2_Title_Lbl";
            this.G2_Title_Lbl.Size = new System.Drawing.Size(74, 25);
            this.G2_Title_Lbl.TabIndex = 0;
            this.G2_Title_Lbl.Text = "MENU";
            this.G2_Title_Lbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // G2_Owner_Btn
            // 
            this.G2_Owner_Btn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2_Owner_Btn.Location = new System.Drawing.Point(65, 153);
            this.G2_Owner_Btn.Name = "G2_Owner_Btn";
            this.G2_Owner_Btn.Size = new System.Drawing.Size(120, 40);
            this.G2_Owner_Btn.TabIndex = 1;
            this.G2_Owner_Btn.Text = "Dueños";
            this.G2_Owner_Btn.UseVisualStyleBackColor = true;
            this.G2_Owner_Btn.Click += new System.EventHandler(this.G2_Owner_Btn_Click);
            // 
            // G2_Pet_Btn
            // 
            this.G2_Pet_Btn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2_Pet_Btn.Location = new System.Drawing.Point(401, 153);
            this.G2_Pet_Btn.Name = "G2_Pet_Btn";
            this.G2_Pet_Btn.Size = new System.Drawing.Size(120, 40);
            this.G2_Pet_Btn.TabIndex = 2;
            this.G2_Pet_Btn.Text = "Mascotas";
            this.G2_Pet_Btn.UseVisualStyleBackColor = true;
            this.G2_Pet_Btn.Click += new System.EventHandler(this.G2_Pet_Btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.G2_Pet_Btn);
            this.Controls.Add(this.G2_Owner_Btn);
            this.Controls.Add(this.G2_Title_Lbl);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label G2_Title_Lbl;
        private System.Windows.Forms.Button G2_Owner_Btn;
        private System.Windows.Forms.Button G2_Pet_Btn;
    }
}