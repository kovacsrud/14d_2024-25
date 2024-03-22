namespace WindowsFormsOld
{
    partial class Ablak
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
            this.labelForm = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxSzoveg = new System.Windows.Forms.TextBox();
            this.buttonKiir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelForm.Location = new System.Drawing.Point(144, 38);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(101, 26);
            this.labelForm.TabIndex = 0;
            this.labelForm.Text = "Winform";
            this.labelForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOutput.Location = new System.Drawing.Point(328, 264);
            this.labelOutput.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(100, 29);
            this.labelOutput.TabIndex = 1;
            // 
            // textBoxSzoveg
            // 
            this.textBoxSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSzoveg.Location = new System.Drawing.Point(328, 141);
            this.textBoxSzoveg.Name = "textBoxSzoveg";
            this.textBoxSzoveg.Size = new System.Drawing.Size(100, 29);
            this.textBoxSzoveg.TabIndex = 2;
            this.textBoxSzoveg.TextChanged += new System.EventHandler(this.textBoxSzoveg_TextChanged);
            // 
            // buttonKiir
            // 
            this.buttonKiir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKiir.Location = new System.Drawing.Point(328, 377);
            this.buttonKiir.Name = "buttonKiir";
            this.buttonKiir.Size = new System.Drawing.Size(100, 29);
            this.buttonKiir.TabIndex = 3;
            this.buttonKiir.Text = "Kiírás";
            this.buttonKiir.UseVisualStyleBackColor = true;
            this.buttonKiir.Click += new System.EventHandler(this.buttonKiir_Click);
            // 
            // Ablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKiir);
            this.Controls.Add(this.textBoxSzoveg);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelForm);
            this.Name = "Ablak";
            this.Text = "Ablak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxSzoveg;
        private System.Windows.Forms.Button buttonKiir;
    }
}

