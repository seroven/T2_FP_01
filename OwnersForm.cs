using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T2_FP_01.arrays;
using T2_FP_01.classes;

namespace T2_FP_01
{
    public partial class OwnersForm : Form
    {
        public OwnersForm()
        {
            InitializeComponent();
            G2_Set_Items_To_View();
        }

        private void G2_Set_Items_To_View()
        {
            G2_Owners_DataGrid.Rows.Clear();
            foreach (G2Owner owner in G2OwnerArray.owners)
            {
                G2_Owners_DataGrid.Rows.Add(owner.G2_name, owner.G2_address, owner.G2_phone);
            }
        }

        private void G2_Clean_Txt()
        {
            G2_Name_Txt.Clear();
            G2_Address_Txt.Clear();
            G2_Phone_Txt.Clear();
        }

        private string G2_Validate_Txt(string fieldName, string text)
        {
            if (text.Length == 0) throw new Exception($"El campo {fieldName} está vacío");
            return text;
        }

        private void G2_Add_Btn_Click(object sender, EventArgs e)
        {
            string name, address, phone;
            try
            {
                name = G2_Validate_Txt("Nombre", G2_Name_Txt.Text);
                address = G2_Validate_Txt("Dirección", G2_Address_Txt.Text);
                phone = G2_Validate_Txt("Teléfono", G2_Phone_Txt.Text);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
          
            G2Owner owner = new G2Owner(name, address, phone);
            G2OwnerArray.owners.Add(owner);
            G2_Set_Items_To_View();
            MenuForm.petsForm.G2_Set_Owners_In_Combobox();
            G2_Clean_Txt();
            MessageBox.Show("Dueño registrado");
        }

        private void G2_Clean_Btn_Click(object sender, EventArgs e)
        {
            G2_Clean_Txt();
        }
    }
}
