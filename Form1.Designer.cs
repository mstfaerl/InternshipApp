namespace InternshipApp
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
            this.materialList = new System.Windows.Forms.DataGridView();
            this.searchingText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteMaterial = new System.Windows.Forms.Button();
            this.alarmButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.materialsControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.materialList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialList
            // 
            this.materialList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialList.Location = new System.Drawing.Point(12, 53);
            this.materialList.Name = "materialList";
            this.materialList.RowHeadersWidth = 51;
            this.materialList.RowTemplate.Height = 24;
            this.materialList.Size = new System.Drawing.Size(886, 380);
            this.materialList.TabIndex = 13;
            this.materialList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MaterialList_CellDoubleClick);
            this.materialList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MaterialList_CellMouseClick);
            // 
            // searchingText
            // 
            this.searchingText.Location = new System.Drawing.Point(712, 482);
            this.searchingText.Name = "searchingText";
            this.searchingText.Size = new System.Drawing.Size(186, 32);
            this.searchingText.TabIndex = 14;
            this.searchingText.TextChanged += new System.EventHandler(this.SearchingText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(708, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Searching Material";
            // 
            // deleteMaterial
            // 
            this.deleteMaterial.Location = new System.Drawing.Point(12, 480);
            this.deleteMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.deleteMaterial.Name = "deleteMaterial";
            this.deleteMaterial.Size = new System.Drawing.Size(186, 34);
            this.deleteMaterial.TabIndex = 19;
            this.deleteMaterial.Text = "Delete Material";
            this.deleteMaterial.UseVisualStyleBackColor = true;
            this.deleteMaterial.Click += new System.EventHandler(this.DeleteMaterial_Click);
            // 
            // alarmButton
            // 
            this.alarmButton.Location = new System.Drawing.Point(206, 482);
            this.alarmButton.Margin = new System.Windows.Forms.Padding(4);
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Size = new System.Drawing.Size(186, 34);
            this.alarmButton.TabIndex = 20;
            this.alarmButton.Text = "Close Alarm";
            this.alarmButton.UseVisualStyleBackColor = true;
            this.alarmButton.Click += new System.EventHandler(this.AlarmButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialsControlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(910, 30);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // materialsControlToolStripMenuItem
            // 
            this.materialsControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.updateGitToolStripMenuItem});
            this.materialsControlToolStripMenuItem.Name = "materialsControlToolStripMenuItem";
            this.materialsControlToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.materialsControlToolStripMenuItem.Text = "Materials Control";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.addNewToolStripMenuItem.Text = "Add New Material";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.AddNewToolStripMenuItem_Click);
            // 
            // updateGitToolStripMenuItem
            // 
            this.updateGitToolStripMenuItem.Name = "updateGitToolStripMenuItem";
            this.updateGitToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.updateGitToolStripMenuItem.Text = "Update Git";
            this.updateGitToolStripMenuItem.Click += new System.EventHandler(this.UpdateGitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(910, 548);
            this.Controls.Add(this.alarmButton);
            this.Controls.Add(this.deleteMaterial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchingText);
            this.Controls.Add(this.materialList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Internship Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.MaterialForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.materialList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView materialList;
        private System.Windows.Forms.TextBox searchingText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button deleteMaterial;
        private System.Windows.Forms.Button alarmButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem materialsControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateGitToolStripMenuItem;
    }
}

