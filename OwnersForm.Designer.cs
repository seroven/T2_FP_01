namespace T2_FP_01
{
    partial class OwnersForm
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
            this.label = new System.Windows.Forms.Label();
            this.G2_Name_Txt = new System.Windows.Forms.TextBox();
            this.G2_Address_Txt = new System.Windows.Forms.TextBox();
            this.G2_Phone_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.G2_Add_Btn = new System.Windows.Forms.Button();
            this.G2_Clean_Btn = new System.Windows.Forms.Button();
            this.G2_Owners_DataGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.G2_Owners_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(334, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(113, 26);
            this.label.TabIndex = 1;
            this.label.Text = "DUEÑOS";
            this.label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // G2_Name_Txt
            // 
            this.G2_Name_Txt.Location = new System.Drawing.Point(53, 105);
            this.G2_Name_Txt.Name = "G2_Name_Txt";
            this.G2_Name_Txt.Size = new System.Drawing.Size(242, 20);
            this.G2_Name_Txt.TabIndex = 2;
            // 
            // G2_Address_Txt
            // 
            this.G2_Address_Txt.Location = new System.Drawing.Point(53, 163);
            this.G2_Address_Txt.Name = "G2_Address_Txt";
            this.G2_Address_Txt.Size = new System.Drawing.Size(242, 20);
            this.G2_Address_Txt.TabIndex = 3;
            // 
            // G2_Phone_Txt
            // 
            this.G2_Phone_Txt.Location = new System.Drawing.Point(53, 220);
            this.G2_Phone_Txt.Name = "G2_Phone_Txt";
            this.G2_Phone_Txt.Size = new System.Drawing.Size(242, 20);
            this.G2_Phone_Txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Teléfono";
            // 
            // G2_Add_Btn
            // 
            this.G2_Add_Btn.Location = new System.Drawing.Point(53, 279);
            this.G2_Add_Btn.Name = "G2_Add_Btn";
            this.G2_Add_Btn.Size = new System.Drawing.Size(90, 30);
            this.G2_Add_Btn.TabIndex = 8;
            this.G2_Add_Btn.Text = "Agregar";
            this.G2_Add_Btn.UseVisualStyleBackColor = true;
            this.G2_Add_Btn.Click += new System.EventHandler(this.G2_Add_Btn_Click);
            // 
            // G2_Clean_Btn
            // 
            this.G2_Clean_Btn.Location = new System.Drawing.Point(205, 279);
            this.G2_Clean_Btn.Name = "G2_Clean_Btn";
            this.G2_Clean_Btn.Size = new System.Drawing.Size(90, 30);
            this.G2_Clean_Btn.TabIndex = 9;
            this.G2_Clean_Btn.Text = "Limpiar";
            this.G2_Clean_Btn.UseVisualStyleBackColor = true;
            this.G2_Clean_Btn.Click += new System.EventHandler(this.G2_Clean_Btn_Click);
            // 
            // G2_Owners_DataGrid
            // 
            this.G2_Owners_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G2_Owners_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Address,
            this.Phone});
            this.G2_Owners_DataGrid.Location = new System.Drawing.Point(339, 89);
            this.G2_Owners_DataGrid.Name = "G2_Owners_DataGrid";
            this.G2_Owners_DataGrid.Size = new System.Drawing.Size(433, 220);
            this.G2_Owners_DataGrid.TabIndex = 10;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.Width = 140;
            // 
            // Address
            // 
            this.Address.HeaderText = "Dirección";
            this.Address.Name = "Address";
            this.Address.Width = 140;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Teléfono";
            this.Phone.Name = "Phone";
            // 
            // OwnersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 365);
            this.Controls.Add(this.G2_Owners_DataGrid);
            this.Controls.Add(this.G2_Clean_Btn);
            this.Controls.Add(this.G2_Add_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.G2_Phone_Txt);
            this.Controls.Add(this.G2_Address_Txt);
            this.Controls.Add(this.G2_Name_Txt);
            this.Controls.Add(this.label);
            this.Name = "OwnersForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.G2_Owners_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox G2_Name_Txt;
        private System.Windows.Forms.TextBox G2_Address_Txt;
        private System.Windows.Forms.TextBox G2_Phone_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button G2_Add_Btn;
        private System.Windows.Forms.Button G2_Clean_Btn;
        private System.Windows.Forms.DataGridView G2_Owners_DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}

