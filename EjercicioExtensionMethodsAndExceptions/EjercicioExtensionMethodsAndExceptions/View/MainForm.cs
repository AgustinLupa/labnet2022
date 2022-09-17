using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioExtensionMethodsAndExceptions.View;
using EjercicioExtensionMethodsAndExceptions.Controller;
using EjercicioExtensionMethodsAndExceptions.Exceptions;

namespace EjercicioExtensionMethodsAndExceptions
{
    public partial class MainForm : Form
    {
        DataController dataController = new DataController();
        public MainForm()
        {
            InitializeComponent();
            lExercise1.Text += "Realizar un método que al ingresar un " +
                "valor \n genere una simple excepción al intentar hacer" +
                "\n una división por cero. Esta misma excepción \n " +
                "deberá ser capturada, mostrando el mensaje \n de la " +
                "excepción y siempre deberá avisar \n cuando terminó de" +
                " realizarse la operación \n haya sido exitosa  o no.";
            lExercise2.Text += "Realizar un método que permita ingresar 2 " +
                "\n números (dividendo y divisor) y realice la \n" +
                " división de los mismos. Se deberán mostrar \n el " +
                "resultado (Si es un Unit Test tener en cuenta \n " +
                "los Assert). Si hay una excepción de división \n" +
                " por cero se deberá mostrar el siguiente mensaje: \n" +
                " “Solo Chuck Norris divide por cero!” \n" +
                "(Se acepta todo tipo de creatividad) más \n el mensaje" +
                " de la excepción propia.También se \n deberá capturar " +
                "una excepción si el usuario \n no ingresa ningún número" +
                " o el mismo no es \n un número válido, informando la" +
                " situación de\n “Seguro Ingreso una letra o no ingreso" +
                " nada!”.";
            lExercise3.Text += "Realizar un método en una clase" +
                " “Logic”,\n llamado desde la “presentación” " +
                "(Consola,\n UnitTest, Etc.), que dispare una" +
                " excepción.\n La misma deberá ser capturada " +
                "por la \n“presentación”. Deberá mostrar el mensaje\n" +
                " de la excepción y el tipo de la excepción.";
            lExercise4.Text += "Volver a realizar el ejercicio " +
                "anterior pero\n esta vez la lógica deberá simplemente\n " +
                "devolver un tipo de excepción personalizada\n y ser " +
                "capturada por la misma aplicación.";
        }

        private void btnExercise1_Click(object sender, EventArgs e)
        {
            this.Enabled=false;
            FormExercise1 exercise1 = new FormExercise1(dataController);
            exercise1.Owner = this;
            exercise1.ShowDialog();
            
        }

        private void btnExercise2_Click(object sender, EventArgs e)
        {
            this.Enabled =false;
            FormExercise2 exercise2 = new FormExercise2(dataController);
            exercise2.Owner = this;
            exercise2.ShowDialog();
        }

        private void btnExercise3_Click(object sender, EventArgs e)
        {
            try
            {
                dataController.Exercise3();
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show(ex + "\n\n" + ex.Message, "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnExercise4_Click(object sender, EventArgs e)
        {
            try
            {
                dataController.Exercise4();
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex + "\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
