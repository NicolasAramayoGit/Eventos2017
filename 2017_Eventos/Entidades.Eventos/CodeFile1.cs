using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace Entidades.Eventos
{
   

    //DECLARO DELEGADOS PARA INTERACTUAR CON LOS EVENTOS. DECLARARLOS EN UN CODEFILE
    public delegate void JuegoGanado(object sender, EventArgs e);
    public delegate void JuegoContinua(object sender, EventArgs e);
    public delegate void JuegoPerdido(object sender, JuegoEventArgs e);
    public delegate void Proximidad(int Porcentaje);

   
}
