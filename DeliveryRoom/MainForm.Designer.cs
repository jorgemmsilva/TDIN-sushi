namespace DeliveryRoom
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderitemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderitemsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenttimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveringButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.TeamLabel = new System.Windows.Forms.Label();
            this.TeamIDLabel = new System.Windows.Forms.Label();
            this.DetailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.orderitemsDataGridViewTextBoxColumn,
            this.orderstatusDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn,
            this.paymenttimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(416, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderitemsDataGridViewTextBoxColumn
            // 
            this.orderitemsDataGridViewTextBoxColumn.DataPropertyName = "order_items";
            this.orderitemsDataGridViewTextBoxColumn.HeaderText = "order_items";
            this.orderitemsDataGridViewTextBoxColumn.Name = "orderitemsDataGridViewTextBoxColumn";
            this.orderitemsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderstatusDataGridViewTextBoxColumn
            // 
            this.orderstatusDataGridViewTextBoxColumn.DataPropertyName = "order_status";
            this.orderstatusDataGridViewTextBoxColumn.HeaderText = "order_status";
            this.orderstatusDataGridViewTextBoxColumn.Name = "orderstatusDataGridViewTextBoxColumn";
            this.orderstatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymenttimeDataGridViewTextBoxColumn
            // 
            this.paymenttimeDataGridViewTextBoxColumn.DataPropertyName = "payment_time";
            this.paymenttimeDataGridViewTextBoxColumn.HeaderText = "payment_time";
            this.paymenttimeDataGridViewTextBoxColumn.Name = "paymenttimeDataGridViewTextBoxColumn";
            this.paymenttimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Common.Order);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.clientDataGridViewTextBoxColumn1,
            this.orderitemsDataGridViewTextBoxColumn1,
            this.orderstatusDataGridViewTextBoxColumn1,
            this.totalpriceDataGridViewTextBoxColumn1,
            this.paymenttimeDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.orderBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(482, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(403, 287);
            this.dataGridView2.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn1
            // 
            this.clientDataGridViewTextBoxColumn1.DataPropertyName = "client";
            this.clientDataGridViewTextBoxColumn1.HeaderText = "client";
            this.clientDataGridViewTextBoxColumn1.Name = "clientDataGridViewTextBoxColumn1";
            this.clientDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // orderitemsDataGridViewTextBoxColumn1
            // 
            this.orderitemsDataGridViewTextBoxColumn1.DataPropertyName = "order_items";
            this.orderitemsDataGridViewTextBoxColumn1.HeaderText = "order_items";
            this.orderitemsDataGridViewTextBoxColumn1.Name = "orderitemsDataGridViewTextBoxColumn1";
            this.orderitemsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // orderstatusDataGridViewTextBoxColumn1
            // 
            this.orderstatusDataGridViewTextBoxColumn1.DataPropertyName = "order_status";
            this.orderstatusDataGridViewTextBoxColumn1.HeaderText = "order_status";
            this.orderstatusDataGridViewTextBoxColumn1.Name = "orderstatusDataGridViewTextBoxColumn1";
            this.orderstatusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalpriceDataGridViewTextBoxColumn1
            // 
            this.totalpriceDataGridViewTextBoxColumn1.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn1.HeaderText = "total_price";
            this.totalpriceDataGridViewTextBoxColumn1.Name = "totalpriceDataGridViewTextBoxColumn1";
            this.totalpriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // paymenttimeDataGridViewTextBoxColumn1
            // 
            this.paymenttimeDataGridViewTextBoxColumn1.DataPropertyName = "payment_time";
            this.paymenttimeDataGridViewTextBoxColumn1.HeaderText = "payment_time";
            this.paymenttimeDataGridViewTextBoxColumn1.Name = "paymenttimeDataGridViewTextBoxColumn1";
            this.paymenttimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DeliveringButton
            // 
            this.DeliveringButton.Location = new System.Drawing.Point(353, 357);
            this.DeliveringButton.Name = "DeliveringButton";
            this.DeliveringButton.Size = new System.Drawing.Size(75, 23);
            this.DeliveringButton.TabIndex = 2;
            this.DeliveringButton.Text = "Entregar";
            this.DeliveringButton.UseVisualStyleBackColor = true;
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(645, 357);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 3;
            this.FinishButton.Text = "Terminado";
            this.FinishButton.UseVisualStyleBackColor = true;
            // 
            // TeamLabel
            // 
            this.TeamLabel.AutoSize = true;
            this.TeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamLabel.Location = new System.Drawing.Point(319, 9);
            this.TeamLabel.Name = "TeamLabel";
            this.TeamLabel.Size = new System.Drawing.Size(109, 29);
            this.TeamLabel.TabIndex = 4;
            this.TeamLabel.Text = "Equipa: ";
            // 
            // TeamIDLabel
            // 
            this.TeamIDLabel.AutoSize = true;
            this.TeamIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamIDLabel.Location = new System.Drawing.Point(477, 9);
            this.TeamIDLabel.Name = "TeamIDLabel";
            this.TeamIDLabel.Size = new System.Drawing.Size(85, 29);
            this.TeamIDLabel.TabIndex = 5;
            this.TeamIDLabel.Text = "label1";
            // 
            // DetailsButton
            // 
            this.DetailsButton.Location = new System.Drawing.Point(12, 357);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(136, 23);
            this.DetailsButton.TabIndex = 6;
            this.DetailsButton.Text = "Pormenores do Cliente";
            this.DetailsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 392);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.TeamIDLabel);
            this.Controls.Add(this.TeamLabel);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.DeliveringButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Sala de entrega";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button DeliveringButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderitemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderitemsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenttimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label TeamLabel;
        private System.Windows.Forms.Label TeamIDLabel;
        private System.Windows.Forms.Button DetailsButton;
    }
}

