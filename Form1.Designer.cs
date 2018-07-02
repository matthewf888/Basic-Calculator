namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.ceButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.plusminusButton = new System.Windows.Forms.Button();
            this.mainDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subtractButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Label();
            this.invisibleFocusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ceButton
            // 
            this.ceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceButton.Location = new System.Drawing.Point(10, 93);
            this.ceButton.Name = "ceButton";
            this.ceButton.Size = new System.Drawing.Size(62, 63);
            this.ceButton.TabIndex = 0;
            this.ceButton.TabStop = false;
            this.ceButton.Text = "CE";
            this.ceButton.UseVisualStyleBackColor = true;
            this.ceButton.Click += new System.EventHandler(this.ceButton_Click);
            // 
            // cButton
            // 
            this.cButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton.Location = new System.Drawing.Point(78, 93);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(62, 63);
            this.cButton.TabIndex = 1;
            this.cButton.TabStop = false;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // delButton
            // 
            this.delButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.Location = new System.Drawing.Point(146, 93);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(62, 63);
            this.delButton.TabIndex = 2;
            this.delButton.TabStop = false;
            this.delButton.Text = "DEL";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.backspace);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.Location = new System.Drawing.Point(214, 93);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(62, 63);
            this.divideButton.TabIndex = 3;
            this.divideButton.TabStop = false;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.operator_click);
            // 
            // multButton
            // 
            this.multButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multButton.Location = new System.Drawing.Point(214, 160);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(62, 63);
            this.multButton.TabIndex = 7;
            this.multButton.TabStop = false;
            this.multButton.Text = "*";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.Click += new System.EventHandler(this.operator_click);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.Location = new System.Drawing.Point(146, 160);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(62, 63);
            this.nineButton.TabIndex = 6;
            this.nineButton.TabStop = false;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.button_Clicked);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(78, 160);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(62, 63);
            this.eightButton.TabIndex = 5;
            this.eightButton.TabStop = false;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.button_Clicked);
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.Location = new System.Drawing.Point(9, 160);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(62, 63);
            this.sevenButton.TabIndex = 4;
            this.sevenButton.TabStop = false;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.button_Clicked);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(214, 294);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(62, 63);
            this.addButton.TabIndex = 11;
            this.addButton.TabStop = false;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.operator_click);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.Location = new System.Drawing.Point(146, 294);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(62, 63);
            this.threeButton.TabIndex = 10;
            this.threeButton.TabStop = false;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.button_Clicked);
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.Location = new System.Drawing.Point(78, 294);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(62, 63);
            this.twoButton.TabIndex = 9;
            this.twoButton.TabStop = false;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.button_Clicked);
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(9, 294);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(62, 63);
            this.oneButton.TabIndex = 8;
            this.oneButton.TabStop = false;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.button_Clicked);
            // 
            // equalsButton
            // 
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.Location = new System.Drawing.Point(214, 362);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(62, 63);
            this.equalsButton.TabIndex = 15;
            this.equalsButton.TabStop = false;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(146, 361);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(62, 63);
            this.decimalButton.TabIndex = 14;
            this.decimalButton.TabStop = false;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.button_Clicked);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.Location = new System.Drawing.Point(78, 361);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(62, 63);
            this.zeroButton.TabIndex = 13;
            this.zeroButton.TabStop = false;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.button_Clicked);
            // 
            // plusminusButton
            // 
            this.plusminusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusminusButton.Location = new System.Drawing.Point(10, 361);
            this.plusminusButton.Name = "plusminusButton";
            this.plusminusButton.Size = new System.Drawing.Size(62, 63);
            this.plusminusButton.TabIndex = 12;
            this.plusminusButton.TabStop = false;
            this.plusminusButton.Text = "+/-";
            this.plusminusButton.UseVisualStyleBackColor = true;
            this.plusminusButton.Click += new System.EventHandler(this.Negate_Number);
            // 
            // mainDisplay
            // 
            this.mainDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDisplay.Location = new System.Drawing.Point(10, 41);
            this.mainDisplay.Name = "mainDisplay";
            this.mainDisplay.Size = new System.Drawing.Size(266, 40);
            this.mainDisplay.TabIndex = 16;
            this.mainDisplay.TabStop = false;
            this.mainDisplay.Text = "0";
            this.mainDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Standard";
            // 
            // subtractButton
            // 
            this.subtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractButton.Location = new System.Drawing.Point(214, 228);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(62, 63);
            this.subtractButton.TabIndex = 21;
            this.subtractButton.TabStop = false;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.operator_click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(146, 227);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(62, 63);
            this.sixButton.TabIndex = 20;
            this.sixButton.TabStop = false;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.button_Clicked);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(78, 227);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(62, 63);
            this.fiveButton.TabIndex = 19;
            this.fiveButton.TabStop = false;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.button_Clicked);
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.Location = new System.Drawing.Point(10, 227);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(62, 63);
            this.fourButton.TabIndex = 18;
            this.fourButton.TabStop = false;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.button_Clicked);
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.SystemColors.Window;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.equation.Location = new System.Drawing.Point(13, 44);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 20);
            this.equation.TabIndex = 22;
            // 
            // invisibleFocusLabel
            // 
            this.invisibleFocusLabel.AutoSize = true;
            this.invisibleFocusLabel.Location = new System.Drawing.Point(105, 51);
            this.invisibleFocusLabel.Name = "invisibleFocusLabel";
            this.invisibleFocusLabel.Size = new System.Drawing.Size(35, 13);
            this.invisibleFocusLabel.TabIndex = 23;
            this.invisibleFocusLabel.Text = "label2";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 435);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainDisplay);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.plusminusButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.ceButton);
            this.Controls.Add(this.invisibleFocusLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(301, 474);
            this.MinimumSize = new System.Drawing.Size(301, 474);
            this.Name = "Calculator";
            this.Opacity = 0.93D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matt\'s Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ceButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button plusminusButton;
        private System.Windows.Forms.TextBox mainDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.Label invisibleFocusLabel;
    }
}

