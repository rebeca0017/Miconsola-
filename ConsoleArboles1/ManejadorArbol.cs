using System;
using System.Linq;

namespace Arbol
{
    class ManejadorArbol
    {
        //recursivo: porque se llama a si mismo
       /* internal string ImprimirArbolInfijo(Nodo nodo)
        {
            //analiza el comportamiento de una hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            //analiza cuando no soy hoja
            return $"( {ImprimirArbolInfijo(nodo.Hijos[0])}  {nodo.Valor} {ImprimirArbolInfijo(nodo.Hijos[1])} )";
        }

        internal string ImprimirArbolPrefijo(Nodo nodo)
        {
            //analiza el comportamiento de una hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            //analiza cuando no soy hoja
            return $"{nodo.Valor} ( {ImprimirArbolPrefijo(nodo.Hijos[0])} {ImprimirArbolPrefijo(nodo.Hijos[1])})";
        }

        internal string ImprimirArbolPostfijo(Nodo nodo)
        {
            //analiza el comportamiento de una hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;
            //analiza cuando no soy hoja
            return $"( {ImprimirArbolPostfijo(nodo.Hijos[0])} {ImprimirArbolPostfijo(nodo.Hijos[1])}) {nodo.Valor}";
        }*/
        internal string ImprimirArbol(Nodo nodo, Notacion notacion)
        {
            //analiza el comportamiento de una hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;

           

            return notacion switch
            {

                Notacion.Infijo => $"( {ImprimirArbol(nodo.Hijos[0], notacion)}  {nodo.Valor} {ImprimirArbol(nodo.Hijos[1], notacion)})",
                Notacion.Prefijo => $"{nodo.Valor} ( {ImprimirArbol(nodo.Hijos[0], notacion)} {ImprimirArbol(nodo.Hijos[1], notacion)} ",
                Notacion.Postfijo => $"( {ImprimirArbol(nodo.Hijos[0], notacion)} {ImprimirArbol(nodo.Hijos[1], notacion)}) {nodo.Valor} ",
                _ => "tipo de notacion no implementada",
            };


        }

       
        internal int NumeroHojas(Nodo nodo)
        {
            if (SoyHoja(nodo))
            {
                return 1;
            }

            int totalHojas = 0;
            foreach (Nodo hijoActual in nodo.Hijos)
            {
                totalHojas += NumeroHojas(hijoActual);
            }
            return totalHojas;
        }


        internal int NumeroNodos(Nodo nodo)
        {
            if (SoyHoja(nodo))
            {
                return 1;
            }

            int totalNodos = 0;
            foreach (Nodo nodoActual in nodo.Hijos)
            {
                totalNodos += NumeroNodos(nodoActual);
            }
            return totalNodos + 1;
        }


        internal int NumeroNiveles(Nodo nodo, int nivel)
        {
            if (nodo == null)

                return 0;

            if (SoyHoja(nodo))

                return ++nivel;

            foreach (var nodoActual in nodo.Hijos)
            {
                var nivelActual = NumeroNiveles(nodoActual, nivel);
                if (nivel < nivelActual)
                    nivel = nivelActual;
            }
            return ++nivel;
        }

        public bool SoyHoja(Nodo nodo)
        {
            return !nodo.Hijos.Any();
        }
    }

   
}


