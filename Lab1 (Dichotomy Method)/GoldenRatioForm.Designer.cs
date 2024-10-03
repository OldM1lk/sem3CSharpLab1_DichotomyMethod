namespace Lab1__Dichotomy_Method_
{
    partial class GoldenRatioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculateButton = new System.Windows.Forms.Button();
            this.graph = new OxyPlot.WindowsForms.PlotView();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.plotButton = new System.Windows.Forms.Button();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minMaxGroup = new System.Windows.Forms.GroupBox();
            this.minRadioButton = new System.Windows.Forms.RadioButton();
            this.maxRadioButton = new System.Windows.Forms.RadioButton();
            this.minMaxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(13, 222);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(425, 34);
            this.calculateButton.TabIndex = 25;
            this.calculateButton.Text = "Расчитать методом золотого сечения";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // graph
            // 
            this.graph.Location = new System.Drawing.Point(444, 13);
            this.graph.Name = "graph";
            this.graph.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.graph.Size = new System.Drawing.Size(558, 335);
            this.graph.TabIndex = 24;
            this.graph.Text = "plotView1";
            this.graph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.graph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.graph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // textBoxE
            // 
            this.textBoxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxE.Location = new System.Drawing.Point(334, 186);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(104, 29);
            this.textBoxE.TabIndex = 23;
            this.textBoxE.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "e (кол-во знаков после запятой) =";
            // 
            // plotButton
            // 
            this.plotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plotButton.Location = new System.Drawing.Point(322, 43);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(116, 30);
            this.plotButton.TabIndex = 21;
            this.plotButton.Text = "Построить";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.Location = new System.Drawing.Point(186, 151);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(252, 29);
            this.textBoxB.TabIndex = 20;
            this.textBoxB.Text = "100";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.Location = new System.Drawing.Point(174, 116);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(264, 29);
            this.textBoxA.TabIndex = 19;
            this.textBoxA.Text = "-100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "b (правый край) =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "a (левый край) =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Введите интервал:";
            // 
            // functionTextBox
            // 
            this.functionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.functionTextBox.Location = new System.Drawing.Point(69, 43);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(245, 29);
            this.functionTextBox.TabIndex = 15;
            this.functionTextBox.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "f(x) =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите функцию:";
            // 
            // minMaxGroup
            // 
            this.minMaxGroup.Controls.Add(this.maxRadioButton);
            this.minMaxGroup.Controls.Add(this.minRadioButton);
            this.minMaxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minMaxGroup.Location = new System.Drawing.Point(17, 262);
            this.minMaxGroup.Name = "minMaxGroup";
            this.minMaxGroup.Size = new System.Drawing.Size(200, 86);
            this.minMaxGroup.TabIndex = 27;
            this.minMaxGroup.TabStop = false;
            this.minMaxGroup.Text = "Min / Max";
            // 
            // minRadioButton
            // 
            this.minRadioButton.AutoSize = true;
            this.minRadioButton.Checked = true;
            this.minRadioButton.Location = new System.Drawing.Point(6, 28);
            this.minRadioButton.Name = "minRadioButton";
            this.minRadioButton.Size = new System.Drawing.Size(59, 28);
            this.minRadioButton.TabIndex = 0;
            this.minRadioButton.TabStop = true;
            this.minRadioButton.Text = "Min";
            this.minRadioButton.UseVisualStyleBackColor = true;
            this.minRadioButton.CheckedChanged += new System.EventHandler(this.minRadioButton_CheckedChanged);
            // 
            // maxRadioButton
            // 
            this.maxRadioButton.AutoSize = true;
            this.maxRadioButton.Location = new System.Drawing.Point(6, 57);
            this.maxRadioButton.Name = "maxRadioButton";
            this.maxRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maxRadioButton.Size = new System.Drawing.Size(64, 28);
            this.maxRadioButton.TabIndex = 1;
            this.maxRadioButton.Text = "Max";
            this.maxRadioButton.UseVisualStyleBackColor = true;
            this.maxRadioButton.CheckedChanged += new System.EventHandler(this.maxRadioButton_CheckedChanged);
            // 
            // GoldenRatioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 359);
            this.Controls.Add(this.minMaxGroup);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.functionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1029, 398);
            this.Name = "GoldenRatioForm";
            this.Text = "Метод Золотого сечения";
            this.Load += new System.EventHandler(this.GoldenRatioForm_Load);
            this.Resize += new System.EventHandler(this.GoldenRatioForm_Resize);
            this.minMaxGroup.ResumeLayout(false);
            this.minMaxGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private OxyPlot.WindowsForms.PlotView graph;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox functionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox minMaxGroup;
        private System.Windows.Forms.RadioButton maxRadioButton;
        private System.Windows.Forms.RadioButton minRadioButton;
    }
}