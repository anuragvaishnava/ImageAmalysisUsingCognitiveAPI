namespace ImageAmalysisUsingCognitiveAPI
{
    partial class LabelKeys
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
            this.TextFilePath = new System.Windows.Forms.TextBox();
            this.LabelImagePath = new System.Windows.Forms.Label();
            this.ButtonAnalyze = new System.Windows.Forms.Button();
            this.LabelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextKeys = new System.Windows.Forms.TextBox();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Browse = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.RadioButtonAnalyze = new System.Windows.Forms.RadioButton();
            this.RadioButtonDescr = new System.Windows.Forms.RadioButton();
            this.RadioButtonRecognize = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // TextFilePath
            // 
            this.TextFilePath.Location = new System.Drawing.Point(135, 32);
            this.TextFilePath.Name = "TextFilePath";
            this.TextFilePath.Size = new System.Drawing.Size(307, 20);
            this.TextFilePath.TabIndex = 0;
            // 
            // LabelImagePath
            // 
            this.LabelImagePath.AutoSize = true;
            this.LabelImagePath.Location = new System.Drawing.Point(55, 35);
            this.LabelImagePath.Name = "LabelImagePath";
            this.LabelImagePath.Size = new System.Drawing.Size(61, 13);
            this.LabelImagePath.TabIndex = 1;
            this.LabelImagePath.Text = "Image Path";
            // 
            // ButtonAnalyze
            // 
            this.ButtonAnalyze.Location = new System.Drawing.Point(448, 74);
            this.ButtonAnalyze.Name = "ButtonAnalyze";
            this.ButtonAnalyze.Size = new System.Drawing.Size(75, 23);
            this.ButtonAnalyze.TabIndex = 2;
            this.ButtonAnalyze.Text = "Go..";
            this.ButtonAnalyze.UseVisualStyleBackColor = true;
            this.ButtonAnalyze.Click += new System.EventHandler(this.ButtonAnalyze_Click);
            // 
            // LabelResult
            // 
            this.LabelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelResult.Location = new System.Drawing.Point(55, 162);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(554, 281);
            this.LabelResult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Keys";
            // 
            // TextKeys
            // 
            this.TextKeys.Location = new System.Drawing.Point(135, 76);
            this.TextKeys.Name = "TextKeys";
            this.TextKeys.Size = new System.Drawing.Size(307, 20);
            this.TextKeys.TabIndex = 5;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(448, 32);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 6;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(627, 32);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(359, 411);
            this.picture.TabIndex = 7;
            this.picture.TabStop = false;
            // 
            // RadioButtonAnalyze
            // 
            this.RadioButtonAnalyze.AutoSize = true;
            this.RadioButtonAnalyze.Location = new System.Drawing.Point(135, 120);
            this.RadioButtonAnalyze.Name = "RadioButtonAnalyze";
            this.RadioButtonAnalyze.Size = new System.Drawing.Size(62, 17);
            this.RadioButtonAnalyze.TabIndex = 8;
            this.RadioButtonAnalyze.TabStop = true;
            this.RadioButtonAnalyze.Text = "Analyze";
            this.RadioButtonAnalyze.UseVisualStyleBackColor = true;
            // 
            // RadioButtonDescr
            // 
            this.RadioButtonDescr.AutoSize = true;
            this.RadioButtonDescr.Checked = true;
            this.RadioButtonDescr.Location = new System.Drawing.Point(234, 120);
            this.RadioButtonDescr.Name = "RadioButtonDescr";
            this.RadioButtonDescr.Size = new System.Drawing.Size(78, 17);
            this.RadioButtonDescr.TabIndex = 9;
            this.RadioButtonDescr.TabStop = true;
            this.RadioButtonDescr.Text = "Description";
            this.RadioButtonDescr.UseVisualStyleBackColor = true;
            // 
            // RadioButtonRecognize
            // 
            this.RadioButtonRecognize.AutoSize = true;
            this.RadioButtonRecognize.Location = new System.Drawing.Point(364, 120);
            this.RadioButtonRecognize.Name = "RadioButtonRecognize";
            this.RadioButtonRecognize.Size = new System.Drawing.Size(76, 17);
            this.RadioButtonRecognize.TabIndex = 10;
            this.RadioButtonRecognize.Text = "Recognize";
            this.RadioButtonRecognize.UseVisualStyleBackColor = true;
            // 
            // LabelKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 460);
            this.Controls.Add(this.RadioButtonRecognize);
            this.Controls.Add(this.RadioButtonDescr);
            this.Controls.Add(this.RadioButtonAnalyze);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.TextKeys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.ButtonAnalyze);
            this.Controls.Add(this.LabelImagePath);
            this.Controls.Add(this.TextFilePath);
            this.Name = "LabelKeys";
            this.Text = "ImageAnalysis";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextFilePath;
        private System.Windows.Forms.Label LabelImagePath;
        private System.Windows.Forms.Button ButtonAnalyze;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextKeys;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.RadioButton RadioButtonAnalyze;
        private System.Windows.Forms.RadioButton RadioButtonDescr;
        private System.Windows.Forms.RadioButton RadioButtonRecognize;
    }
}

