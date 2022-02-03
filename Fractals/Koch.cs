using System;
using System.Drawing;

namespace Fractals
{
    class Koch : Fractal
    {
        // Отрисовка фрактала.
        public override void DrawFractal()
        {
            graphics.DrawLine(new Pen(Fractal.startColor, 2), 0, (fractalCanvas.Height - 30),
                (float)fractalCanvas.Width, (fractalCanvas.Height - 30));
            DrawKoch(0, fractalCanvas.Height - 30, fractalCanvas.Width, fractalCanvas.Height - 30, 0, 1);
        }

        // Рекурсивная формула.
        public void DrawKoch(double xStart, double yStart, double xEnd, double yEnd, double angle, int depth)
        {
            if (depth > recursionDepth) return;
            double length, Px, Py, Qx, Qy, Rx, Ry;
            int R, G, B;
            // Значния RGB от глубины рекурсии.
            Gradient(depth, recursionDepth, out R, out G, out B);

            length = Math.Sqrt(Math.Pow(xEnd - xStart, 2) + Math.Pow(yEnd - yStart, 2)) / 3;
            // Координаты точек для отрисовки.
            Px = xStart + length * Math.Cos(angle);
            Py = yStart + length * Math.Sin(angle + Math.PI);
            Qx = Px + length * Math.Cos(angle + Math.PI / 3);
            Qy = Py + length * Math.Sin(angle + Math.PI + Math.PI / 3);
            Rx = Qx + length * Math.Cos(angle - Math.PI / 3);
            Ry = Qy + length * Math.Sin(angle + Math.PI - Math.PI / 3);

            graphics.DrawLine(new Pen(Color.FromArgb(R, G, B), 2), (float)Px, (float)Py, (float)Qx, (float)Qy);
            graphics.DrawLine(new Pen(Color.FromArgb(R, G, B), 2), (float)Qx, (float)Qy, (float)Rx, (float)Ry);

            // Стираю середину линии.
            graphics.DrawLine(new Pen(Color.AntiqueWhite, 2), (float)Px, (float)Py, (float)Rx, (float)Ry);

            DrawKoch(xStart, yStart, Px, Py, angle, depth + 1);
            DrawKoch(Px, Py, Qx, Qy, angle + Math.PI / 3, depth + 1);
            DrawKoch(Qx, Qy, Rx, Ry, angle - Math.PI / 3, depth + 1);
            DrawKoch(Rx, Ry, xEnd, yEnd, angle, depth + 1);
        }
    }
}

