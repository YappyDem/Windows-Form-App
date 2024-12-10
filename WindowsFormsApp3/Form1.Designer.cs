namespace ShawarmaOrderApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cbChicken = new System.Windows.Forms.CheckBox();
            this.cbBeef = new System.Windows.Forms.CheckBox();
            this.cbVegetarian = new System.Windows.Forms.CheckBox();
            this.numericChicken = new System.Windows.Forms.NumericUpDown();
            this.numericBeef = new System.Windows.Forms.NumericUpDown();
            this.numericVegetarian = new System.Windows.Forms.NumericUpDown();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericChicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBeef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVegetarian)).BeginInit();
            this.SuspendLayout();
            // 
            // cbChicken
            // 
            this.cbChicken.AutoSize = true;
            this.cbChicken.Location = new System.Drawing.Point(22, 24);
            this.cbChicken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbChicken.Name = "cbChicken";
            this.cbChicken.Size = new System.Drawing.Size(110, 17);
            this.cbChicken.TabIndex = 0;
            this.cbChicken.Text = "Куриная шаурма";
            this.cbChicken.UseVisualStyleBackColor = true;
            // 
            // cbBeef
            // 
            this.cbBeef.AutoSize = true;
            this.cbBeef.Location = new System.Drawing.Point(22, 57);
            this.cbBeef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBeef.Name = "cbBeef";
            this.cbBeef.Size = new System.Drawing.Size(112, 17);
            this.cbBeef.TabIndex = 1;
            this.cbBeef.Text = "Говяжья шаурма";
            this.cbBeef.UseVisualStyleBackColor = true;
            // 
            // cbVegetarian
            // 
            this.cbVegetarian.AutoSize = true;
            this.cbVegetarian.Location = new System.Drawing.Point(22, 89);
            this.cbVegetarian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbVegetarian.Name = "cbVegetarian";
            this.cbVegetarian.Size = new System.Drawing.Size(151, 17);
            this.cbVegetarian.TabIndex = 2;
            this.cbVegetarian.Text = "Вегетарианская шаурма";
            this.cbVegetarian.UseVisualStyleBackColor = true;
            // 
            // numericChicken
            // 
            this.numericChicken.Location = new System.Drawing.Point(176, 24);
            this.numericChicken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericChicken.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericChicken.Name = "numericChicken";
            this.numericChicken.Size = new System.Drawing.Size(38, 20);
            this.numericChicken.TabIndex = 3;
            this.numericChicken.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericBeef
            // 
            this.numericBeef.Location = new System.Drawing.Point(176, 57);
            this.numericBeef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericBeef.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBeef.Name = "numericBeef";
            this.numericBeef.Size = new System.Drawing.Size(38, 20);
            this.numericBeef.TabIndex = 4;
            this.numericBeef.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericVegetarian
            // 
            this.numericVegetarian.Location = new System.Drawing.Point(176, 89);
            this.numericVegetarian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericVegetarian.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericVegetarian.Name = "numericVegetarian";
            this.numericVegetarian.Size = new System.Drawing.Size(38, 20);
            this.numericVegetarian.TabIndex = 5;
            this.numericVegetarian.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(22, 122);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(82, 29);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 212);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.numericVegetarian);
            this.Controls.Add(this.numericBeef);
            this.Controls.Add(this.numericChicken);
            this.Controls.Add(this.cbVegetarian);
            this.Controls.Add(this.cbBeef);
            this.Controls.Add(this.cbChicken);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Заказ шаурмы";
            ((System.ComponentModel.ISupportInitialize)(this.numericChicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBeef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVegetarian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.CheckBox cbChicken;
        private System.Windows.Forms.CheckBox cbBeef;
        private System.Windows.Forms.CheckBox cbVegetarian;
        private System.Windows.Forms.NumericUpDown numericChicken;
        private System.Windows.Forms.NumericUpDown numericBeef;
        private System.Windows.Forms.NumericUpDown numericVegetarian;
        private System.Windows.Forms.Button btnNext;
    }
}