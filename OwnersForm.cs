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

        // Setear los items en el DataGrid del formulario
        private void G2_Set_Items_To_View()
        {
            G2_Owners_DataGrid.Rows.Clear();
            foreach (G2Owner owner in G2OwnerArray.owners)
            {
                G2_Owners_DataGrid.Rows.Add(owner.G2_name, owner.G2_address, owner.G2_phone);
            }
        }

        // Limpiar el formulario
        private void G2_Clean_Txt()
        {
            G2_Name_Txt.Clear();
            G2_Address_Txt.Clear();
            G2_Phone_Txt.Clear();
        }

        // Valida que haya texto escrito en las cajas de texto. Sino, retorna una excepción con el nombre del campo vacío.
        private string G2_Validate_Txt(string fieldName, string text)
        {
            if (text.Length == 0) throw new Exception($"El campo {fieldName} está vacío");
            return text;
        }

        // Evento de agregar una nueva mascota
        private void G2_Add_Btn_Click(object sender, EventArgs e)
        {
            // Inicialización de variables
            string name, address, phone;
            try
            {
                // Obtención de datos del formulario
                name = G2_Validate_Txt("Nombre", G2_Name_Txt.Text);
                address = G2_Validate_Txt("Dirección", G2_Address_Txt.Text);
                phone = G2_Validate_Txt("Teléfono", G2_Phone_Txt.Text);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // Creación de la instancia dueño
            G2Owner owner = new G2Owner(name, address, phone);

            // Agregando al arreglo
            G2OwnerArray.owners.Add(owner);

            // Mostrando los dueños nuevamente en el DataGrid
            G2_Set_Items_To_View();

            // Actualizando los items de la lista desplegable de dueños en el formulario de mascotas
            MenuForm.petsForm.G2_Set_Owners_In_Combobox();

            // Limpiando el formulario
            G2_Clean_Txt();
            MessageBox.Show("Dueño registrado");
        }

        // Evento para limpiar el formulario
        private void G2_Clean_Btn_Click(object sender, EventArgs e)
        {
            G2_Clean_Txt();
        }
    }
}
