using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Fractals
{
    abstract class Fractal
    {
        protected int recursionDepth;
        protected Graphics graphics;
        protected PictureBox fractalCanvas;
        // Начальный и конечный цвета.
        static protected Color startColor = Color.Red;
        static protected Color endColor = Color.Yellow;

        public int setRecursionDepth
        {
            set
            {
                recursionDepth = value;
            }
        }
        public Graphics setGraphicsCanvas
        {
            set
            {
                graphics = value;
            }
        }
        public PictureBox setFractalCanvas
        {
            set
            {
                fractalCanvas = value;
            }
        }
        public static Color setStartColor
        {
            set
            {
                startColor = value;
            }
        }
        public static Color setEndColor
        {
            set
            {
                endColor = value;
            }
        }

        /// <summary>
        /// Высчитывание значений RGB в зависимости от глубины рекурсии.
        /// </summary>
        public void Gradient(int depth, int recursionDepth, out int R, out int G, out int B)
        {
            if (recursionDepth == 1)
            {
                R = Fractal.endColor.R;
                G = Fractal.endColor.G;
                B = Fractal.endColor.B;
            }
            else
            {
                R = Fractal.startColor.R + (depth - 1) * (Fractal.endColor.R - Fractal.startColor.R) / (recursionDepth - 1);
                G = Fractal.startColor.G + (depth - 1) * (Fractal.endColor.G - Fractal.startColor.G) / (recursionDepth - 1);
                B = Fractal.startColor.B + (depth - 1) * (Fractal.endColor.B - Fractal.startColor.B) / (recursionDepth - 1);
            }
        }

        public abstract void DrawFractal();
    }
}
