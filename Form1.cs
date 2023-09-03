using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_TRANSFORMAR_Click(object sender, EventArgs e)
        {
            string cadena = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una cantidad a transformar");
            bool validez = true;
            /// VALIDAMOS NOT NULL
            if( string.IsNullOrEmpty(cadena))
            {
                MessageBox.Show(" No puedes ingresar vacios");
                validez = false;
            }
            /// VALIDAMOS NUMERO VALIDO
            if( !double.TryParse( cadena , out double cantidad) )
            {
                MessageBox.Show(" Valor invalido ");
                validez = false;

            }

            /// TOMAMOS LOS VALORES CORRESPONDIENTES DE LOS CHECK BOXS
            string escalaInicial = obtenerEscalaInicial();
            string escalaFinal = obtenerEscalaFinal();

            /// REALIZAMOS LAS TRANSFORMACIONES
            double convercion = Transformacion(cantidad, escalaInicial, escalaFinal);

            
            if (validez == true )
            {
                DT_1.Rows.Add(escalaInicial, cantidad, escalaFinal, convercion);
            }
        }
        private string obtenerEscalaInicial()
        {
            if (RD1_Celcius.Checked) { return "Celcius"; }
            if (RD1_Fahrenheit.Checked) { return "Fahrenheit"; }
            if (RD1_Kelvin.Checked) { return "Kelvin"; }
            if (RD1_Rankine.Checked) { return "Rankine"; }
            return string.Empty;
        }
        private string obtenerEscalaFinal()
        {
            if ( RD2_Celcius.Checked ) { return "Celcius"; }
            if ( RD2_Fahrenheit.Checked ) { return "Fahrenheit"; }
            if ( RD2_Kelvin.Checked ) { return "Kelvin"; }
            if ( RD2_Rankine.Checked ) { return "Rankine"; }
            return string.Empty;
        }
        private double Transformacion( double cantidad, string escalaInicial, string escalaFinal )
        {
            if (escalaInicial == escalaFinal) return cantidad;
            double resultado = 0.0;
            switch(escalaInicial)
            {
                case "Celcius":
                    resultado = Calcular_Desde_Celcius( cantidad, escalaFinal);
                    break;
                case "Fahrenheit":
                    resultado = Calcular_Desde_Fahrenheit(cantidad, escalaFinal);
                    break;
                case "Kelvin":
                    resultado = Calcular_Desde_Kelvin(cantidad, escalaFinal);
                    break;
                case "Rankine":
                    resultado = Calcular_Desde_Rankine(cantidad, escalaFinal);
                    break;
                default:
                    break;
            }
            return resultado;

        }
        private double Calcular_Desde_Celcius( double cantidad, string escalaFinal)
        {
            switch(escalaFinal)
            {
                case "Fahrenheit":
                    return (cantidad * 9 / 5) + 32;
                    break;
                case "Kelvin":
                    return cantidad + 273.15;
                    break;
                case "Rankine":
                    return (cantidad * 9 / 5) + 491.67;
                    break;
                default:
                    return cantidad;
                    break;
            }
        }
        private double Calcular_Desde_Fahrenheit( double cantidad, string escalaFinal)
        {
            switch(escalaFinal)
            {
                case "Celcius":
                    return (cantidad - 32) * 5 / 9;
                    break;
                case "Rankine":
                    return cantidad + 459.67;
                    break;
                case "Kelvin":
                    return ( cantidad - 32 ) * 5 / 9 + 273.15;
                    break;
                default:
                    return cantidad;
                    break;
            }
        }
        private double Calcular_Desde_Kelvin( double cantidad, string escalaFinal)
        {
            switch(escalaFinal)
            {
                case "Celcius":
                    return cantidad - 273.15;
                    break;
                case "Rankine":
                    return cantidad * 1.8;
                    break;
                case "Fahrenheit":
                    return (cantidad - 273.15) * 9 / 5 + 32;
                    break;
                default:
                    return cantidad;
                    break;
            }
        }
        private double Calcular_Desde_Rankine( double cantidad, string escalaFinal)
        {
            switch (escalaFinal)
            {
                case "Celcius":
                    return (cantidad - 491.67) * 5 / 9;
                    break;
                case "Fahrenheit":
                    return cantidad - 459.67;
                case "Kelvin":
                    return cantidad * 5 / 9;
                    break;
                default:
                    return cantidad;
                    break;
            }
        }

    }
}
