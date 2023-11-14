using GuarderiaCanina.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuarderiaCanina.Utils
{
    public class ComboUtils
    {
        public static void CargarComboG(ref ComboBox combo,
            List<Empleado> lista, Empleado seleccionado)
        {
            var conector = new BindingSource();
            conector.DataSource = lista;

            combo.DataSource = conector;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdCEmpleado";

            if (seleccionado != null)
                combo.SelectedItem = seleccionado;
        }

        public static void CargarCombo(ref ComboBox combo,
            BindingSource conector)
        {
            combo.DataSource = conector;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "Id";

        }

        public static void CargarComboM(ref ComboBox combo,
    List<Mascota> lista, Mascota seleccionado)
        {
            var conector = new BindingSource();
            conector.DataSource = lista;

            combo.DataSource = conector;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "Id";

            if (seleccionado != null)
                combo.SelectedItem = seleccionado;
        }

        public static void CargarComboM(ref ComboBox combo,
            BindingSource conector)
        {
            combo.DataSource = conector;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "Id";

        }
    }
}
