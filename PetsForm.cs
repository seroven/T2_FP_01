using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T2_FP_01.arrays;
using T2_FP_01.classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace T2_FP_01
{
    public partial class PetsForm : Form
    {
        public PetsForm()
        {
            InitializeComponent();
            G2_Set_Owners_In_Combobox();
            G2_Set_Items_To_View();
        }
        
        // Setear los dueños en el combobox del formulario
        public void G2_Set_Owners_In_Combobox()
        {
            G2_Owner_Cbx.Items.Clear();
            foreach (G2Owner owner in G2OwnerArray.owners)
            {
                G2_Owner_Cbx.Items.Add(owner.G2_name);
            }
        }

        // Setear los items en el DataGrid del formulario
        private void G2_Set_Items_To_View()
        {
            G2_Pets_DataGrid.Rows.Clear();
            foreach (G2Pet pet in G2PetArray.pets)
            {
                G2_Pets_DataGrid.Rows.Add(pet.G2_name, pet.G2_breed, pet.G2_age, pet.G2_owner.G2_name);
            }
        }

        // Limpiar el formulario
        private void G2_Clean_Txt()
        {
            G2_Name_Txt.Clear();
            G2_Breed_Txt.Clear();
            G2_Age_Txt.Clear();
            G2_Owner_Cbx.SelectedIndex = -1;
        }

        // Valida que haya texto escrito en las cajas de texto. Sino, retorna una excepción con el nombre del campo vacío.
        private string G2_Validate_Txt(string fieldName, string text)
        {
            if (text.Length == 0) throw new Exception($"El campo {fieldName} está vacío");
            return text;
        }

        // Valida que haya una opción seleccionada en las listas desplegables. Sino, retorna una excepción con el nombre del campo vacío.
        private int G2_Validate_Cbx(string fieldName, int index)
        {
            if (index < 0) throw new Exception($"No ha seleccionado un elemento en la lista desplegable de {fieldName} ");
            return index;
        }

        // Evento de agregar una nueva mascota
        private void G2_Add_Btn_Click(object sender, EventArgs e)
        {
            // Inicialización de variables
            string name, breed, age;
            G2Owner owner;
            try
            {
                // Obtención de datos del formulario
                name = G2_Validate_Txt("Nombre", G2_Name_Txt.Text);
                breed = G2_Validate_Txt("Raza", G2_Breed_Txt.Text);
                age = G2_Validate_Txt("Edad", G2_Age_Txt.Text);
                owner = G2OwnerArray.owners[G2_Validate_Cbx("Dueños", G2_Owner_Cbx.SelectedIndex)];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            // Creación de la instancia mascota
            G2Pet pet = new G2Pet(name, age, breed, owner);

            // Agregando al arreglo
            G2PetArray.pets.Add(pet);

            // Mostrando las mascotas nuevamente en el DataGrid
            G2_Set_Items_To_View();

            // Limpiando el formulario
            G2_Clean_Txt();
            MessageBox.Show("Mascota registrada");
        }

        // Evento para limpiar el formulario
        private void G2_Clean_Btn_Click(object sender, EventArgs e)
        {
            G2_Clean_Txt();
        }

        // Evento para buscar una mascota
        private void G2_Search_By_Name_Btn_Click(object sender, EventArgs e)
        {
            // Inicialización de variables
            string name;
            try
            {
                // Obtención de datos del formulario
                name = G2_Validate_Txt("Nombre", G2_Search_By_Name_Txt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // Búsqueda de la mascota recorriendo el arreglo
            foreach (G2Pet pet in G2PetArray.pets)
            {
                // Muestra de la mascota al hallar una coincidencia
                if (pet.G2_name.ToLower() == name.ToLower())
                {
                    MessageBox.Show($"Mascota encontrada!\nNombre: {pet.G2_name}\nRaza: {pet.G2_breed}\nEdad: {pet.G2_age}\nDueño: {pet.G2_owner.G2_name}");
                    return;
                }
            }

            MessageBox.Show("No se ha encontrado una mascota con ese nombre");

        }
    }
}
