namespace MChooser.UI
{
    partial class MoreInformationWindow
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
            this.chassisListBox = new System.Windows.Forms.ListBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.moreInfoContainer = new System.Windows.Forms.GroupBox();
            this.VariantsText = new System.Windows.Forms.Label();
            this.ClassText = new System.Windows.Forms.Label();
            this.FactionText = new System.Windows.Forms.Label();
            this.VariantsLabel = new System.Windows.Forms.Label();
            this.WeightClassLabel = new System.Windows.Forms.Label();
            this.FactionLabel = new System.Windows.Forms.Label();
            this.moreInfoContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // chassisListBox
            // 
            this.chassisListBox.FormattingEnabled = true;
            this.chassisListBox.ItemHeight = 20;
            this.chassisListBox.Location = new System.Drawing.Point(12, 51);
            this.chassisListBox.Name = "chassisListBox";
            this.chassisListBox.Size = new System.Drawing.Size(283, 124);
            this.chassisListBox.TabIndex = 0;
            this.chassisListBox.SelectedIndexChanged += new System.EventHandler(this.chassisListBox_SelectedIndexChanged);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(13, 13);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(51, 20);
            this.weightLabel.TabIndex = 1;
            this.weightLabel.Text = "label1";
            // 
            // moreInfoContainer
            // 
            this.moreInfoContainer.Controls.Add(this.VariantsText);
            this.moreInfoContainer.Controls.Add(this.ClassText);
            this.moreInfoContainer.Controls.Add(this.FactionText);
            this.moreInfoContainer.Controls.Add(this.VariantsLabel);
            this.moreInfoContainer.Controls.Add(this.WeightClassLabel);
            this.moreInfoContainer.Controls.Add(this.FactionLabel);
            this.moreInfoContainer.Location = new System.Drawing.Point(12, 213);
            this.moreInfoContainer.Name = "moreInfoContainer";
            this.moreInfoContainer.Size = new System.Drawing.Size(557, 154);
            this.moreInfoContainer.TabIndex = 2;
            this.moreInfoContainer.TabStop = false;
            this.moreInfoContainer.Text = "Details";
            // 
            // VariantsText
            // 
            this.VariantsText.AutoSize = true;
            this.VariantsText.Location = new System.Drawing.Point(96, 104);
            this.VariantsText.Name = "VariantsText";
            this.VariantsText.Size = new System.Drawing.Size(0, 20);
            this.VariantsText.TabIndex = 5;
            // 
            // ClassText
            // 
            this.ClassText.AutoSize = true;
            this.ClassText.Location = new System.Drawing.Point(96, 70);
            this.ClassText.Name = "ClassText";
            this.ClassText.Size = new System.Drawing.Size(0, 20);
            this.ClassText.TabIndex = 4;
            // 
            // FactionText
            // 
            this.FactionText.AutoSize = true;
            this.FactionText.Location = new System.Drawing.Point(96, 37);
            this.FactionText.Name = "FactionText";
            this.FactionText.Size = new System.Drawing.Size(0, 20);
            this.FactionText.TabIndex = 3;
            // 
            // VariantsLabel
            // 
            this.VariantsLabel.AutoSize = true;
            this.VariantsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VariantsLabel.Location = new System.Drawing.Point(7, 104);
            this.VariantsLabel.Name = "VariantsLabel";
            this.VariantsLabel.Size = new System.Drawing.Size(76, 20);
            this.VariantsLabel.TabIndex = 2;
            this.VariantsLabel.Text = "Variants";
            // 
            // WeightClassLabel
            // 
            this.WeightClassLabel.AutoSize = true;
            this.WeightClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightClassLabel.Location = new System.Drawing.Point(7, 70);
            this.WeightClassLabel.Name = "WeightClassLabel";
            this.WeightClassLabel.Size = new System.Drawing.Size(53, 20);
            this.WeightClassLabel.TabIndex = 1;
            this.WeightClassLabel.Text = "Class";
            // 
            // FactionLabel
            // 
            this.FactionLabel.AutoSize = true;
            this.FactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactionLabel.Location = new System.Drawing.Point(7, 37);
            this.FactionLabel.Name = "FactionLabel";
            this.FactionLabel.Size = new System.Drawing.Size(69, 20);
            this.FactionLabel.TabIndex = 0;
            this.FactionLabel.Text = "Faction";
            // 
            // MoreInformationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 379);
            this.Controls.Add(this.moreInfoContainer);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.chassisListBox);
            this.Name = "MoreInformationWindow";
            this.Text = "MoreInformationWindow";
            this.moreInfoContainer.ResumeLayout(false);
            this.moreInfoContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox chassisListBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.GroupBox moreInfoContainer;
        private System.Windows.Forms.Label VariantsLabel;
        private System.Windows.Forms.Label WeightClassLabel;
        private System.Windows.Forms.Label FactionLabel;
        private System.Windows.Forms.Label VariantsText;
        private System.Windows.Forms.Label ClassText;
        private System.Windows.Forms.Label FactionText;
    }
}