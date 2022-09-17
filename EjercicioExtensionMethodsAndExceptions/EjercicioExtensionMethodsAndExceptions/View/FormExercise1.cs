using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioExtensionMethodsAndExceptions.Controller;

namespace EjercicioExtensionMethodsAndExceptions.View
{
    public partial class FormExercise1 : Form
    {
        DataController auxDataController;
        public FormExercise1(Controller.DataController dataController)
        {
            InitializeComponent();
            auxDataController = dataController;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {                        
            Owner.Enabled=true;
            this.Close();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                auxDataController.DivideNumber((int)numAnyNumber.Value);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Operacion Finalizada","Finalizado" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
