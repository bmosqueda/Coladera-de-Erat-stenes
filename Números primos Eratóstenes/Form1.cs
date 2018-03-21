using System;
using System.Windows.Forms;

namespace Números_primos_Eratóstenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class ColaderaEratostenes
        {
            public static string getPrimos(int limite)
            {
                string primos = "";
                //Todos los índices que contengan al final un 1 se consideran números primos
                int[] numeros = new int[limite + 1];
                for (int i = 0; i < numeros.Length; i++)
                    numeros[i] = 1;

                int indice = 2;
                int valor = indice;

                do
                {
                    while(indice < numeros.Length)
                    {
                        indice += valor;
                        if(indice < numeros.Length)
                            numeros[indice] = 0;
                    }
                    indice = getNextIndice(numeros, valor);
                    valor = indice;
                //SI el siguiente número elevado al cuadrado es mayor o igual que el límite, no tiene caso seguir buscando más
                }while (Math.Pow(indice, 2) < limite) ;
                
                for(int i = 2; i < numeros.Length; i++)
                {
                    if (numeros[i] == 1)
                        primos += i + ", ";
                }
                return primos;
            }

            private static int getNextIndice(int[] vector, int anterior)
            {
                for(int i = anterior + 1; i < vector.Length; i++)
                {
                    if (vector[i] == 1)
                        return i;
                }
                return -1;
            }
        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            txtPrimos.Text = ColaderaEratostenes.getPrimos(1000);
        }
    }
}
