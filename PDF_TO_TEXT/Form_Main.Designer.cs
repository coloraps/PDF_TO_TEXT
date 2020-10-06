namespace PDF_TO_TEXT
{
    partial class Form_Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lab_InputPdf = new System.Windows.Forms.Label();
            this.Lab_OutputTxt = new System.Windows.Forms.Label();
            this.Txt_InputPdf = new System.Windows.Forms.TextBox();
            this.Txt_OutputTxt = new System.Windows.Forms.TextBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.lab_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lab_InputPdf
            // 
            this.Lab_InputPdf.AutoSize = true;
            this.Lab_InputPdf.Location = new System.Drawing.Point(22, 14);
            this.Lab_InputPdf.Name = "Lab_InputPdf";
            this.Lab_InputPdf.Size = new System.Drawing.Size(93, 16);
            this.Lab_InputPdf.TabIndex = 0;
            this.Lab_InputPdf.Text = "PDF Input Path";
            // 
            // Lab_OutputTxt
            // 
            this.Lab_OutputTxt.AutoSize = true;
            this.Lab_OutputTxt.Location = new System.Drawing.Point(22, 44);
            this.Lab_OutputTxt.Name = "Lab_OutputTxt";
            this.Lab_OutputTxt.Size = new System.Drawing.Size(97, 16);
            this.Lab_OutputTxt.TabIndex = 1;
            this.Lab_OutputTxt.Text = "TXT Output Path";
            // 
            // Txt_InputPdf
            // 
            this.Txt_InputPdf.Location = new System.Drawing.Point(144, 11);
            this.Txt_InputPdf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_InputPdf.Name = "Txt_InputPdf";
            this.Txt_InputPdf.Size = new System.Drawing.Size(664, 23);
            this.Txt_InputPdf.TabIndex = 2;
            // 
            // Txt_OutputTxt
            // 
            this.Txt_OutputTxt.Location = new System.Drawing.Point(144, 41);
            this.Txt_OutputTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_OutputTxt.Name = "Txt_OutputTxt";
            this.Txt_OutputTxt.Size = new System.Drawing.Size(664, 23);
            this.Txt_OutputTxt.TabIndex = 3;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(733, 71);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(75, 23);
            this.btn_Convert.TabIndex = 4;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // lab_info
            // 
            this.lab_info.AutoSize = true;
            this.lab_info.Location = new System.Drawing.Point(22, 94);
            this.lab_info.Name = "lab_info";
            this.lab_info.Size = new System.Drawing.Size(44, 16);
            this.lab_info.TabIndex = 5;
            this.lab_info.Text = "START";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 119);
            this.Controls.Add(this.lab_info);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.Txt_OutputTxt);
            this.Controls.Add(this.Txt_InputPdf);
            this.Controls.Add(this.Lab_OutputTxt);
            this.Controls.Add(this.Lab_InputPdf);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Main";
            this.Text = "PDF to Text Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_InputPdf;
        private System.Windows.Forms.Label Lab_OutputTxt;
        private System.Windows.Forms.TextBox Txt_InputPdf;
        private System.Windows.Forms.TextBox Txt_OutputTxt;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Label lab_info;
    }
}

