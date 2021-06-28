using System;

namespace Arbol
{
    class Program
    {
        static void Main(string[] args)
        {

            var raiz = new Nodo
            {
                Valor = "*",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "+",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "8"

                            },
                            new Nodo
                            {
                                Valor = "5"
                            }
                        }

                    },
                     new Nodo

                    {
                        Valor = "-",
                        Hijos =

                        {
                            new Nodo

                            {
                                Valor = "7",

                            },
                            new Nodo

                            {
                                Valor = "4",

                            },
                            new Nodo

                            {
                                Valor = "10",
                            },
                            new Nodo

                            {
                                Valor = "3",
                            }
                        }
                    },
                      new Nodo

                    {
                        Valor = "+",
                        Hijos =

                        {
                            new Nodo

                            {
                                Valor = "10",

                            },
                            new Nodo

                            {
                                Valor = "10",

                            }
                        }
                    },
                      new Nodo

                    {
                        Valor = "+",
                        Hijos =

                        {
                            new Nodo

                            {
                                Valor = "4",

                            },
                            new Nodo

                            {
                                Valor = "1",

                            }
                        }
                    }



                }
            };
           new Nodo
            {
                Valor = "/",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "+",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "8"

                            },
                            new Nodo
                            {
                                Valor = "5"
                            }
                        }

                    },
                     new Nodo

                    {
                        Valor = "-",
                        Hijos =

                        {
                            new Nodo

                            {
                                Valor = "7",

                            },
                            new Nodo

                            {
                                Valor = "4",

                            },
                            new Nodo

                            {
                                Valor = "10",
                            },
                            new Nodo

                            {
                                Valor = "3",
                            }
                        }
                    },
                      new Nodo

                    {
                        Valor = "+",
                        Hijos =

                        {
                            new Nodo

                            {
                                Valor = "10",

                            },
                            new Nodo

                            {
                                Valor = "10",

                            }
                        }
                    },
                      new Nodo

                    {
                        Valor = "+",
                        Hijos =

                        {
                            new Nodo

                            {
                                Valor = "4",

                            },
                            new Nodo

                            {
                                Valor = "1",

                            }
                        }
                    }



                }
            };

            //Resultado esperado
            // => (8 + 5) * (7 - 4) = 39 notacion infija
            // => * (+ 8 5) (- 7 4) = 39 notacion prefija
            // => (8 5 +) (7 4 -) * = 39 notacion prefija

            // => ( 8 + (5 * 7))- 4 = 39 

            ManejadorArbol manejadorArbol = new ManejadorArbol();

            /*Console.WriteLine(manejadorArbol.ImprimirArbolInfijo(raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPrefijo(raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPostfijo(raiz));*/

             Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Infijo));
             Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Prefijo));
             Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Postfijo));



             Console.WriteLine($"Numero de hojas: {manejadorArbol.NumeroHojas(raiz)}");
             Console.WriteLine($"Numero de nodos:{manejadorArbol.NumeroNodos(raiz)}");
             Console.WriteLine($"Numero de niveles:{manejadorArbol.NumeroNiveles(raiz, 0)}");

           
        }
    }
}
