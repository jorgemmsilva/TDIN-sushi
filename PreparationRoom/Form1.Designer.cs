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
            this.components = new System.ComponentModel.Container();
            this.PrepareButton = new System.Windows.Forms.Button();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderitemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenttimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // PrepareButton
            // 
            this.PrepareButton.Location = new System.Drawing.Point(190, 267);
            this.PrepareButton.Name = "PrepareButton";
            this.PrepareButton.Size = new System.Drawing.Size(98, 43);
            this.PrepareButton.TabIndex = 2;
            this.PrepareButton.Text = "Preparar";
            this.PrepareButton.UseVisualStyleBackColor = true;
            // 
            // ReadyButton
            // 
            this.ReadyButton.Location = new System.Drawing.Point(672, 267);
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.order_items,
            this.client,
            this.orderstatusDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn,
            this.paymenttimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(449, 222);
            this.dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // order_items
            // 
            this.order_items.DataPropertyName = "order_items";
            this.order_items.HeaderText = "order_items";
            this.order_items.Name = "order_items";
            this.order_items.ReadOnly = true;
            // 
            // client
            // 
            this.client.DataPropertyName = "client";
            this.client.HeaderText = "client";
            this.client.Name = "client";
            this.client.ReadOnly = true;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "client";
            this.dataGridViewTextBoxColumn1.HeaderText = "client";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.orderitemsDataGridViewTextBoxColumn,
            this.orderstatusDataGridViewTextBoxColumn1,
            this.totalpriceDataGridViewTextBoxColumn1,
            this.paymenttimeDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.orderBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(479, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(433, 222);
            this.dataGridView2.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "client";
            this.dataGridViewTextBoxColumn2.HeaderText = "client";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // orderitemsDataGridViewTextBoxColumn
            // 
            this.orderitemsDataGridViewTextBoxColumn.DataPropertyName = "order_items";
            this.orderitemsDataGridViewTextBoxColumn.HeaderText = "order_items";
            this.orderitemsDataGridViewTextBoxColumn.Name = "orderitemsDataGridViewTextBoxColumn";
            this.orderitemsDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 322);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReadyButton);
            this.Controls.Add(this.PrepareButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrepareButton;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderitemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenttimeDataGridViewTextBoxColumn1;



    }
}

