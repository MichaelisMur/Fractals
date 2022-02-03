using System.Drawing;

namespace Fractals
{
    class Carpet : Fractal
    {
        // Отрисовка фрактала.
        public override void DrawFractal()
        {
            DrawCarpet(0, 0, fractalCanvas.Width, 1);
        }

        // Рекурсивная формула.
        public void DrawCarpet(double x1, double y1, double length, int depth)
        {
            if (depth > recursionDepth) return;
            int R, G, B;
            // Значния RGB от глубины рекурсии.
            Gradient(depth, recursionDepth, out R, out G, out B);
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(R, G, B)), (float)(x1 + length / 3),
                (float)(y1 + length / 3), (float)(length / 3), (float)(length / 3));

            // Восемь квадратов.
            DrawCarpet(x1, y1, length / 3, depth + 1);
            DrawCarpet(x1 + length / 3, y1, length / 3, depth + 1);
            DrawCarpet(x1 + 2 * length / 3, y1, length / 3, depth + 1);

            DrawCarpet(x1, y1 + length / 3, length / 3, depth + 1);
            DrawCarpet(x1 + 2 * length / 3, y1 + length / 3, length / 3, depth + 1);

            DrawCarpet(x1, y1 + 2 * length / 3, length / 3, depth + 1);
            DrawCarpet(x1 + length / 3, y1 + 2 * length / 3, length / 3, depth + 1);
            DrawCarpet(x1 + 2 * length / 3, y1 + 2 * length / 3, length / 3, depth + 1);
        }
    }
}
