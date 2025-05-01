namespace MathQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timeLabel = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            label2 = new Label();
            plusRightLabel = new Label();
            equalsSign = new Label();
            sum = new NumericUpDown();
            minusLeftLabel = new Label();
            minusSign = new Label();
            minusRightLabel = new Label();
            minusEqualsSign = new Label();
            difference = new NumericUpDown();
            timesLeftLabel = new Label();
            timesRightLabel = new Label();
            multEqualsSign = new Label();
            product = new NumericUpDown();
            dividedLeftLabel = new Label();
            dividedRightLabel = new Label();
            divideEqualsSign = new Label();
            quotient = new NumericUpDown();
            multiplicationSign = new Label();
            divisionSign = new Label();
            startButton = new Button();
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(timeLabel, "timeLabel");
            timeLabel.Name = "timeLabel";
            timeLabel.Click += timeLabel_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(plusLeftLabel, "plusLeftLabel");
            plusLeftLabel.Name = "plusLeftLabel";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // plusRightLabel
            // 
            plusRightLabel.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(plusRightLabel, "plusRightLabel");
            plusRightLabel.Name = "plusRightLabel";
            // 
            // equalsSign
            // 
            resources.ApplyResources(equalsSign, "equalsSign");
            equalsSign.Name = "equalsSign";
            // 
            // sum
            // 
            resources.ApplyResources(sum, "sum");
            sum.Name = "sum";
            sum.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(minusLeftLabel, "minusLeftLabel");
            minusLeftLabel.Name = "minusLeftLabel";
            // 
            // minusSign
            // 
            resources.ApplyResources(minusSign, "minusSign");
            minusSign.Name = "minusSign";
            // 
            // minusRightLabel
            // 
            minusRightLabel.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(minusRightLabel, "minusRightLabel");
            minusRightLabel.Name = "minusRightLabel";
            // 
            // minusEqualsSign
            // 
            resources.ApplyResources(minusEqualsSign, "minusEqualsSign");
            minusEqualsSign.Name = "minusEqualsSign";
            // 
            // difference
            // 
            resources.ApplyResources(difference, "difference");
            difference.Name = "difference";
            difference.ValueChanged += difference_ValueChanged;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(timesLeftLabel, "timesLeftLabel");
            timesLeftLabel.Name = "timesLeftLabel";
            // 
            // timesRightLabel
            // 
            timesRightLabel.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(timesRightLabel, "timesRightLabel");
            timesRightLabel.Name = "timesRightLabel";
            // 
            // multEqualsSign
            // 
            resources.ApplyResources(multEqualsSign, "multEqualsSign");
            multEqualsSign.Name = "multEqualsSign";
            // 
            // product
            // 
            resources.ApplyResources(product, "product");
            product.Name = "product";
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(dividedLeftLabel, "dividedLeftLabel");
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Click += label10_Click;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(dividedRightLabel, "dividedRightLabel");
            dividedRightLabel.Name = "dividedRightLabel";
            // 
            // divideEqualsSign
            // 
            resources.ApplyResources(divideEqualsSign, "divideEqualsSign");
            divideEqualsSign.Name = "divideEqualsSign";
            // 
            // quotient
            // 
            resources.ApplyResources(quotient, "quotient");
            quotient.Name = "quotient";
            // 
            // multiplicationSign
            // 
            resources.ApplyResources(multiplicationSign, "multiplicationSign");
            multiplicationSign.Name = "multiplicationSign";
            // 
            // divisionSign
            // 
            resources.ApplyResources(divisionSign, "divisionSign");
            divisionSign.Name = "divisionSign";
            // 
            // startButton
            // 
            resources.ApplyResources(startButton, "startButton");
            startButton.Name = "startButton";
            startButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(startButton);
            Controls.Add(divisionSign);
            Controls.Add(multiplicationSign);
            Controls.Add(quotient);
            Controls.Add(divideEqualsSign);
            Controls.Add(dividedRightLabel);
            Controls.Add(dividedLeftLabel);
            Controls.Add(product);
            Controls.Add(multEqualsSign);
            Controls.Add(timesRightLabel);
            Controls.Add(timesLeftLabel);
            Controls.Add(difference);
            Controls.Add(minusEqualsSign);
            Controls.Add(minusRightLabel);
            Controls.Add(minusSign);
            Controls.Add(minusLeftLabel);
            Controls.Add(sum);
            Controls.Add(equalsSign);
            Controls.Add(plusRightLabel);
            Controls.Add(label2);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label label2;
        private Label plusRightLabel;
        private Label equalsSign;
        private NumericUpDown sum;
        private Label minusLeftLabel;
        private Label minusSign;
        private Label minusRightLabel;
        private Label minusEqualsSign;
        private NumericUpDown difference;
        private Label timesLeftLabel;
        private Label timesRightLabel;
        private Label multEqualsSign;
        private NumericUpDown product;
        private Label dividedLeftLabel;
        private Label dividedRightLabel;
        private Label divideEqualsSign;
        private NumericUpDown quotient;
        private Label multiplicationSign;
        private Label divisionSign;
        private Button startButton;
    }
}
