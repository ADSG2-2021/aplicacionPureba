using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList numeros = new ArrayList();

        void agregarNumeros(ArrayList lista)
        {
            int i,num;

            for (i = 0; i < 10; i++)
            {
                num = int.Parse(Interaction.InputBox("Agrega un numero a la lista"));
                numeros.Add(num);
                if (i == 9)
                    MessageBox.Show("La lista está completa");
            }
           
        }

        void insertarNumero(ArrayList numeros)
        {
            int posicion, valor;
            posicion = int.Parse(Interaction.InputBox("Introduzca la posicion que desea para el numero"));
            valor = int.Parse(Interaction.InputBox("Introduzca el numero que desea introducir"));
            MessageBox.Show($"Vamos a introducir el numero {valor} en la posicion {posicion} de la lista");
            
            if (posicion >= 0 && posicion <= numeros.Count)
            {
                numeros.Insert(posicion, valor);
                MessageBox.Show($"El numero {valor} ha sido introducido correctamente");
            }
            else
            {
                MessageBox.Show($"Inserte el numero dentro de los limites de la lista");
                MessageBox.Show($"Nueva 1");
                MessageBox.Show($"Nueva 2");

            }
        }

        string mostrarLista(ArrayList lista)
        {
            string texto;
            texto = "Los elementos dentro de la lista son:\n\n";

            foreach(int numero in lista)
            {
                texto = texto + numero + ",";
            }
            return texto;
        }

        void buscarElemento(ArrayList lista)
        {
            int numero, posicion;

            numero = int.Parse(Interaction.InputBox("Introduzca el numero que desea buscar"));
            posicion = numeros.IndexOf(numero);

            if (posicion >= 0)
                MessageBox.Show($"El numero {numero} se encuentra en la posicion {posicion}");
            else 
                MessageBox.Show($"El numero {numero} no esta dentro de la lista");
        }

        void eliminarElemento(ArrayList lista)
        {           
            int numero = int.Parse(Interaction.InputBox("Introduce el numero que deseas eliminar"));
            numeros.Remove(numero);
            MessageBox.Show($"El numero {numero} ha sido borrado de la lista");
        }

        void eliminarPosicion(ArrayList lista)
        {
            int posicion = int.Parse(Interaction.InputBox("Introduzca la posicion que desea eliminar de la lista"));
            if (posicion <= lista.Count)
            {
                numeros.RemoveAt(posicion);
                MessageBox.Show($"La posicion {posicion} ha sido borrada de la lista");
            }
            else
            {
                MessageBox.Show($"La posicion {posicion} esta fuera de la lista");
            }
            
        }

        void ordenarLista(ArrayList lista)
        {
            lista.Sort();
            MessageBox.Show("La lista ha sido ordenada");
        }

        void eliminarLista(ArrayList lista)
        {
            lista.Clear();
            MessageBox.Show("La lista ha sido eliminada");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            agregarNumeros(numeros);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insertarNumero(numeros);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string texto;
            texto = mostrarLista(numeros);
            MessageBox.Show(texto);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buscarElemento(numeros);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                eliminarElemento(numeros);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ha ocurrido un error: {error.Message}");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                eliminarPosicion(numeros);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ha ocurrido un error: {error.Message}");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ordenarLista(numeros);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            eliminarLista(numeros);
        }
    }
}
