namespace LifeIsMiserable
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.radioButtonVarchar = new System.Windows.Forms.RadioButton();
            this.radioButtonNumber = new System.Windows.Forms.RadioButton();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.checkOneLine = new System.Windows.Forms.CheckBox();
            this.checkPrefixZero = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(221, 405);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(286, 39);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Save Da time";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // radioButtonVarchar
            // 
            this.radioButtonVarchar.AutoSize = true;
            this.radioButtonVarchar.Checked = true;
            this.radioButtonVarchar.Location = new System.Drawing.Point(307, 368);
            this.radioButtonVarchar.Name = "radioButtonVarchar";
            this.radioButtonVarchar.Size = new System.Drawing.Size(102, 27);
            this.radioButtonVarchar.TabIndex = 2;
            this.radioButtonVarchar.TabStop = true;
            this.radioButtonVarchar.Text = "Varchar";
            this.radioButtonVarchar.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumber
            // 
            this.radioButtonNumber.AutoSize = true;
            this.radioButtonNumber.Location = new System.Drawing.Point(391, 368);
            this.radioButtonNumber.Name = "radioButtonNumber";
            this.radioButtonNumber.Size = new System.Drawing.Size(106, 27);
            this.radioButtonNumber.TabIndex = 3;
            this.radioButtonNumber.Text = "Number";
            this.radioButtonNumber.UseVisualStyleBackColor = true;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(48, 30);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(671, 312);
            this.inputBox.TabIndex = 4;
            this.inputBox.Text = "";
            // 
            // checkOneLine
            // 
            this.checkOneLine.AutoSize = true;
            this.checkOneLine.Location = new System.Drawing.Point(633, 368);
            this.checkOneLine.Name = "checkOneLine";
            this.checkOneLine.Size = new System.Drawing.Size(112, 27);
            this.checkOneLine.TabIndex = 5;
            this.checkOneLine.Text = "One Line";
            this.checkOneLine.UseVisualStyleBackColor = true;
            // 
            // checkPrefixZero
            // 
            this.checkPrefixZero.AutoSize = true;
            this.checkPrefixZero.Location = new System.Drawing.Point(633, 405);
            this.checkPrefixZero.Name = "checkPrefixZero";
            this.checkPrefixZero.Size = new System.Drawing.Size(102, 27);
            this.checkPrefixZero.TabIndex = 6;
            this.checkPrefixZero.Text = "Prefix 0";
            this.checkPrefixZero.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 439);
            this.Controls.Add(this.checkPrefixZero);
            this.Controls.Add(this.checkOneLine);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.radioButtonNumber);
            this.Controls.Add(this.radioButtonVarchar);
            this.Controls.Add(this.btnGenerate);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(784, 495);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(784, 495);
            this.Name = "Form1";
            this.Text = "Quotter | String Manipulations";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainUI_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton radioButtonVarchar;
        private System.Windows.Forms.RadioButton radioButtonNumber;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.CheckBox checkOneLine;
        private System.Windows.Forms.CheckBox checkPrefixZero;
    }
}

