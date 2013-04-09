namespace PreparationRoom
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
            this.PrepareButton = new System.Windows.Forms.Button();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PrepareButton
            // 
            this.PrepareButton.Location = new System.Drawing.Point(60, 267);
            this.PrepareButton.Name = "PrepareButton";
            this.PrepareButton.Size = new System.Drawing.Size(98, 43);
            this.PrepareButton.TabIndex = 2;
            this.PrepareButton.Text = "Preparar";
            this.PrepareButton.UseVisualStyleBackColor = true;
            // 
            // ReadyButton
            // 
            this.ReadyButton.Location = new System.Drawing.Point(245, 267);
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.Size = new System.Drawing.Size(115, 43);
            this.ReadyButton.TabIndex = 3;
            this.ReadyButton.Text = "Pronto para entrega";
            this.ReadyButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(315, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 322);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReadyButton);
            this.Controls.Add(this.PrepareButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrepareButton;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.DataGridView dataGridView1;



    }
}

