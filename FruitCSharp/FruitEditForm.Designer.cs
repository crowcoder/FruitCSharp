namespace FruitCSharp
{
    partial class FruitEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FruitEditForm));
            this.dataGridViewFruit = new System.Windows.Forms.DataGridView();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFruit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFruit
            // 
            this.dataGridViewFruit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFruit.Location = new System.Drawing.Point(39, 42);
            this.dataGridViewFruit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewFruit.Name = "dataGridViewFruit";
            this.dataGridViewFruit.Size = new System.Drawing.Size(782, 375);
            this.dataGridViewFruit.TabIndex = 0;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(662, 436);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(159, 57);
            this.buttonSaveChanges.TabIndex = 1;
            this.buttonSaveChanges.Text = "&Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            // 
            // FruitEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 534);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.dataGridViewFruit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FruitEditForm";
            this.Text = "Fruit Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFruit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFruit;
        private System.Windows.Forms.Button buttonSaveChanges;
    }
}

