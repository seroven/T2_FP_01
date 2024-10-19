namespace T2_FP_01
{
    partial class PetsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.G2_Name_Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.G2_Breed_Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.G2_Age_Txt = new System.Windows.Forms.TextBox();
            this.G2_Owner_Cbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.G2_Add_Btn = new System.Windows.Forms.Button();
            this.G2_Clean_Btn = new System.Windows.Forms.Button();
            this.G2_Pets_DataGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G2_Search_By_Name_Txt = new System.Windows.Forms.TextBox();
            this.G2_Search_By_Name_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.G2_Pets_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(319, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(143, 26);
            this.label.TabIndex = 2;
            this.label.Text = "MASCOTAS";
            this.label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // G2_Name_Txt
            // 
            this.G2_Name_Txt.Location = new System.Drawing.Point(53, 105);
            this.G2_Name_Txt.Name = "G2_Name_Txt";
            this.G2_Name_Txt.Size = new System.Drawing.Size(242, 20);
            this.G2_Name_Txt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Raza";
            // 
            // G2_Breed_Txt
            // 
            this.G2_Breed_Txt.Location = new System.Drawing.Point(53, 159);
            this.G2_Breed_Txt.Name = "G2_Breed_Txt";
            this.G2_Breed_Txt.Size = new System.Drawing.Size(242, 20);
            this.G2_Breed_Txt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Edad";
            // 
            // G2_Age_Txt
            // 
            this.G2_Age_Txt.Location = new System.Drawing.Point(53, 213);
            this.G2_Age_Txt.Name = "G2_Age_Txt";
            this.G2_Age_Txt.Size = new System.Drawing.Size(242, 20);
            this.G2_Age_Txt.TabIndex = 10;
            // 
            // G2_Owner_Cbx
            // 
            this.G2_Owner_Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.G2_Owner_Cbx.FormattingEnabled = true;
            this.G2_Owner_Cbx.Location = new System.Drawing.Point(53, 270);
            this.G2_Owner_Cbx.Name = "G2_Owner_Cbx";
            this.G2_Owner_Cbx.Size = new System.Drawing.Size(242, 21);
            this.G2_Owner_Cbx.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dueño";
            // 
            // G2_Add_Btn
            // 
            this.G2_Add_Btn.Location = new System.Drawing.Point(53, 317);
            this.G2_Add_Btn.Name = "G2_Add_Btn";
            this.G2_Add_Btn.Size = new System.Drawing.Size(90, 30);
            this.G2_Add_Btn.TabIndex = 14;
            this.G2_Add_Btn.Text = "Agregar";
            this.G2_Add_Btn.UseVisualStyleBackColor = true;
            this.G2_Add_Btn.Click += new System.EventHandler(this.G2_Add_Btn_Click);
            // 
            // G2_Clean_Btn
            // 
            this.G2_Clean_Btn.Location = new System.Drawing.Point(205, 317);
            this.G2_Clean_Btn.Name = "G2_Clean_Btn";
            this.G2_Clean_Btn.Size = new System.Drawing.Size(90, 30);
            this.G2_Clean_Btn.TabIndex = 15;
            this.G2_Clean_Btn.Text = "Limpiar";
            this.G2_Clean_Btn.UseVisualStyleBackColor = true;
            this.G2_Clean_Btn.Click += new System.EventHandler(this.G2_Clean_Btn_Click);
            // 
            // G2_Pets_DataGrid
            // 
            this.G2_Pets_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G2_Pets_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Breed,
            this.Age,
            this.Owner});
            this.G2_Pets_DataGrid.Location = new System.Drawing.Point(341, 89);
            this.G2_Pets_DataGrid.Name = "G2_Pets_DataGrid";
            this.G2_Pets_DataGrid.Size = new System.Drawing.Size(442, 220);
            this.G2_Pets_DataGrid.TabIndex = 16;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.Width = 120;
            // 
            // Breed
            // 
            this.Breed.HeaderText = "Raza";
            this.Breed.Name = "Breed";
            this.Breed.Width = 120;
            // 
            // Age
            // 
            this.Age.HeaderText = "Edad";
            this.Age.Name = "Age";
            this.Age.Width = 50;
            // 
            // Owner
            // 
            this.Owner.HeaderText = "Dueño";
            this.Owner.Name = "Owner";
            // 
            // G2_Search_By_Name_Txt
            // 
            this.G2_Search_By_Name_Txt.Location = new System.Drawing.Point(420, 60);
            this.G2_Search_By_Name_Txt.Name = "G2_Search_By_Name_Txt";
            this.G2_Search_By_Name_Txt.Size = new System.Drawing.Size(219, 20);
            this.G2_Search_By_Name_Txt.TabIndex = 17;
            // 
            // G2_Search_By_Name_Btn
            // 
            this.G2_Search_By_Name_Btn.Location = new System.Drawing.Point(645, 54);
            this.G2_Search_By_Name_Btn.Name = "G2_Search_By_Name_Btn";
            this.G2_Search_By_Name_Btn.Size = new System.Drawing.Size(138, 30);
            this.G2_Search_By_Name_Btn.TabIndex = 19;
            this.G2_Search_By_Name_Btn.Text = "Buscar por Nombre";
            this.G2_Search_By_Name_Btn.UseVisualStyleBackColor = true;
            this.G2_Search_By_Name_Btn.Click += new System.EventHandler(this.G2_Search_By_Name_Btn_Click);
            // 
            // PetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 365);
            this.Controls.Add(this.G2_Search_By_Name_Btn);
            this.Controls.Add(this.G2_Search_By_Name_Txt);
            this.Controls.Add(this.G2_Pets_DataGrid);
            this.Controls.Add(this.G2_Clean_Btn);
            this.Controls.Add(this.G2_Add_Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.G2_Owner_Cbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.G2_Age_Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.G2_Breed_Txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.G2_Name_Txt);
            this.Controls.Add(this.label);
            this.Name = "PetsForm";
            this.Text = "PetsForm";
            ((System.ComponentModel.ISupportInitialize)(this.G2_Pets_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox G2_Name_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox G2_Breed_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox G2_Age_Txt;
        private System.Windows.Forms.ComboBox G2_Owner_Cbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button G2_Add_Btn;
        private System.Windows.Forms.Button G2_Clean_Btn;
        private System.Windows.Forms.DataGridView G2_Pets_DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.TextBox G2_Search_By_Name_Txt;
        private System.Windows.Forms.Button G2_Search_By_Name_Btn;
    }
}