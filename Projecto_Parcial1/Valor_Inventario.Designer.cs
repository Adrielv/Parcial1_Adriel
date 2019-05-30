namespace Projecto_Parcial1
{
    partial class Valor_Inventario
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
            this.label1 = new System.Windows.Forms.Label();
            this.ValorInventarioLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "El valor total inventario";
            // 
            // ValorInventarioLabel
            // 
            this.ValorInventarioLabel.AutoSize = true;
            this.ValorInventarioLabel.Location = new System.Drawing.Point(120, 51);
            this.ValorInventarioLabel.Name = "ValorInventarioLabel";
            this.ValorInventarioLabel.Size = new System.Drawing.Size(0, 17);
            this.ValorInventarioLabel.TabIndex = 1;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = global::Projecto_Parcial1.Properties.Resources.refresh;
            this.RefreshButton.Location = new System.Drawing.Point(247, 41);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(45, 36);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Valor_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 93);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ValorInventarioLabel);
            this.Controls.Add(this.label1);
            this.Name = "Valor_Inventario";
            this.Text = "Valor_Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ValorInventarioLabel;
        private System.Windows.Forms.Button RefreshButton;
    }
}