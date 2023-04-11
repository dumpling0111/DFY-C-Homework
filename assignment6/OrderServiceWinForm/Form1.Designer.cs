namespace OrderServiceWinForm
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            addOrderButton = new Button();
            updateOrderButton = new Button();
            deleteOrderButton = new Button();
            panel3 = new Panel();
            queryBy = new ComboBox();
            queryButton = new Button();
            queryBox = new TextBox();
            panel2 = new Panel();
            splitContainer1 = new SplitContainer();
            orderGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            createTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            orderDetailGridView = new DataGridView();
            orderDetailBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            goodsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(addOrderButton);
            flowLayoutPanel1.Controls.Add(updateOrderButton);
            flowLayoutPanel1.Controls.Add(deleteOrderButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 63);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(12);
            flowLayoutPanel1.Size = new Size(800, 62);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // addOrderButton
            // 
            addOrderButton.Anchor = AnchorStyles.Left;
            addOrderButton.Location = new Point(15, 15);
            addOrderButton.Name = "addOrderButton";
            addOrderButton.Size = new Size(94, 29);
            addOrderButton.TabIndex = 1;
            addOrderButton.Text = "添加订单";
            addOrderButton.UseVisualStyleBackColor = true;
            // 
            // updateOrderButton
            // 
            updateOrderButton.Anchor = AnchorStyles.Left;
            updateOrderButton.Location = new Point(115, 15);
            updateOrderButton.Name = "updateOrderButton";
            updateOrderButton.Size = new Size(94, 29);
            updateOrderButton.TabIndex = 2;
            updateOrderButton.Text = "修改订单";
            updateOrderButton.UseVisualStyleBackColor = true;
            // 
            // deleteOrderButton
            // 
            deleteOrderButton.Anchor = AnchorStyles.Left;
            deleteOrderButton.Location = new Point(215, 15);
            deleteOrderButton.Name = "deleteOrderButton";
            deleteOrderButton.Size = new Size(94, 29);
            deleteOrderButton.TabIndex = 3;
            deleteOrderButton.Text = "删除订单";
            deleteOrderButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(queryBy);
            panel3.Controls.Add(queryButton);
            panel3.Controls.Add(queryBox);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 63);
            panel3.TabIndex = 3;
            // 
            // queryBy
            // 
            queryBy.FormattingEnabled = true;
            queryBy.Items.AddRange(new object[] { "查询所有订单", "根据id查询", "根据客户名查询", "根据货物名查询", "根据总价查询" });
            queryBy.Location = new Point(15, 12);
            queryBy.Name = "queryBy";
            queryBy.Size = new Size(151, 28);
            queryBy.TabIndex = 0;
            // 
            // queryButton
            // 
            queryButton.Location = new Point(461, 10);
            queryButton.Name = "queryButton";
            queryButton.Size = new Size(94, 29);
            queryButton.TabIndex = 2;
            queryButton.Text = "查询";
            queryButton.UseVisualStyleBackColor = true;
            // 
            // queryBox
            // 
            queryBox.Location = new Point(172, 12);
            queryBox.Name = "queryBox";
            queryBox.Size = new Size(283, 27);
            queryBox.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(splitContainer1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 317);
            panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(orderGridView);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(orderDetailGridView);
            splitContainer1.Size = new Size(800, 317);
            splitContainer1.SplitterDistance = 403;
            splitContainer1.TabIndex = 0;
            // 
            // orderGridView
            // 
            orderGridView.AutoGenerateColumns = false;
            orderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, createTimeDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn });
            orderGridView.DataSource = orderBindingSource;
            orderGridView.Dock = DockStyle.Fill;
            orderGridView.Location = new Point(0, 0);
            orderGridView.Name = "orderGridView";
            orderGridView.RowHeadersWidth = 51;
            orderGridView.RowTemplate.Height = 29;
            orderGridView.Size = new Size(403, 317);
            orderGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Customer";
            dataGridViewTextBoxColumn1.HeaderText = "Customer";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
            createTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            createTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Order);
            // 
            // orderDetailGridView
            // 
            orderDetailGridView.AutoGenerateColumns = false;
            orderDetailGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDetailGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, goodsDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn1 });
            orderDetailGridView.DataSource = orderDetailBindingSource;
            orderDetailGridView.Dock = DockStyle.Fill;
            orderDetailGridView.Location = new Point(0, 0);
            orderDetailGridView.Name = "orderDetailGridView";
            orderDetailGridView.RowHeadersWidth = 51;
            orderDetailGridView.RowTemplate.Height = 29;
            orderDetailGridView.Size = new Size(393, 317);
            orderDetailGridView.TabIndex = 0;
            // 
            // orderDetailBindingSource
            // 
            orderDetailBindingSource.DataSource = typeof(OrderDetail);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            goodsDataGridViewTextBoxColumn.DataPropertyName = "Goods";
            goodsDataGridViewTextBoxColumn.HeaderText = "Goods";
            goodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            goodsDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn1.HeaderText = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            totalPriceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)orderGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button addOrderButton;
        private Button updateOrderButton;
        private Button deleteOrderButton;
        private Panel panel3;
        private ComboBox queryBy;
        private Button queryButton;
        private TextBox queryBox;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private DataGridView orderGridView;
        private DataGridView orderDetailGridView;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private BindingSource orderDetailBindingSource;
    }
}