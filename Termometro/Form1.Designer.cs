namespace Termometro
{
    partial class Termometro
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
            this.labelTemperatura = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label159 = new System.Windows.Forms.Label();
            this.labelMenos150 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelTemperatura
            // 
            this.labelTemperatura.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTemperatura.Location = new System.Drawing.Point(12, 9);
            this.labelTemperatura.Name = "labelTemperatura";
            this.labelTemperatura.Size = new System.Drawing.Size(429, 86);
            this.labelTemperatura.TabIndex = 0;
            this.labelTemperatura.Text = "0ºC";
            this.labelTemperatura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 102);
            this.progressBar.Maximum = 300;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(429, 23);
            this.progressBar.TabIndex = 1;
            this.progressBar.Value = 150;
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label159.Location = new System.Drawing.Point(404, 131);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(37, 21);
            this.label159.TabIndex = 2;
            this.label159.Text = "150";
            // 
            // labelMenos150
            // 
            this.labelMenos150.AutoSize = true;
            this.labelMenos150.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMenos150.Location = new System.Drawing.Point(12, 131);
            this.labelMenos150.Name = "labelMenos150";
            this.labelMenos150.Size = new System.Drawing.Size(43, 21);
            this.labelMenos150.TabIndex = 3;
            this.labelMenos150.Text = "-150";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label0.Location = new System.Drawing.Point(217, 131);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(19, 21);
            this.label0.TabIndex = 4;
            this.label0.Text = "0";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(12, 165);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(429, 128);
            this.log.TabIndex = 5;
            this.log.Text = "Aguardando atualização de temperatura...";
            // 
            // Termometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 305);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.labelMenos150);
            this.Controls.Add(this.label159);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelTemperatura);
            this.Name = "Termometro";
            this.Text = "Termômetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTemperatura;
        private ProgressBar progressBar;
        private Label label159;
        private Label labelMenos150;
        private Label label0;
        private RichTextBox log;
    }
}