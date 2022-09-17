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
using EjercicioExtensionMethodsAndExceptions.Exceptions;

namespace EjercicioExtensionMethodsAndExceptions.View
{
    public partial class FormExercise2 : Form
    {
        DataController auxDataController;
        public FormExercise2(Controller.DataController dataController)
        {
            InitializeComponent();
            auxDataController = dataController;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                int result = auxDataController.Exercise2Divide(txtDividend.Text, txtDivider.Text);
                MessageBox.Show($"El resultado es {result}", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            catch (EmptyInputException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Seguro Ingreso una letra o no ingreso nada!" + "Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Owner.Enabled = true;
            this.Close();
        }
    }
}
