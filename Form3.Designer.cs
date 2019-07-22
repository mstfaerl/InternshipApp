namespace InternshipApp
{
    partial class Form3
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
            this.updateMaterial = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialPrice = new System.Windows.Forms.TextBox();
            this.materialSupplier = new System.Windows.Forms.TextBox();
            this.materialQuantity = new System.Windows.Forms.TextBox();
            this.materialDescription = new System.Windows.Forms.TextBox();
            this.materialName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 41);
            this.label1.TabIndex = 38;
            this.label1.Text = "Update Material Page";
            // 
            // updateMaterial
            // 
            this.updateMaterial.Location = new System.Drawing.Point(312, 503);
            this.updateMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.updateMaterial.Name = "updateMaterial";
            this.updateMaterial.Size = new System.Drawing.Size(186, 45);
            this.updateMaterial.TabIndex = 37;
            this.updateMaterial.Text = "Update";
            this.updateMaterial.UseVisualStyleBackColor = true;
            this.updateMaterial.Click += new System.EventHandler(this.UpdateMaterial_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Material Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Material Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Material Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Material Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Material Name";
            // 
            // materialPrice
            // 
            this.materialPrice.Location = new System.Drawing.Point(216, 461);
            this.materialPrice.Margin = new System.Windows.Forms.Padding(4);
            this.materialPrice.Name = "materialPrice";
            this.materialPrice.Size = new System.Drawing.Size(278, 32);
            this.materialPrice.TabIndex = 31;
            // 
            // materialSupplier
            // 
            this.materialSupplier.Location = new System.Drawing.Point(216, 396);
            this.materialSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.materialSupplier.Name = "materialSupplier";
            this.materialSupplier.Size = new System.Drawing.Size(278, 32);
            this.materialSupplier.TabIndex = 30;
            // 
            // materialQuantity
            // 
            this.materialQuantity.Location = new System.Drawing.Point(216, 331);
            this.materialQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.materialQuantity.Name = "materialQuantity";
            this.materialQuantity.Size = new System.Drawing.Size(278, 32);
            this.materialQuantity.TabIndex = 29;
            // 
            // materialDescription
            // 
            this.materialDescription.Location = new System.Drawing.Point(216, 170);
            this.materialDescription.Margin = new System.Windows.Forms.Padding(4);
            this.materialDescription.Multiline = true;
            this.materialDescription.Name = "materialDescription";
            this.materialDescription.Size = new System.Drawing.Size(278, 123);
            this.materialDescription.TabIndex = 28;
            // 
            // materialName
            // 
            this.materialName.Location = new System.Drawing.Point(216, 97);
            this.materialName.Margin = new System.Windows.Forms.Padding(4);
            this.materialName.Name = "materialName";
            this.materialName.Size = new System.Drawing.Size(278, 32);
            this.materialName.TabIndex = 27;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialPrice);
            this.Controls.Add(this.materialSupplier);
            this.Controls.Add(this.materialQuantity);
            this.Controls.Add(this.materialDescription);
            this.Controls.Add(this.materialName);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Update Material";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox materialPrice;
        private System.Windows.Forms.TextBox materialSupplier;
        private System.Windows.Forms.TextBox materialQuantity;
        private System.Windows.Forms.TextBox materialDescription;
        private System.Windows.Forms.TextBox materialName;
    }
}