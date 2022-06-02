using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibioteca;

namespace Vista
{
    public partial class FrmAtencion : Form
    {
        public FrmAtencion()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Fede", "Dávila", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Esteban", "Prieto", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Diego", "Cagna", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Alfredo", "Moreno", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Blas", "Giunta", new DateTime(1912, 12, 12), "La Boca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellín"));

        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
           
            PersonalMedico? personalMedico = lstMedicos.SelectedItem as PersonalMedico;
            Paciente? paciente = lstPacientes.SelectedItem as Paciente;
            if(personalMedico is not null && paciente is not null)
            {
                paciente.Diagnostico = "Paciente curado";
                lstMedicos.ClearSelected();
                lstPacientes.ClearSelected();
                //
                Consulta consulta = personalMedico + paciente;

               MessageBox.Show(consulta.ToString(),"Atencion finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar.", "Error de los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            rtbInfoMedico.Text = Persona.FichaPersonal(personalMedico);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonalMedico? personalMedico = lstMedicos.SelectedItem as PersonalMedico;
            if (personalMedico is not null)
            {
                rtbInfoMedico.Text = Persona.FichaPersonal(personalMedico); //
            }
            
        }

    }
}
