using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezSP2A
{
    public partial class frmRegistro : Form
    {
        private const float TIPOA = 20;
        public const float TIPOB = 34;
        const float COCINA = 1;
        const float HELADERA = 1.5f;
        const float TELEVISOR = 2;
        const float PORPERSONA = 1;
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void lblPersonas_Click(object sender, EventArgs e)
        {

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.Text != "")
            {
                cboPersonas.Enabled = true;
                lblPersonas.Enabled = true;
            }
            else
            {
                cboPersonas.Enabled = false;
                lblPersonas.Enabled = false;
            }
            int I = 0;
            if (cboTipo.SelectedIndex == 0)
            {
                for (I = 1; I < 5; I++)
                {
                    cboPersonas.Items.Add(I);

                }
            }
            else
            {
                for (I = 1; I < 9; I++)
                {
                    cboPersonas.Items.Add(I);

                }
            }
            cboPersonas.SelectedIndex = 0;
        }

        private void cboPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPersonas.Text != "")
            {
                txtDias.Enabled = true;
                lblDias.Enabled = true;
            }
            else
            {
                txtDias.Enabled = false;
                lblDias.Enabled = false;
            }
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            if (txtDias.Text != "")
            {
                mcrAdicionales.Enabled = true;
                mcrPago.Enabled = true;
            }
            else
            {
                mcrAdicionales.Enabled = false;
                mcrPago.Enabled = false;
            }
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (optEfectivo.Checked == true)
            {
                cboTarjetas.Enabled = false;
            }
            else
            {
                cboTarjetas.Enabled = true;
            }
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            // cargar los items en el primer control combobox
            cboTipo.Items.Clear();
            cboTipo.Items.Add("Tipo A");
            cboTipo.Items.Add("Tipo B");
            // esta acción provoca el disparo del evento "SelectedIndexChanged"
            cboTipo.SelectedIndex = 0;
            // se inicializa la cantidad de días en 1
            txtDias.Text = "1";
            // inicialzar los demás controles de la interfaz
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
            // en los radiobuttons se asigna sólo el que debe quedar en true
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefono.Text = "";
            // cargar los items del combo de tarjetas
            cboTarjetas.Items.Clear();
            cboTarjetas.Items.Add("Card Red");
            cboTarjetas.Items.Add("Card Green");
            cboTarjetas.Items.Add("Card Blue");
            // deshabiliar el botón "Aceptar"
            btnAceptar.Enabled = false;

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtDias.Text != "" && txtDias.Text != "0" && txtNombre.Text != "" && txtTelefono.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtDias.Text != "" && txtDias.Text != "0" && txtNombre.Text != "" && txtTelefono.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float PrecioBase;
            float Opcionales;
            float Recargo;
            int Dias;
            float Total;



            Dias = int.Parse(txtDias.Text);
            // controlar el tipo de cabaña para determinar el precio base
            if (cboTipo.SelectedIndex == 0)
            {
                PrecioBase = TIPOA;
            }
            else
            {
                PrecioBase = TIPOB;
            }
            PrecioBase = PrecioBase + (PORPERSONA * int.Parse(cboPersonas.Text));
            Opcionales = 0;
            if (chkCocina.Checked == true)
            {
                Opcionales = Opcionales + COCINA;
            }
            if (chkHeladera.Checked = true)
            {
                Opcionales = Opcionales + HELADERA;
            }
            if (chkTelevisor.Checked = true)
            {
                Opcionales = Opcionales + TELEVISOR;
            }
            Total = (PrecioBase + Opcionales) * Dias;
            if (optTarjetas.Checked == true)
            {
                if (cboTarjetas.SelectedIndex == 0)
                {
                    Recargo = Total * 10 / 100;
                }
                else
                {
                    Recargo = Total * 20 / 100;
                }
                Total = Total + Recargo;
            }

            MessageBox.Show("Total = US$" + Total.ToString(), "Importe de la reserva",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboTipo.SelectedIndex = 0;
            txtDias.Text = "1";
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
            // en los radiobuttons se asigna sólo el que debe quedar en true
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }  }
