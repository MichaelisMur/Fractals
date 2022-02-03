using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Form1 : Form
    {
        internal Tree tree;
        Koch koch;
        Carpet carpet;
        Triangle triangle;
        Cantor cantor;


        public Form1()
        {
            try
            {
                // Объекты классов 5 представлений фракталов.
                tree = new Tree();
                koch = new Koch();
                carpet = new Carpet();
                triangle = new Triangle();
                cantor = new Cantor();

                // Начальный и конечный цвета фрактала.
                Fractal.setStartColor = Color.Red;
                Fractal.setEndColor = Color.Yellow;

                InitializeComponent();
                SetPanelsSize();

                // Устанавливаю свою дефолтную глубину рекурсии для каждого из 5 объектов.
                tree.setRecursionDepth = 10;
                tree.setGraphicsCanvas = fractalCanvas.CreateGraphics();
                tree.setFractalCanvas = fractalCanvas;

                koch.setRecursionDepth = 5;
                koch.setGraphicsCanvas = fractalCanvas.CreateGraphics();
                koch.setFractalCanvas = fractalCanvas;

                carpet.setRecursionDepth = 4;
                carpet.setGraphicsCanvas = fractalCanvas.CreateGraphics();
                carpet.setFractalCanvas = fractalCanvas;

                triangle.setRecursionDepth = 10;
                triangle.setGraphicsCanvas = fractalCanvas.CreateGraphics();
                triangle.setFractalCanvas = fractalCanvas;

                cantor.setRecursionDepth = 5;
                cantor.setGraphicsCanvas = fractalCanvas.CreateGraphics();
                cantor.setFractalCanvas = fractalCanvas;
            }
            catch(Exception e)
            {
                exceptionGroup.Visible = true;
                exceptionTypeBox.Text = e.GetType().Name;
            }
        }


        /// <summary>
        /// Устанавка цвета, размеров и свойств блоков формы при запуске. 
        /// </summary>
        public void SetPanelsSize()
        {
            cantorGapGroup.Visible = false;
            settings.BackColor = Color.AntiqueWhite;
            fractalPanel.BackColor = Color.AntiqueWhite;
            treeGroup.BackColor = Color.AntiqueWhite;
            fractalCanvas.BackColor = Color.AntiqueWhite;
            cantorGapGroup.BackColor = Color.AntiqueWhite;

            settings.Height = ClientRectangle.Height - 15;
            fractalPanel.Height = ClientRectangle.Height - 15;
            fractalPanel.Width = ClientRectangle.Width - settings.Width - 30;
            fractalCanvas.Top = (fractalPanel.Height - fractalCanvas.Height) / 2;
            fractalCanvas.Left = (fractalPanel.Width - fractalCanvas.Width) / 2;
            rightAngleLabel.Text = $"π/{Math.Abs(trackRightAngle.Value - 12)}";
            leftAngleLabel.Text = $"π/{Math.Abs(trackLeftAngle.Value - 12)}";
            method.Items.AddRange(new string[] {
                "Фрактальное дерево", "Кривая Коха", "Ковер Серпинского", "Треугольник Серпинского", "Множество Кантора"}
            );
            // Цвета для отрисовки.
            method.SelectedIndex = 0;
            startColor.Items.AddRange(new string[] {
                "red", "lightgreen", "blue", "yellow", "pink", "orange"}
            );
            startColor.SelectedIndex = 0;
            endColor.Items.AddRange(new string[] {
                "red", "lightgreen", "blue", "yellow", "pink", "orange"}
            );
            endColor.SelectedIndex = 4;
        }

        /// <summary>
        /// Событие нажатия клавиши с запуском отрисовки.
        /// </summary>
        async private void GoButtonClick(object sender, EventArgs e)
        {
            await Task.Run(() => fractalCanvas.Refresh());

            switch (method.Text)
            {
                case "Фрактальное дерево":
                    tree.DrawFractal();
                    break;
                case "Кривая Коха":
                    koch.DrawFractal();
                    break;
                case "Ковер Серпинского":
                    carpet.DrawFractal();
                    break;
                case "Треугольник Серпинского":
                    triangle.DrawFractal();
                    break;
                case "Множество Кантора":
                    cantor.DrawFractal();
                    break;
            }
        }


        /// <summary>
        /// Событие ресайза формы.
        /// </summary>
        async private void FormResizeEnd(object sender, EventArgs e)
        {
            await Task.Run(() => fractalCanvas.Refresh());
            switch (method.Text)
            {
                case "Фрактальное дерево":
                    tree.DrawFractal();
                    break;
                case "Кривая Коха":
                    koch.DrawFractal();
                    break;
                case "Ковер Серпинского":
                    carpet.DrawFractal();
                    break;
                case "Треугольник Серпинского":
                    triangle.DrawFractal();
                    break;
                case "Множество Кантора":
                    cantor.DrawFractal();
                    break;
            }
        }


        /// <summary>
        /// Событие начала ресайза формы.
        /// </summary>
        async private void FormSizeChanged(object sender, EventArgs e)
        {
            await Task.Run(() => fractalCanvas.Refresh());
            settings.Height = ClientRectangle.Height - 15;
            fractalPanel.Height = ClientRectangle.Height - 15;
            fractalPanel.Width = ClientRectangle.Width - settings.Width - 30;
            fractalCanvas.Top = (fractalPanel.Height - fractalCanvas.Height) / 2;
            fractalCanvas.Left = (fractalPanel.Width - fractalCanvas.Width) / 2;
        }

        /// <summary>
        /// Событие изменения отношения длин отрезков в фрактальном дереве.
        /// </summary>
        private void TrackRatioScroll(object sender, EventArgs e)
        {
            ratio.Text = ((double)trackRatio.Value / 10).ToString();
            tree.setRatioValue = (double)trackRatio.Value / 10;
        }

        /// <summary>
        /// Событие изменения правого угла в фрактальном дереве.
        /// </summary>
        private void TrackRightAngleScroll(object sender, EventArgs e)
        {
            rightAngleLabel.Text = $"π/{Math.Abs(trackRightAngle.Value-12)}";
            tree.setRightAngleValue = Math.PI / Math.Abs(trackRightAngle.Value - 12);
        }

        /// <summary>
        /// Событие изменения левого угла в фрактальном дереве.
        /// </summary>
        private void TrackLeftAngleScroll(object sender, EventArgs e)
        {
            leftAngleLabel.Text = $"π/{Math.Abs(trackLeftAngle.Value-12)}";
            tree.setLeftAngleValue = Math.PI / Math.Abs(trackLeftAngle.Value - 12);
        }

        /// <summary>
        /// Событие изменения выбранного фрактала в дроплисте.
        /// </summary>
        async private void MethodSelectedIndexChanged(object sender, EventArgs e)
        {
            if (method.Text == "Фрактальное дерево")
            {
                treeGroup.Visible = true;
                cantorGapGroup.Visible = false;
                recursionTrackBar.Maximum = 14;
                recursionTrackBar.Value = 10;
            }
            else if (method.Text == "Кривая Коха")
            {
                treeGroup.Visible = false;
                cantorGapGroup.Visible = false;
                recursionTrackBar.Maximum = 5;
                recursionTrackBar.Value = 4;
            }
            else if (method.Text == "Ковер Серпинского")
            {
                treeGroup.Visible = false;
                cantorGapGroup.Visible = false;
                recursionTrackBar.Maximum = 6;
                recursionTrackBar.Value = 4;
            }
            else if (method.Text == "Треугольник Серпинского")
            {
                treeGroup.Visible = false;
                cantorGapGroup.Visible = false;
                recursionTrackBar.Maximum = 8;
                recursionTrackBar.Value = 5;
            }
            else if (method.Text == "Множество Кантора")
            {
                treeGroup.Visible = false;
                cantorGapGroup.Visible = true;
                recursionTrackBar.Maximum = 6;
                recursionTrackBar.Value = 4;
            }
            await Task.Run(() => fractalCanvas.Refresh());
            RecursionDepthChanged();
        }

        /// <summary>
        /// Событие окончания изменения значения глубины рекурсии.
        /// </summary>
        async private void TrackRecursionMouseUp(object sender, MouseEventArgs e)
        {
            RecursionDepthChanged();
            await Task.Run(() => fractalCanvas.Refresh());

            switch (method.Text)
            {
                case "Фрактальное дерево":
                    tree.DrawFractal();
                    break;
                case "Кривая Коха":
                    koch.DrawFractal();
                    break;
                case "Ковер Серпинского":
                    carpet.DrawFractal();
                    break;
                case "Треугольник Серпинского":
                    triangle.DrawFractal();
                    break;
                case "Множество Кантора":
                    cantor.DrawFractal();
                    break;
            }
        }

        /// <summary>
        /// Событие начала изменения значения глубины рекурсии.
        /// </summary>
        private void TrackRecursionScroll(object sender, EventArgs e)
        {
            recursionLabel.Text = recursionTrackBar.Value.ToString();
        }

        /// <summary>
        /// Установка нового значния глубины рекурсии.
        /// </summary>
        private void RecursionDepthChanged()
        {
            recursionLabel.Text = recursionTrackBar.Value.ToString();
            tree.setRecursionDepth = recursionTrackBar.Value;
            koch.setRecursionDepth = recursionTrackBar.Value;
            carpet.setRecursionDepth = recursionTrackBar.Value;
            triangle.setRecursionDepth = recursionTrackBar.Value;
            cantor.setRecursionDepth = recursionTrackBar.Value;
        }

        /// <summary>
        /// Событие изменения значения расстояния между прямыми в множестве Кантора.
        /// </summary>
        private void TrackGapScroll(object sender, EventArgs e)
        {
            cantorGapLabel.Text = $"{(trackCantorGap.Value - 20)} px";
            cantor.setGapValue = trackCantorGap.Value;
        }

        /// <summary>
        /// Событие изменения начального цвета.
        /// </summary>
        private void StartColorIndexChanged(object sender, EventArgs e)
        {
            switch (startColor.Text)
            {
                case "red":
                    Fractal.setStartColor = Color.Red;
                    break;
                case "lightgreen":
                    Fractal.setStartColor = Color.LightGreen;
                    break;
                case "blue":
                    Fractal.setStartColor = Color.Blue;
                    break;
                case "pink":
                    Fractal.setStartColor = Color.Pink;
                    break;
                case "orange":
                    Fractal.setStartColor = Color.Orange;
                    break;
                case "yellow":
                    Fractal.setStartColor = Color.Yellow;
                    break;
            }
        }

        /// <summary>
        /// Событие изменения конечного цвета.
        /// </summary>
        private void EndColorIndexChanged(object sender, EventArgs e)
        {
            switch (endColor.Text)
            {
                case "red":
                    Fractal.setEndColor = Color.Red;
                    break;
                case "lightgreen":
                    Fractal.setEndColor = Color.LightGreen;
                    break;
                case "blue":
                    Fractal.setEndColor = Color.Blue;
                    break;
                case "pink":
                    Fractal.setEndColor = Color.Pink;
                    break;
                case "orange":
                    Fractal.setEndColor = Color.Orange;
                    break;
                case "yellow":
                    Fractal.setEndColor = Color.Yellow;
                    break;
            }
        }
    }
}
