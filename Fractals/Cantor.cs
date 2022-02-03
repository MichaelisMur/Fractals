using System;
using System.Drawing;

namespace Fractals
{
    class Cantor : Fractal
    {
        // Расстояние между прямыми.
        double gap = 40;

        public double setGapValue
        {
            set
            {
                gap = value;
            }
        }

        // Отрисовка фрактала.
        public override void DrawFractal()
        {
            graphics.DrawLine(new Pen(Color.FromArgb(Fractal.startColor.R, Fractal.startColor.G, Fractal.startColor.B), 20),
                0, 10, (float)fractalCanvas.Width, 10);

            DrawCarpet(0, (float)fractalCanvas.Width, 10 + gap, 2);
        }

        // Рекурсивная формула.
        public void DrawCarpet(double ax, double bx, double y, int depth)
        {
            if (depth > recursionDepth) return;
            int R, G, B;
            // Значния RGB от глубины рекурсии.
            Gradient(depth, recursionDepth, out R, out G, out B);

            graphics.DrawLine(new Pen(Color.FromArgb(R, G, B), 20), (float)ax, (float)(y), (float)(ax + (bx - ax) / 3), (float)(y));
            graphics.DrawLine(new Pen(Color.FromArgb(R, G, B), 20), (float)(ax + (bx - ax) / 3 * 2), (float)(y), (float)(bx), (float)(y));


            DrawCarpet(ax, ax + (bx - ax) / 3, y + gap, depth + 1);
            DrawCarpet(ax + (bx - ax) / 3 * 2, bx, y + gap, depth + 1);
        }
    }
}
