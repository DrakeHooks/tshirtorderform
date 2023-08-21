namespace Tacky_Tees
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
            calculateButton = new Button();
            colorsGrpBox = new GroupBox();
            customColorRadBtn = new RadioButton();
            purpleRadBtn = new RadioButton();
            blueRadBtn = new RadioButton();
            greenRadBtn = new RadioButton();
            yellowRadBtn = new RadioButton();
            orangeRadBtn = new RadioButton();
            redRadBtn = new RadioButton();
            greyRadBtn = new RadioButton();
            blackRadBtn = new RadioButton();
            whiteRadBtn = new RadioButton();
            customColorTxtBox = new TextBox();
            sizeGrpBox = new GroupBox();
            xlRadButton = new RadioButton();
            lgRadButton = new RadioButton();
            medRadButton = new RadioButton();
            smRadButton = new RadioButton();
            summaryGrpBox = new GroupBox();
            outputListBox = new ListBox();
            numericUpDown1 = new NumericUpDown();
            quantityTxtLbl = new Label();
            discountChkBox = new CheckBox();
            clearButton = new Button();
            exitButton = new Button();
            letteringGrpBox = new GroupBox();
            letteringTxtBox = new TextBox();
            pictureBox1 = new PictureBox();
            logoLbl = new Label();
            colorsGrpBox.SuspendLayout();
            sizeGrpBox.SuspendLayout();
            summaryGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            letteringGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(184, 814);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(130, 50);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Calculate Total";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // colorsGrpBox
            // 
            colorsGrpBox.Controls.Add(customColorRadBtn);
            colorsGrpBox.Controls.Add(purpleRadBtn);
            colorsGrpBox.Controls.Add(blueRadBtn);
            colorsGrpBox.Controls.Add(greenRadBtn);
            colorsGrpBox.Controls.Add(yellowRadBtn);
            colorsGrpBox.Controls.Add(orangeRadBtn);
            colorsGrpBox.Controls.Add(redRadBtn);
            colorsGrpBox.Controls.Add(greyRadBtn);
            colorsGrpBox.Controls.Add(blackRadBtn);
            colorsGrpBox.Controls.Add(whiteRadBtn);
            colorsGrpBox.Controls.Add(customColorTxtBox);
            colorsGrpBox.Location = new Point(255, 162);
            colorsGrpBox.Name = "colorsGrpBox";
            colorsGrpBox.Size = new Size(602, 168);
            colorsGrpBox.TabIndex = 1;
            colorsGrpBox.TabStop = false;
            colorsGrpBox.Text = "Colors";
            // 
            // customColorRadBtn
            // 
            customColorRadBtn.AutoSize = true;
            customColorRadBtn.Location = new Point(452, 36);
            customColorRadBtn.Name = "customColorRadBtn";
            customColorRadBtn.Size = new Size(110, 24);
            customColorRadBtn.TabIndex = 10;
            customColorRadBtn.TabStop = true;
            customColorRadBtn.Text = "Custom +$2";
            customColorRadBtn.UseVisualStyleBackColor = true;
            customColorRadBtn.CheckedChanged += customColorRadBtn_CheckedChanged;
            // 
            // purpleRadBtn
            // 
            purpleRadBtn.AutoSize = true;
            purpleRadBtn.Location = new Point(294, 122);
            purpleRadBtn.Name = "purpleRadBtn";
            purpleRadBtn.Size = new Size(98, 24);
            purpleRadBtn.TabIndex = 9;
            purpleRadBtn.TabStop = true;
            purpleRadBtn.Text = "Purple+$1";
            purpleRadBtn.UseVisualStyleBackColor = true;
            // 
            // blueRadBtn
            // 
            blueRadBtn.AutoSize = true;
            blueRadBtn.Location = new Point(294, 78);
            blueRadBtn.Name = "blueRadBtn";
            blueRadBtn.Size = new Size(85, 24);
            blueRadBtn.TabIndex = 8;
            blueRadBtn.TabStop = true;
            blueRadBtn.Text = "Blue+$1";
            blueRadBtn.UseVisualStyleBackColor = true;
            // 
            // greenRadBtn
            // 
            greenRadBtn.AutoSize = true;
            greenRadBtn.Location = new Point(294, 36);
            greenRadBtn.Name = "greenRadBtn";
            greenRadBtn.Size = new Size(95, 24);
            greenRadBtn.TabIndex = 7;
            greenRadBtn.TabStop = true;
            greenRadBtn.Text = "Green+$1";
            greenRadBtn.UseVisualStyleBackColor = true;
            // 
            // yellowRadBtn
            // 
            yellowRadBtn.AutoSize = true;
            yellowRadBtn.Location = new Point(144, 122);
            yellowRadBtn.Name = "yellowRadBtn";
            yellowRadBtn.Size = new Size(99, 24);
            yellowRadBtn.TabIndex = 6;
            yellowRadBtn.TabStop = true;
            yellowRadBtn.Text = "Yellow+$1";
            yellowRadBtn.UseVisualStyleBackColor = true;
            // 
            // orangeRadBtn
            // 
            orangeRadBtn.AutoSize = true;
            orangeRadBtn.Location = new Point(144, 78);
            orangeRadBtn.Name = "orangeRadBtn";
            orangeRadBtn.Size = new Size(105, 24);
            orangeRadBtn.TabIndex = 5;
            orangeRadBtn.TabStop = true;
            orangeRadBtn.Text = "Orange+$1";
            orangeRadBtn.UseVisualStyleBackColor = true;
            // 
            // redRadBtn
            // 
            redRadBtn.AutoSize = true;
            redRadBtn.Location = new Point(144, 36);
            redRadBtn.Name = "redRadBtn";
            redRadBtn.Size = new Size(82, 24);
            redRadBtn.TabIndex = 4;
            redRadBtn.TabStop = true;
            redRadBtn.Text = "Red+$1";
            redRadBtn.UseVisualStyleBackColor = true;
            // 
            // greyRadBtn
            // 
            greyRadBtn.AutoSize = true;
            greyRadBtn.Location = new Point(21, 122);
            greyRadBtn.Name = "greyRadBtn";
            greyRadBtn.Size = new Size(60, 24);
            greyRadBtn.TabIndex = 3;
            greyRadBtn.TabStop = true;
            greyRadBtn.Text = "Grey";
            greyRadBtn.UseVisualStyleBackColor = true;
            // 
            // blackRadBtn
            // 
            blackRadBtn.AutoSize = true;
            blackRadBtn.Location = new Point(21, 77);
            blackRadBtn.Name = "blackRadBtn";
            blackRadBtn.Size = new Size(65, 24);
            blackRadBtn.TabIndex = 2;
            blackRadBtn.TabStop = true;
            blackRadBtn.Text = "Black";
            blackRadBtn.UseVisualStyleBackColor = true;
            // 
            // whiteRadBtn
            // 
            whiteRadBtn.AutoSize = true;
            whiteRadBtn.Location = new Point(21, 36);
            whiteRadBtn.Name = "whiteRadBtn";
            whiteRadBtn.Size = new Size(69, 24);
            whiteRadBtn.TabIndex = 1;
            whiteRadBtn.TabStop = true;
            whiteRadBtn.Text = "White";
            whiteRadBtn.UseVisualStyleBackColor = true;
            // 
            // customColorTxtBox
            // 
            customColorTxtBox.Location = new Point(452, 74);
            customColorTxtBox.Name = "customColorTxtBox";
            customColorTxtBox.Size = new Size(125, 27);
            customColorTxtBox.TabIndex = 0;
            customColorTxtBox.Visible = false;
            // 
            // sizeGrpBox
            // 
            sizeGrpBox.Controls.Add(xlRadButton);
            sizeGrpBox.Controls.Add(lgRadButton);
            sizeGrpBox.Controls.Add(medRadButton);
            sizeGrpBox.Controls.Add(smRadButton);
            sizeGrpBox.Location = new Point(7, 162);
            sizeGrpBox.Name = "sizeGrpBox";
            sizeGrpBox.Size = new Size(237, 168);
            sizeGrpBox.TabIndex = 2;
            sizeGrpBox.TabStop = false;
            sizeGrpBox.Text = "Size";
            // 
            // xlRadButton
            // 
            xlRadButton.AutoSize = true;
            xlRadButton.Location = new Point(58, 129);
            xlRadButton.Name = "xlRadButton";
            xlRadButton.Size = new Size(134, 24);
            xlRadButton.TabIndex = 3;
            xlRadButton.TabStop = true;
            xlRadButton.Text = "Extra Large ($7)";
            xlRadButton.UseVisualStyleBackColor = true;
            // 
            // lgRadButton
            // 
            lgRadButton.AutoSize = true;
            lgRadButton.Location = new Point(58, 93);
            lgRadButton.Name = "lgRadButton";
            lgRadButton.Size = new Size(97, 24);
            lgRadButton.TabIndex = 2;
            lgRadButton.TabStop = true;
            lgRadButton.Text = "Large ($6)";
            lgRadButton.UseVisualStyleBackColor = true;
            // 
            // medRadButton
            // 
            medRadButton.AutoSize = true;
            medRadButton.Location = new Point(58, 63);
            medRadButton.Name = "medRadButton";
            medRadButton.Size = new Size(115, 24);
            medRadButton.TabIndex = 1;
            medRadButton.TabStop = true;
            medRadButton.Text = "Medium ($5)";
            medRadButton.UseVisualStyleBackColor = true;
            // 
            // smRadButton
            // 
            smRadButton.AutoSize = true;
            smRadButton.Location = new Point(58, 26);
            smRadButton.Name = "smRadButton";
            smRadButton.Size = new Size(97, 24);
            smRadButton.TabIndex = 0;
            smRadButton.TabStop = true;
            smRadButton.Text = "Small ($4)";
            smRadButton.UseVisualStyleBackColor = true;
            // 
            // summaryGrpBox
            // 
            summaryGrpBox.Controls.Add(outputListBox);
            summaryGrpBox.Controls.Add(numericUpDown1);
            summaryGrpBox.Controls.Add(quantityTxtLbl);
            summaryGrpBox.Controls.Add(discountChkBox);
            summaryGrpBox.Location = new Point(198, 468);
            summaryGrpBox.Name = "summaryGrpBox";
            summaryGrpBox.Size = new Size(468, 315);
            summaryGrpBox.TabIndex = 3;
            summaryGrpBox.TabStop = false;
            summaryGrpBox.Text = "Summary";
            // 
            // outputListBox
            // 
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 20;
            outputListBox.Location = new Point(96, 39);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new Size(277, 104);
            outputListBox.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(223, 163);
            numericUpDown1.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // quantityTxtLbl
            // 
            quantityTxtLbl.AutoSize = true;
            quantityTxtLbl.Location = new Point(142, 165);
            quantityTxtLbl.Name = "quantityTxtLbl";
            quantityTxtLbl.Size = new Size(65, 20);
            quantityTxtLbl.TabIndex = 1;
            quantityTxtLbl.Text = "Quantity";
            // 
            // discountChkBox
            // 
            discountChkBox.AutoSize = true;
            discountChkBox.Location = new Point(157, 238);
            discountChkBox.Name = "discountChkBox";
            discountChkBox.Size = new Size(154, 24);
            discountChkBox.TabIndex = 0;
            discountChkBox.Text = "Preferred Discount";
            discountChkBox.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(367, 814);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(130, 50);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear All";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click_1;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(550, 814);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(130, 50);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // letteringGrpBox
            // 
            letteringGrpBox.Controls.Add(letteringTxtBox);
            letteringGrpBox.Location = new Point(69, 345);
            letteringGrpBox.Name = "letteringGrpBox";
            letteringGrpBox.Size = new Size(727, 106);
            letteringGrpBox.TabIndex = 6;
            letteringGrpBox.TabStop = false;
            letteringGrpBox.Text = "Custom Lettering";
            // 
            // letteringTxtBox
            // 
            letteringTxtBox.Location = new Point(29, 41);
            letteringTxtBox.Name = "letteringTxtBox";
            letteringTxtBox.Size = new Size(672, 27);
            letteringTxtBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_1437536433_612x612;
            pictureBox1.Location = new Point(174, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // logoLbl
            // 
            logoLbl.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            logoLbl.Location = new Point(326, 43);
            logoLbl.Name = "logoLbl";
            logoLbl.Size = new Size(364, 43);
            logoLbl.TabIndex = 8;
            logoLbl.Text = "Tacky Tees Order Form";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 876);
            Controls.Add(logoLbl);
            Controls.Add(pictureBox1);
            Controls.Add(letteringGrpBox);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(summaryGrpBox);
            Controls.Add(sizeGrpBox);
            Controls.Add(colorsGrpBox);
            Controls.Add(calculateButton);
            Name = "Form1";
            Text = "Tacky Tees";
            colorsGrpBox.ResumeLayout(false);
            colorsGrpBox.PerformLayout();
            sizeGrpBox.ResumeLayout(false);
            sizeGrpBox.PerformLayout();
            summaryGrpBox.ResumeLayout(false);
            summaryGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            letteringGrpBox.ResumeLayout(false);
            letteringGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button calculateButton;
        private GroupBox colorsGrpBox;
        private GroupBox sizeGrpBox;
        private GroupBox summaryGrpBox;
        private Button clearButton;
        private Button exitButton;
        private GroupBox letteringGrpBox;
        private RadioButton purpleRadBtn;
        private RadioButton blueRadBtn;
        private RadioButton greenRadBtn;
        private RadioButton yellowRadBtn;
        private RadioButton orangeRadBtn;
        private RadioButton redRadBtn;
        private RadioButton greyRadBtn;
        private RadioButton blackRadBtn;
        private RadioButton whiteRadBtn;
        private TextBox customColorTxtBox;
        private RadioButton xlRadButton;
        private RadioButton lgRadButton;
        private RadioButton medRadButton;
        private RadioButton smRadButton;
        private TextBox letteringTxtBox;
        private RadioButton customColorRadBtn;
        private CheckBox discountChkBox;
        private Label quantityTxtLbl;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox1;
        private Label logoLbl;
        private ListBox outputListBox;
    }
}