using System;
using System.Drawing;

namespace Fractals
{
    class Tree : Fractal
    {
        // Отношение отрезков.
        double ratioValue = 1.5;
        // Значения углов от вертикальной оси.
        double leftAngleValue = Math.PI / 4;
        double rightAngleValue = Math.PI / 4;

        public double setRatioValue
        {
            set
            {
                ratioValue = value;
            }
        }
        public double setLeftAngleValue
        {
            set
            {
                leftAngleValue = value;
            }
        }
        public double setRightAngleValue
        {
            set
            {
                rightAngleValue = value;
            }
        }

        // Отрисовка фрактала.
        public override void DrawFractal()
        {
            DrawTree(fractalCanvas.Width / 2, fractalCanvas.Height, fractalCanvas.Width / 2,
                3 * fractalCanvas.Height / 4, 1, Math.PI / 2 + leftAngleValue, Math.PI / 2 - rightAngleValue,
                fractalCanvas.Height / 5);
        }

        // Рекурсивная формула.
        public void DrawTree(double xStart, double yStart, double xEnd, double yEnd, int depth,
            double leftAngle, double rightAngle, double length)
        {
            if (depth > recursionDepth) return;
            int R, G, B;
            // Значния RGB от глубины рекурсии.
            Gradient(depth, recursionDepth, out R, out G, out B);

            graphics.DrawLine(new Pen(Color.FromArgb(R,G,B), 2), (float)xStart, (float)yStart, (float)xEnd, (float)yEnd);

            // Правая часть.
            DrawTree(xEnd, yEnd, xEnd + length / ratioValue * Math.Cos(rightAngle),
                yEnd - length / ratioValue * Math.Sin(rightAngle), depth + 1, rightAngle + leftAngleValue,
                rightAngle - rightAngleValue, length / ratioValue);

            // Левая часть.
            DrawTree(xEnd, yEnd, xEnd + length / ratioValue * Math.Cos(leftAngle),
                yEnd - length / ratioValue * Math.Sin(leftAngle), depth + 1, leftAngle + leftAngleValue,
                leftAngle - rightAngleValue, length / ratioValue);
        }
    }
}
