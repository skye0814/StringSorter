namespace StringSorter
{
    partial class MainForm
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
            this.SortButton = new System.Windows.Forms.Button();
            this.sortStratLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sortingStratComboBox = new System.Windows.Forms.ComboBox();
            this.inputStringTextBox = new System.Windows.Forms.RichTextBox();
            this.outputStringTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(236, 314);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(75, 23);
            this.SortButton.TabIndex = 0;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // sortStratLabel
            // 
            this.sortStratLabel.AutoSize = true;
            this.sortStratLabel.Location = new System.Drawing.Point(212, 71);
            this.sortStratLabel.Name = "sortStratLabel";
            this.sortStratLabel.Size = new System.Drawing.Size(124, 13);
            this.sortStratLabel.TabIndex = 1;
            this.sortStratLabel.Text = "Select a Sorting Strategy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to String Sorter!";
            // 
            // sortingStratComboBox
            // 
            this.sortingStratComboBox.FormattingEnabled = true;
            this.sortingStratComboBox.Location = new System.Drawing.Point(194, 87);
            this.sortingStratComboBox.Name = "sortingStratComboBox";
            this.sortingStratComboBox.Size = new System.Drawing.Size(163, 21);
            this.sortingStratComboBox.TabIndex = 3;
            this.sortingStratComboBox.SelectedIndexChanged += new System.EventHandler(this.sortingStratComboBox_SelectedIndexChanged);
            // 
            // inputStringTextBox
            // 
            this.inputStringTextBox.Location = new System.Drawing.Point(18, 154);
            this.inputStringTextBox.Name = "inputStringTextBox";
            this.inputStringTextBox.Size = new System.Drawing.Size(248, 120);
            this.inputStringTextBox.TabIndex = 5;
            this.inputStringTextBox.Text = "";
            this.inputStringTextBox.TextChanged += new System.EventHandler(this.inputStringTextBox_TextChanged);
            this.inputStringTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputStringTextBox_KeyDown);
            // 
            // outputStringTextBox
            // 
            this.outputStringTextBox.Location = new System.Drawing.Point(287, 154);
            this.outputStringTextBox.Name = "outputStringTextBox";
            this.outputStringTextBox.ReadOnly = true;
            this.outputStringTextBox.Size = new System.Drawing.Size(248, 120);
            this.outputStringTextBox.TabIndex = 6;
            this.outputStringTextBox.Text = "";
            this.outputStringTextBox.TextChanged += new System.EventHandler(this.outputStringTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 351);
            this.Controls.Add(this.outputStringTextBox);
            this.Controls.Add(this.inputStringTextBox);
            this.Controls.Add(this.sortingStratComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortStratLabel);
            this.Controls.Add(this.SortButton);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "String Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label sortStratLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sortingStratComboBox;
        private System.Windows.Forms.RichTextBox inputStringTextBox;
        private System.Windows.Forms.RichTextBox outputStringTextBox;
    }
}

