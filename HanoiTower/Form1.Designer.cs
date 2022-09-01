namespace HanoiTower
{
    partial class Form1
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
            this.NextMoveButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.NumberOfPlates = new System.Windows.Forms.NumericUpDown();
            this.NumberOfMoves = new System.Windows.Forms.Label();
            this.AutomaticMove = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.FastBox = new System.Windows.Forms.CheckBox();
            this.SFastBox = new System.Windows.Forms.CheckBox();
            this.ColoredBox = new System.Windows.Forms.CheckBox();
            this.SaveToFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPlates)).BeginInit();
            this.SuspendLayout();
            // 
            // NextMoveButton
            // 
            this.NextMoveButton.Location = new System.Drawing.Point(356, 356);
            this.NextMoveButton.Name = "NextMoveButton";
            this.NextMoveButton.Size = new System.Drawing.Size(75, 23);
            this.NextMoveButton.TabIndex = 0;
            this.NextMoveButton.Text = "Next move";
            this.NextMoveButton.UseVisualStyleBackColor = true;
            this.NextMoveButton.Click += new System.EventHandler(this.NextMoveButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(275, 356);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // NumberOfPlates
            // 
            this.NumberOfPlates.Location = new System.Drawing.Point(206, 359);
            this.NumberOfPlates.Name = "NumberOfPlates";
            this.NumberOfPlates.Size = new System.Drawing.Size(63, 20);
            this.NumberOfPlates.TabIndex = 2;
            this.NumberOfPlates.ValueChanged += new System.EventHandler(this.NumberOfPlates_ValueChanged);
            // 
            // NumberOfMoves
            // 
            this.NumberOfMoves.AutoSize = true;
            this.NumberOfMoves.Location = new System.Drawing.Point(437, 361);
            this.NumberOfMoves.Name = "NumberOfMoves";
            this.NumberOfMoves.Size = new System.Drawing.Size(46, 13);
            this.NumberOfMoves.TabIndex = 3;
            this.NumberOfMoves.Text = "Move: 0";
            // 
            // AutomaticMove
            // 
            this.AutomaticMove.Location = new System.Drawing.Point(771, 356);
            this.AutomaticMove.Name = "AutomaticMove";
            this.AutomaticMove.Size = new System.Drawing.Size(65, 23);
            this.AutomaticMove.TabIndex = 4;
            this.AutomaticMove.Text = "Auto";
            this.AutomaticMove.UseVisualStyleBackColor = true;
            this.AutomaticMove.Click += new System.EventHandler(this.AutomaticMove_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(125, 356);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 5;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // FastBox
            // 
            this.FastBox.AutoSize = true;
            this.FastBox.Location = new System.Drawing.Point(592, 360);
            this.FastBox.Name = "FastBox";
            this.FastBox.Size = new System.Drawing.Size(46, 17);
            this.FastBox.TabIndex = 6;
            this.FastBox.Text = "Fast";
            this.FastBox.UseVisualStyleBackColor = true;
            // 
            // SFastBox
            // 
            this.SFastBox.AutoSize = true;
            this.SFastBox.Location = new System.Drawing.Point(644, 360);
            this.SFastBox.Name = "SFastBox";
            this.SFastBox.Size = new System.Drawing.Size(53, 17);
            this.SFastBox.TabIndex = 7;
            this.SFastBox.Text = "SFast";
            this.SFastBox.UseVisualStyleBackColor = true;
            // 
            // ColoredBox
            // 
            this.ColoredBox.AutoSize = true;
            this.ColoredBox.Location = new System.Drawing.Point(703, 360);
            this.ColoredBox.Name = "ColoredBox";
            this.ColoredBox.Size = new System.Drawing.Size(62, 17);
            this.ColoredBox.TabIndex = 8;
            this.ColoredBox.Text = "Colored";
            this.ColoredBox.UseVisualStyleBackColor = true;
            this.ColoredBox.CheckedChanged += new System.EventHandler(this.ColoredBox_CheckedChanged);
            // 
            // SaveToFile
            // 
            this.SaveToFile.Location = new System.Drawing.Point(842, 356);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.Size = new System.Drawing.Size(111, 23);
            this.SaveToFile.TabIndex = 9;
            this.SaveToFile.Text = "Save to file";
            this.SaveToFile.UseVisualStyleBackColor = true;
            this.SaveToFile.Click += new System.EventHandler(this.SaveToFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 391);
            this.ControlBox = false;
            this.Controls.Add(this.SaveToFile);
            this.Controls.Add(this.ColoredBox);
            this.Controls.Add(this.SFastBox);
            this.Controls.Add(this.FastBox);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.AutomaticMove);
            this.Controls.Add(this.NumberOfMoves);
            this.Controls.Add(this.NumberOfPlates);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.NextMoveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Hanoi Tower Solver - by J.Woldon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPlates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextMoveButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.NumericUpDown NumberOfPlates;
        private System.Windows.Forms.Label NumberOfMoves;
        private System.Windows.Forms.Button AutomaticMove;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.CheckBox FastBox;
        private System.Windows.Forms.CheckBox SFastBox;
        private System.Windows.Forms.CheckBox ColoredBox;
        private System.Windows.Forms.Button SaveToFile;
    }
}

