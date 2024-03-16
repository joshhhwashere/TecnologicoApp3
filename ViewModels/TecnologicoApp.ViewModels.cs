using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnologicoApp.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        // Evento que se dispara cuando una propiedad cambia
        public event PropertyChangedEventHandler PropertyChanged;

        // Método para notificar a la vista cuando una propiedad ha cambiado
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Propiedades para los números y el resultado de la operación
        private double _numero1;
        public double Numero1
        {
            get { return _numero1; }
            set
            {
                if (_numero1 != value)
                {
                    _numero1 = value;
                    OnPropertyChanged(nameof(Numero1));
                }
            }
        }

        private double _numero2;
        public double Numero2
        {
            get { return _numero2; }
            set
            {
                if (_numero2 != value)
                {
                    _numero2 = value;
                    OnPropertyChanged(nameof(Numero2));
                }
            }
        }

        private double _resultado;
        public double Resultado
        {
            get { return _resultado; }
            set
            {
                if (_resultado != value)
                {
                    _resultado = value;
                    OnPropertyChanged(nameof(Resultado));
                }
            }
        }

        // Constructor
        public MainPageViewModel()
        {
            // Inicializar propiedades
            Numero1 = 0;
            Numero2 = 0;
            Resultado = 0;
        }

        // Método para realizar la suma
        public async Task Sumar()
        {
            Resultado = await Task.FromResult(Numero1 + Numero2);
        }

        // Método para realizar la resta
        public async Task Restar()
        {
            Resultado = await Task.FromResult(Numero1 - Numero2);
        }

        // Método para realizar la multiplicación
        public async Task Multiplicar()
        {
            Resultado = await Task.FromResult(Numero1 * Numero2);
        }

        // Método para realizar la división
        public async Task Dividir()
        {
            if (Numero2 == 0)
            {
                // Manejo de la división por cero
                Resultado = double.NaN;
            }
            else
            {
                Resultado = await Task.FromResult(Numero1 / Numero2);
            }
        }
    }
}