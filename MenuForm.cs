using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2_FP_01
{
    public partial class MenuForm : Form
    {

        public static OwnersForm ownersForm = new OwnersForm();
        public static PetsForm petsForm = new PetsForm();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void G2_Owner_Btn_Click(object sender, EventArgs e)
        {
            ownersForm.Show();
        }

        private void G2_Pet_Btn_Click(object sender, EventArgs e)
        {
            petsForm.Show();
        }
    }
}
