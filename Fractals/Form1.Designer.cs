namespace Fractals
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settings = new System.Windows.Forms.Panel();
            this.cantorGapGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackCantorGap = new System.Windows.Forms.TrackBar();
            this.cantorGapLabel = new System.Windows.Forms.Label();
            this.endColor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.recursionTrackBar = new System.Windows.Forms.TrackBar();
            this.recursionLabel = new System.Windows.Forms.Label();
            this.methodLabel = new System.Windows.Forms.Label();
            this.method = new System.Windows.Forms.ComboBox();
            this.goButton = new System.Windows.Forms.Button();
            this.treeGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rightAngleLabel = new System.Windows.Forms.Label();
            this.leftAngleLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackRightAngle = new System.Windows.Forms.TrackBar();
            this.trackLeftAngle = new System.Windows.Forms.TrackBar();
            this.label = new System.Windows.Forms.Label();
            this.trackRatio = new System.Windows.Forms.TrackBar();
            this.ratio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exceptionTypeBox = new System.Windows.Forms.TextBox();
            this.fractalPanel = new System.Windows.Forms.Panel();
            this.exceptionGroup = new System.Windows.Forms.GroupBox();
            this.fractalCanvas = new System.Windows.Forms.PictureBox();
            this.settings.SuspendLayout();
            this.cantorGapGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackCantorGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursionTrackBar)).BeginInit();
            this.treeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRightAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLeftAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRatio)).BeginInit();
            this.fractalPanel.SuspendLayout();
            this.exceptionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fractalCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settings.Controls.Add(this.cantorGapGroup);
            this.settings.Controls.Add(this.endColor);
            this.settings.Controls.Add(this.label7);
            this.settings.Controls.Add(this.label6);
            this.settings.Controls.Add(this.startColor);
            this.settings.Controls.Add(this.label3);
            this.settings.Controls.Add(this.recursionTrackBar);
            this.settings.Controls.Add(this.recursionLabel);
            this.settings.Controls.Add(this.methodLabel);
            this.settings.Controls.Add(this.method);
            this.settings.Controls.Add(this.goButton);
            this.settings.Location = new System.Drawing.Point(9, 9);
            this.settings.Margin = new System.Windows.Forms.Padding(0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(300, 558);
            this.settings.TabIndex = 3;
            // 
            // cantorGapGroup
            // 
            this.cantorGapGroup.Controls.Add(this.label4);
            this.cantorGapGroup.Controls.Add(this.trackCantorGap);
            this.cantorGapGroup.Controls.Add(this.cantorGapLabel);
            this.cantorGapGroup.Location = new System.Drawing.Point(0, 311);
            this.cantorGapGroup.Name = "cantorGapGroup";
            this.cantorGapGroup.Size = new System.Drawing.Size(300, 150);
            this.cantorGapGroup.TabIndex = 4;
            this.cantorGapGroup.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Расстояние между линиями";
            // 
            // trackCantorGap
            // 
            this.trackCantorGap.Location = new System.Drawing.Point(21, 55);
            this.trackCantorGap.Maximum = 100;
            this.trackCantorGap.Minimum = 20;
            this.trackCantorGap.Name = "trackCantorGap";
            this.trackCantorGap.Size = new System.Drawing.Size(156, 69);
            this.trackCantorGap.SmallChange = 10;
            this.trackCantorGap.TabIndex = 1;
            this.trackCantorGap.Value = 40;
            this.trackCantorGap.Scroll += new System.EventHandler(this.TrackGapScroll);
            // 
            // cantorGapLabel
            // 
            this.cantorGapLabel.AutoSize = true;
            this.cantorGapLabel.Location = new System.Drawing.Point(232, 55);
            this.cantorGapLabel.Name = "cantorGapLabel";
            this.cantorGapLabel.Size = new System.Drawing.Size(56, 25);
            this.cantorGapLabel.TabIndex = 2;
            this.cantorGapLabel.Text = "20 px";
            this.cantorGapLabel.UseWaitCursor = true;
            // 
            // endColor
            // 
            this.endColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endColor.FormattingEnabled = true;
            this.endColor.Location = new System.Drawing.Point(18, 272);
            this.endColor.Name = "endColor";
            this.endColor.Size = new System.Drawing.Size(262, 33);
            this.endColor.TabIndex = 4;
            this.endColor.SelectedIndexChanged += new System.EventHandler(this.EndColorIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Начальный цвет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Начальный цвет";
            // 
            // startColor
            // 
            this.startColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startColor.FormattingEnabled = true;
            this.startColor.Location = new System.Drawing.Point(18, 208);
            this.startColor.Name = "startColor";
            this.startColor.Size = new System.Drawing.Size(262, 33);
            this.startColor.TabIndex = 4;
            this.startColor.SelectedIndexChanged += new System.EventHandler(this.StartColorIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Глубина рекурсии";
            // 
            // recursionTrackBar
            // 
            this.recursionTrackBar.Location = new System.Drawing.Point(14, 136);
            this.recursionTrackBar.Maximum = 15;
            this.recursionTrackBar.Minimum = 1;
            this.recursionTrackBar.Name = "recursionTrackBar";
            this.recursionTrackBar.Size = new System.Drawing.Size(156, 69);
            this.recursionTrackBar.TabIndex = 1;
            this.recursionTrackBar.Value = 10;
            this.recursionTrackBar.Scroll += new System.EventHandler(this.TrackRecursionScroll);
            this.recursionTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackRecursionMouseUp);
            // 
            // recursionLabel
            // 
            this.recursionLabel.AutoSize = true;
            this.recursionLabel.Location = new System.Drawing.Point(228, 136);
            this.recursionLabel.Name = "recursionLabel";
            this.recursionLabel.Size = new System.Drawing.Size(32, 25);
            this.recursionLabel.TabIndex = 2;
            this.recursionLabel.Text = "10";
            this.recursionLabel.UseWaitCursor = true;
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(21, 44);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(69, 25);
            this.methodLabel.TabIndex = 5;
            this.methodLabel.Text = "Метод:";
            // 
            // method
            // 
            this.method.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.method.FormattingEnabled = true;
            this.method.Location = new System.Drawing.Point(18, 72);
            this.method.Name = "method";
            this.method.Size = new System.Drawing.Size(262, 33);
            this.method.TabIndex = 4;
            this.method.SelectedIndexChanged += new System.EventHandler(this.MethodSelectedIndexChanged);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(91, 10);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(112, 34);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.GoButtonClick);
            // 
            // treeGroup
            // 
            this.treeGroup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.treeGroup.Controls.Add(this.label1);
            this.treeGroup.Controls.Add(this.rightAngleLabel);
            this.treeGroup.Controls.Add(this.leftAngleLabel);
            this.treeGroup.Controls.Add(this.label5);
            this.treeGroup.Controls.Add(this.trackRightAngle);
            this.treeGroup.Controls.Add(this.trackLeftAngle);
            this.treeGroup.Controls.Add(this.label);
            this.treeGroup.Controls.Add(this.trackRatio);
            this.treeGroup.Controls.Add(this.ratio);
            this.treeGroup.Location = new System.Drawing.Point(9, 320);
            this.treeGroup.Name = "treeGroup";
            this.treeGroup.Size = new System.Drawing.Size(300, 395);
            this.treeGroup.TabIndex = 6;
            this.treeGroup.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Отношение  длин отрезков";
            // 
            // rightAngleLabel
            // 
            this.rightAngleLabel.AutoSize = true;
            this.rightAngleLabel.Location = new System.Drawing.Point(232, 130);
            this.rightAngleLabel.Name = "rightAngleLabel";
            this.rightAngleLabel.Size = new System.Drawing.Size(36, 25);
            this.rightAngleLabel.TabIndex = 2;
            this.rightAngleLabel.Text = "2.0";
            this.rightAngleLabel.UseWaitCursor = true;
            // 
            // leftAngleLabel
            // 
            this.leftAngleLabel.AutoSize = true;
            this.leftAngleLabel.Location = new System.Drawing.Point(244, 205);
            this.leftAngleLabel.Name = "leftAngleLabel";
            this.leftAngleLabel.Size = new System.Drawing.Size(36, 25);
            this.leftAngleLabel.TabIndex = 2;
            this.leftAngleLabel.Text = "2.0";
            this.leftAngleLabel.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Угол наклона лев.";
            // 
            // trackRightAngle
            // 
            this.trackRightAngle.Location = new System.Drawing.Point(18, 130);
            this.trackRightAngle.Minimum = 2;
            this.trackRightAngle.Name = "trackRightAngle";
            this.trackRightAngle.Size = new System.Drawing.Size(156, 69);
            this.trackRightAngle.TabIndex = 1;
            this.trackRightAngle.Value = 8;
            this.trackRightAngle.Scroll += new System.EventHandler(this.TrackRightAngleScroll);
            // 
            // trackLeftAngle
            // 
            this.trackLeftAngle.Location = new System.Drawing.Point(18, 205);
            this.trackLeftAngle.Minimum = 2;
            this.trackLeftAngle.Name = "trackLeftAngle";
            this.trackLeftAngle.RightToLeftLayout = true;
            this.trackLeftAngle.Size = new System.Drawing.Size(156, 69);
            this.trackLeftAngle.TabIndex = 1;
            this.trackLeftAngle.Value = 8;
            this.trackLeftAngle.Scroll += new System.EventHandler(this.TrackLeftAngleScroll);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(18, 99);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(170, 25);
            this.label.TabIndex = 3;
            this.label.Text = "Угол наклона прав.";
            // 
            // trackRatio
            // 
            this.trackRatio.Location = new System.Drawing.Point(18, 55);
            this.trackRatio.Maximum = 30;
            this.trackRatio.Minimum = 14;
            this.trackRatio.Name = "trackRatio";
            this.trackRatio.Size = new System.Drawing.Size(156, 69);
            this.trackRatio.TabIndex = 1;
            this.trackRatio.Value = 15;
            this.trackRatio.Scroll += new System.EventHandler(this.TrackRatioScroll);
            // 
            // ratio
            // 
            this.ratio.AutoSize = true;
            this.ratio.Location = new System.Drawing.Point(232, 55);
            this.ratio.Name = "ratio";
            this.ratio.Size = new System.Drawing.Size(36, 25);
            this.ratio.TabIndex = 2;
            this.ratio.Text = "1.5";
            this.ratio.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Exception type:";
            // 
            // exceptionTypeBox
            // 
            this.exceptionTypeBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.exceptionTypeBox.Location = new System.Drawing.Point(18, 38);
            this.exceptionTypeBox.Name = "exceptionTypeBox";
            this.exceptionTypeBox.Size = new System.Drawing.Size(262, 31);
            this.exceptionTypeBox.TabIndex = 4;
            // 
            // fractalPanel
            // 
            this.fractalPanel.Controls.Add(this.exceptionGroup);
            this.fractalPanel.Controls.Add(this.fractalCanvas);
            this.fractalPanel.Location = new System.Drawing.Point(318, 9);
            this.fractalPanel.Margin = new System.Windows.Forms.Padding(0);
            this.fractalPanel.Name = "fractalPanel";
            this.fractalPanel.Size = new System.Drawing.Size(711, 558);
            this.fractalPanel.TabIndex = 4;
            // 
            // exceptionGroup
            // 
            this.exceptionGroup.BackColor = System.Drawing.Color.AntiqueWhite;
            this.exceptionGroup.Controls.Add(this.exceptionTypeBox);
            this.exceptionGroup.Controls.Add(this.label2);
            this.exceptionGroup.Location = new System.Drawing.Point(0, 0);
            this.exceptionGroup.Name = "exceptionGroup";
            this.exceptionGroup.Size = new System.Drawing.Size(300, 75);
            this.exceptionGroup.TabIndex = 1;
            this.exceptionGroup.TabStop = false;
            this.exceptionGroup.Visible = false;
            // 
            // fractalCanvas
            // 
            this.fractalCanvas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.fractalCanvas.Location = new System.Drawing.Point(105, 0);
            this.fractalCanvas.Name = "fractalCanvas";
            this.fractalCanvas.Size = new System.Drawing.Size(600, 600);
            this.fractalCanvas.TabIndex = 0;
            this.fractalCanvas.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 644);
            this.Controls.Add(this.fractalPanel);
            this.Controls.Add(this.treeGroup);
            this.Controls.Add(this.settings);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.Text = "Heading";
            this.ResizeEnd += new System.EventHandler(this.FormResizeEnd);
            this.SizeChanged += new System.EventHandler(this.FormSizeChanged);
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.cantorGapGroup.ResumeLayout(false);
            this.cantorGapGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackCantorGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursionTrackBar)).EndInit();
            this.treeGroup.ResumeLayout(false);
            this.treeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRightAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLeftAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRatio)).EndInit();
            this.fractalPanel.ResumeLayout(false);
            this.exceptionGroup.ResumeLayout(false);
            this.exceptionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fractalCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel settings;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Panel fractalPanel;
        private System.Windows.Forms.PictureBox fractalCanvas;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label rightAngleLabel;
        private System.Windows.Forms.TrackBar trackRightAngle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label leftAngleLabel;
        private System.Windows.Forms.TrackBar trackLeftAngle;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.ComboBox method;
        private System.Windows.Forms.GroupBox treeGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackRatio;
        private System.Windows.Forms.Label ratio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar recursionTrackBar;
        private System.Windows.Forms.Label recursionLabel;
        private System.Windows.Forms.GroupBox cantorGapGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackCantorGap;
        private System.Windows.Forms.Label cantorGapLabel;
        private System.Windows.Forms.TextBox exceptionTypeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox exceptionGroup;
        private System.Windows.Forms.ComboBox endColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox startColor;
    }
}

