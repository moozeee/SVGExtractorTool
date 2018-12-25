namespace SVGExtractorTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.outputPathTextBox = new System.Windows.Forms.TextBox();
            this.ChangeOutputFolderButton = new System.Windows.Forms.Button();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SVGCodeRTB = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputPathTextBox
            // 
            this.outputPathTextBox.Location = new System.Drawing.Point(146, 12);
            this.outputPathTextBox.Name = "outputPathTextBox";
            this.outputPathTextBox.Size = new System.Drawing.Size(728, 20);
            this.outputPathTextBox.TabIndex = 1;
            this.outputPathTextBox.TextChanged += new System.EventHandler(this.outputPathTextBox_TextChanged);
            // 
            // ChangeOutputFolderButton
            // 
            this.ChangeOutputFolderButton.Location = new System.Drawing.Point(13, 12);
            this.ChangeOutputFolderButton.Name = "ChangeOutputFolderButton";
            this.ChangeOutputFolderButton.Size = new System.Drawing.Size(128, 23);
            this.ChangeOutputFolderButton.TabIndex = 3;
            this.ChangeOutputFolderButton.Text = "Change Output Folder";
            this.ChangeOutputFolderButton.UseVisualStyleBackColor = true;
            this.ChangeOutputFolderButton.Click += new System.EventHandler(this.ChooseOutputFolderButtonClick);
            // 
            // ExtractButton
            // 
            this.ExtractButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExtractButton.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtractButton.Location = new System.Drawing.Point(319, 228);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(307, 40);
            this.ExtractButton.TabIndex = 4;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.UseVisualStyleBackColor = false;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "1 - Copy the SVG element and paste the result";
            // 
            // SVGCodeRTB
            // 
            this.SVGCodeRTB.Location = new System.Drawing.Point(146, 95);
            this.SVGCodeRTB.Name = "SVGCodeRTB";
            this.SVGCodeRTB.Size = new System.Drawing.Size(728, 127);
            this.SVGCodeRTB.TabIndex = 8;
            this.SVGCodeRTB.Text = "";
            this.SVGCodeRTB.TextChanged += new System.EventHandler(this.SVGCodeRTB_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "2 - Press the BUTTON >>>";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 275);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SVGCodeRTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.ChangeOutputFolderButton);
            this.Controls.Add(this.outputPathTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SVG Extractor Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TextBox outputPathTextBox;
        private System.Windows.Forms.Button ChangeOutputFolderButton;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox SVGCodeRTB;
        private System.Windows.Forms.Label label2;
    }
}

