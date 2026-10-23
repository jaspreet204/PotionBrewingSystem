namespace PotionBrewingSystem
{
    partial class BrewingForm
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
            cmbRecipes = new ComboBox();
            btnBrew = new Button();
            progressBar1 = new ProgressBar();
            lblStatus = new Label();
            dgvPotions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPotions).BeginInit();
            SuspendLayout();
            // 
            // cmbRecipes
            // 
            cmbRecipes.FormattingEnabled = true;
            cmbRecipes.Location = new Point(53, 93);
            cmbRecipes.Name = "cmbRecipes";
            cmbRecipes.Size = new Size(151, 28);
            cmbRecipes.TabIndex = 0;
            // 
            // btnBrew
            // 
            btnBrew.Location = new Point(53, 45);
            btnBrew.Name = "btnBrew";
            btnBrew.Size = new Size(94, 29);
            btnBrew.TabIndex = 1;
            btnBrew.Text = "Start Brewing";
            btnBrew.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(53, 149);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(125, 29);
            progressBar1.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(255, 149);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Ready";
            // 
            // dgvPotions
            // 
            dgvPotions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPotions.Location = new Point(31, 214);
            dgvPotions.Name = "dgvPotions";
            dgvPotions.RowHeadersWidth = 51;
            dgvPotions.Size = new Size(605, 188);
            dgvPotions.TabIndex = 4;
            // 
            // BrewingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPotions);
            Controls.Add(lblStatus);
            Controls.Add(progressBar1);
            Controls.Add(btnBrew);
            Controls.Add(cmbRecipes);
            Name = "BrewingForm";
            Text = "BrewingForm";
            Click += btnBrew_Click;
            ((System.ComponentModel.ISupportInitialize)dgvPotions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbRecipes;
        private Button btnBrew;
        private ProgressBar progressBar1;
        private Label lblStatus;
        private DataGridView dgvPotions;
    }
}