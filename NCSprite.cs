using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorSprite
{
    class NCSprite
    {
        //Atributos

        //Posicion del Sprite
        private int posX, posY;

        //Dimension del Sprite
        private int ancho, alto;

        //Imagen de los cuadros
        private Bitmap imagen;      //Imagen que contiene los cuadros de animacion

        private int cuadros,    //Cantidad de Cuadros en las animaciones o frames por animacion 
            cuadroActual,       //Animacion actual que se esta mostrando en el cuadro o frame
            animaciones,        //Cantidad de animaciones que tiene el sprite
            animacionActual;    //Animacion actual que se muestra

        private bool activo,    // Indica si el sprite hace el ciclo de animacion 
                    visible;    //Indica si el sprite se dibuja

        //Imagenes para dibujo
        private Bitmap canvas, //NCBitMap donde se va a dibujar
                recorte;       //NCBitMap del recorte de fondo

        //Constructor
        public NCSprite(int pX, int pY, int pAncho, int pAlto, string pImagen, 
            int pCuadros, int pAnimaciones, bool pActivo, bool pVisible)
        {
            //Asignamos los atributos
            posX = pX;
            posY = pY;
            ancho = pAncho;
            alto = pAlto;
            cuadros = pCuadros;
            animaciones = pAnimaciones;
            activo = pActivo;
            visible = pVisible;

            //Inicializamos los que no se pasan al constructor
            animacionActual = 0;
            cuadroActual = 0;
        }

        //Creamos las propiedades
        public int X { get { return posX; } set { posX = value; } }
        public int Y { get { return posY; } set { posY = value; } }

        public int Ancho => ancho;
        public int Alto => alto;

        public int CuadroActual { get { return cuadroActual; } set { cuadroActual = value; } }
        public int Animaciones => animaciones;

        public int AnimacionActual { get { return animacionActual; } set { animacionActual = value; } }

        public bool Activo { get { return activo; } set { activo = value; } }

        public bool Visible { get { return visible; } set { visible = value; } }

        //Metodos

        public void ColocaCanvas(Bitmap pCanvas)
        {
            canvas = pCanvas;
        }

        public void ColocaImagen(Bitmap pImagen)
        {
            imagen = pImagen;
        }

        public void DibujarSprite()
        {
            int x = 0;
            int y = 0;

            for (x = posX; x < posX + ancho; x++)
            {
                for (y = posY; y < posY + alto; y++)
                {
                    canvas.SetPixel(x, y, Color.Blue);
                }
            }
        }

        public string Version => "1.0.0.1";


    }
}
