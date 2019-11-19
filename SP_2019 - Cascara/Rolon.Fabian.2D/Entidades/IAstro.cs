using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
  interface IAstro<T>
  {
      Thread HiloOrbita
      {
          get;
          set;  
      }

      string Orbitar();
      string Rotar();
      void RunEvntOrb();
      void RunEvntRotar();
  }
}
