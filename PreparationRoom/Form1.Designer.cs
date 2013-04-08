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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(238, 13);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(121, 97);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 322);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ReadyButton);
            this.Controls.Add(this.PrepareButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrepareButton;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;



    }
}

