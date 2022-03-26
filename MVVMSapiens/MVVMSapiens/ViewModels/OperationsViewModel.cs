using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMSapiens.ViewModels
{
    public class OperationsViewModel : ViewModelBase
    {

        #region Propieades
        int valor1;
        public int Valor1
        {
            get { return valor1; }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }
            }
        }

        int valor2;
        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }
            }
        }


        int resultadoSuma;
        public int ResultadoSuma
        {
            get { return resultadoSuma; }
            set
            {
                if (resultadoSuma != value)
                {
                    resultadoSuma = value;
                    OnPropertyChanged();
                }
            }
        }
        string resultadoConcatenar;
        public string ResultadoConcatenar
        {
            get { return resultadoConcatenar; }
            set
            {
                if (resultadoConcatenar != value)
                {
                    resultadoConcatenar = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoResta;
        public int ResultadoResta
        {
            get { return resultadoResta; }
            set
            {
                if (resultadoResta != value)
                {
                    resultadoResta = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Comandos
        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Concatenar { protected set; get; }


        #endregion


        public OperationsViewModel()
        {
            Sumar = new Command(() =>
            {
                ResultadoSuma = Valor1 + Valor2;
            });

            Restar = new Command(() =>
            {
                ResultadoResta = Valor1 - Valor2;
            });

            Concatenar = new Command<string>(
              execute: (string parameter) =>
              {
                  ResultadoConcatenar = string.Concat(ResultadoConcatenar, parameter);
              }
              );
        }
    }
}
