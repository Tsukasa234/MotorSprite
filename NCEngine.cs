using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorSprite
{
    class NCEngine
    {
        //Bitmap donde se dibuja todo
        private Bitmap lienzo;

        private int ancho, alto;

        //Lista donde se guardan los sprites
        private List<NCSprite> lstSprite = new List<NCSprite>();

        //Constructor
        public NCEngine(int pAncho, int pAlto)
        {
            //Asignamos valores
            ancho = pAncho;
            alto = pAlto;

            //Creamos el canvas
            lienzo = new Bitmap(ancho, alto);

            InitPruebas();
        }

        //Propiedades
        public Bitmap Canvas => lienzo;

        //Metodo temporal para pruebas y experimentacion
        private void InitPruebas()
        {
            for (int x = 0; x < lienzo.Width; x++)
            {
                for (int y = 0; y < lienzo.Height; y++)
                {
                    lienzo.SetPixel(x, y, Color.DarkGreen);
                }
            }
        }

        public void AddicionarSprite(NCSprite pSprite)
        {
            if (pSprite != null)
            {
                pSprite.ColocaCanvas(lienzo);
                lstSprite.Add(pSprite);
            }
        }

        
        public void CicloJuego()
        {
            foreach (NCSprite sprite in lstSprite)
            {
                sprite.DibujarSprite();
            }
        }
    }
}
