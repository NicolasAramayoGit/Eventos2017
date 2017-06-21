using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Eventos
{

  
    
    public class Juego
    {
        //DECLARO LOS EVENTOS DE LA CLASE
        public event JuegoGanado Ganar;
        public event JuegoContinua Segir;
        public event JuegoPerdido Perder;
        public event Proximidad proximo;

        private static Random _generadorDeNumeros;

        private int _numeroSecreto;
        private int _cantidadIntentos;
        private EDificultad _dificultad;

        private int _numero;

        public int Numero
        {
            get { return this._numero; }
            set 
            { 
                this._numero = value;
                this._cantidadIntentos++;
                this.AdministrarJugada();               
            }
        }
        public string pista
        {
            get {
                    string pista="";
                    if (this._numero != this._numeroSecreto)
                    {
                        if (Math.Abs(this._numero - this._numeroSecreto) < 10)
                        {
                            this.proximo(10);

                        }
                        if (this._numero > this._numeroSecreto)
                        {
                            pista = "te pasaste";
                        }
                        else
                        {                        
                            pista = "te falta....";              
                        }                
                    } 
                
                    return pista; 
            }
        }
        public int CantidadIntentos
        {
            get { return this._cantidadIntentos; }
        }
        public int IntentosMaximos
        {
            get { return (int)this._dificultad; }
        }
        static Juego() 
        {
            Juego._generadorDeNumeros = new Random();
        }

        public Juego(EDificultad dificultad)
        {
            this._numeroSecreto = Juego._generadorDeNumeros.Next(100);
            this._dificultad = dificultad;
            this._cantidadIntentos = 0;
        }

        private void AdministrarJugada()
        {
            if (this._cantidadIntentos == (int)this._dificultad)
            {
                if (this.Gano())
                {
                    //GANO
                    this.Ganar(this, new EventArgs());
                }
                else
                {
                    //PERDIO
                    this.Perder(this, new JuegoEventArgs(this._numeroSecreto));
                }
            }
            else if (this._cantidadIntentos < (int)this._dificultad)
            {
                if (this.Gano())
                {
                    //GANO
                    this.Ganar(this, new EventArgs());
                }
                else
                {
                    //SIGUE PARTICIPANDO
                    this.Segir(this, new EventArgs());
                }
            }
            else
            {
                //PERDIO...
                this.Perder(this, new JuegoEventArgs(this._numeroSecreto));
            }
        }

        private bool Gano()
        {
            bool gano = false;
            if (this._numero == this._numeroSecreto)
            {
                gano = true;
            }
            return gano;
        }
    }
}
