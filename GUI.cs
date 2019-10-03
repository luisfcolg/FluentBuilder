using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentBuilder.Models;
using FluentBuilder.Builder;

namespace FluentBuilder
{
    public partial class GUI : Form
    {
        private List<Cuenta> _cuentas = new List<Cuenta>();

        public GUI()
        {
            InitializeComponent();

            dataGridView1.DataSource = new BindingSource { DataSource = _cuentas };
            comboBox1.SelectedIndex = 1;
        }

        private void crear_Click(object sender, EventArgs e)
        {
            bool cuentaExists = false;
            foreach(Cuenta c in _cuentas)
            {
                if (c.Numero == numericUpDownNumero.Value)
                {
                    cuentaExists = true;
                    break;
                }
            }

            if (textBoxPropietario.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }
            else if(numericUpDownNumero.Value == 0 | cuentaExists)
            {
                MessageBox.Show("Por favor seleccione un número de cuenta válido.");
                return;
            }

            Cuenta cuenta = CuentaFluentBuilder.Crear((TipoEnum)Enum.Parse(typeof(TipoEnum), comboBox1.SelectedItem.ToString()))
                .AgregarNumero(Decimal.ToInt32(numericUpDownNumero.Value))
                .AgregarPropietario(textBoxPropietario.Text)
                .AgregarTasa(Decimal.ToDouble(numericUpDownTasa.Value))
                .AgregarSaldo(Decimal.ToDouble(numericUpDownSaldo.Value))
                .Finalizar();

            _cuentas.Add(cuenta);
            dataGridView1.DataSource = new BindingSource { DataSource = _cuentas };

            comboBox1.SelectedIndex = 1;
            numericUpDownNumero.Value = 0;
            textBoxPropietario.Text = "";
            numericUpDownTasa.Value = 0;
            numericUpDownSaldo.Value = 0;

            MessageBox.Show("La cuenta se ha generado exitosamente.");
        }
    }
}
