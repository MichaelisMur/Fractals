using System;
using System.Drawing;

namespace Fractals
{
    class Triangle : Fractal
    {
        Pen pen = new Pen(Fractal.startColor, 2);
        // Отрисовка фрактала.
        public override void DrawFractal()
        {
            float yConst = (float)(fractalCanvas.Height * (2 - Math.Sqrt(3)) / 4);
            double ax = 0, ay = fractalCanvas.Height * Math.Sqrt(3) / 2 + yConst,
                bx = fractalCanvas.Width, by = fractalCanvas.Height * Math.Sqrt(3) / 2 + yConst,
                cx = fractalCanvas.Width / 2, cy = yConst;

            graphics.DrawLine(pen, (float)ax, (float)ay, (float)bx, (float)by);
            graphics.DrawLine(pen, (float)ax, (float)ay, (float)cx, (float)cy);
            graphics.DrawLine(pen, (float)bx, (float)by, (float)cx, (float)cy);

            DrawCarpet(ax, ay, bx, by, cx, cy, 1);
        }

        // Рекурсивная формула.
        public void DrawCarpet(double ax, double ay, double bx, double by, double cx, double cy, int depth)
        {
            if (depth > recursionDepth) return;
            int R, G, B;
            // Значния RGB от глубины рекурсии.
            Gradient(depth, recursionDepth, out R, out G, out B);

            graphics.DrawLine(new Pen(Color.FromArgb(R, G, B), 2), (float)(ax + cx) / 2, (float)(ay + cy) / 2, (float)(bx + cx) / 2, (float)(by + cy) / 2);
            graphics.DrawLine(new Pen(Color.FromArgb(R, G, B), 2), (float)(ax + cx) / 2, (float)(ay + cy) / 2, (float)(bx + ax) / 2, (float)(by + ay) / 2);
            graphics.DrawLine(new Pen(Color.FromArgb(R, G, B), 2), (float)(bx + ax) / 2, (float)(by + ay) / 2, (float)(bx + cx) / 2, (float)(by + cy) / 2);

            DrawCarpet(ax, ay, (float)(bx + ax) / 2, (float)(by + ay) / 2, (float)(ax + cx) / 2, (float)(ay + cy) / 2, depth + 1);
            DrawCarpet((float)(ax + bx) / 2, (float)(ay + by) / 2,  bx, by, (float)(bx + cx) / 2, (float)(by + cy) / 2, depth + 1);
            DrawCarpet((float)(ax + cx) / 2, (float)(ay + cy) / 2, (float)(bx + cx) / 2, (float)(by + cy) / 2, cx, cy, depth + 1);
        }
    }
}
