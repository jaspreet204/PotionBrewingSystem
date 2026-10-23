namespace PotionBrewingSystem
{
    partial class IngredientForm
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
            lblName = new Label();
            txtName = new TextBox();
            lblStock = new Label();
            numStock = new NumericUpDown();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvIngredients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(16, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Ingredient Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(16, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(671, 27);
            txtName.TabIndex = 1;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(16, 96);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(105, 20);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock Quantity";
            // 
            // numStock
            // 
            numStock.Location = new Point(16, 128);
            numStock.Name = "numStock";
            numStock.Size = new Size(630, 27);
            numStock.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(16, 178);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Ingredient";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(199, 178);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "update Ingredient";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(367, 178);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Retire Ingredient";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(562, 178);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvIngredients
            // 
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredients.Location = new Point(38, 241);
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.RowHeadersWidth = 51;
            dgvIngredients.Size = new Size(634, 188);
            dgvIngredients.TabIndex = 8;
            dgvIngredients.CellClick += dgvIngredients_CellClick;
            // 
            // IngredientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 503);
            Controls.Add(dgvIngredients);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(numStock);
            Controls.Add(lblStock);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "IngredientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Ingredients";
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblStock;
        private NumericUpDown numStock;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private DataGridView dgvIngredients;
    }
}