
namespace OsuBGDeleter
{
    partial class OsuBgDeleterMain
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

        // watch me do it anyway
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OsuBgDeleterMain));
            this.label1 = new System.Windows.Forms.Label();
            this.selectDir = new System.Windows.Forms.Button();
            this.dirTextbox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDeleter = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.checkboxSBFolders = new System.Windows.Forms.CheckBox();
            this.tgtImgType = new System.Windows.Forms.GroupBox();
            this.buttonSaveImgType = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabDeleter.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tgtImgType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osu Background Deleter";
            // 
            // selectDir
            // 
            this.selectDir.Location = new System.Drawing.Point(3, 28);
            this.selectDir.Name = "selectDir";
            this.selectDir.Size = new System.Drawing.Size(170, 29);
            this.selectDir.TabIndex = 1;
            this.selectDir.Text = "Select Song Directory";
            this.selectDir.UseVisualStyleBackColor = true;
            this.selectDir.Click += new System.EventHandler(this.selectDir_Click);
            // 
            // dirTextbox
            // 
            this.dirTextbox.Location = new System.Drawing.Point(3, 64);
            this.dirTextbox.Name = "dirTextbox";
            this.dirTextbox.Size = new System.Drawing.Size(170, 27);
            this.dirTextbox.TabIndex = 2;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(3, 98);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(170, 29);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Images!";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDeleter);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(261, 167);
            this.tabControl.TabIndex = 4;
            // 
            // tabDeleter
            // 
            this.tabDeleter.BackColor = System.Drawing.Color.Orchid;
            this.tabDeleter.Controls.Add(this.selectDir);
            this.tabDeleter.Controls.Add(this.deleteButton);
            this.tabDeleter.Controls.Add(this.label1);
            this.tabDeleter.Controls.Add(this.dirTextbox);
            this.tabDeleter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabDeleter.Location = new System.Drawing.Point(4, 29);
            this.tabDeleter.Name = "tabDeleter";
            this.tabDeleter.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeleter.Size = new System.Drawing.Size(253, 134);
            this.tabDeleter.TabIndex = 0;
            this.tabDeleter.Text = "Deleter";
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.Orchid;
            this.tabSettings.Controls.Add(this.checkboxSBFolders);
            this.tabSettings.Controls.Add(this.tgtImgType);
            this.tabSettings.Location = new System.Drawing.Point(4, 29);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(253, 134);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            // 
            // checkboxSBFolders
            // 
            this.checkboxSBFolders.AutoSize = true;
            this.checkboxSBFolders.Location = new System.Drawing.Point(10, 110);
            this.checkboxSBFolders.Name = "checkboxSBFolders";
            this.checkboxSBFolders.Size = new System.Drawing.Size(150, 24);
            this.checkboxSBFolders.TabIndex = 2;
            this.checkboxSBFolders.Text = "Include Map Skins";
            this.checkboxSBFolders.UseVisualStyleBackColor = true;
            this.checkboxSBFolders.CheckedChanged += new System.EventHandler(this.checkboxSBFolders_CheckedChanged);
            // 
            // tgtImgType
            // 
            this.tgtImgType.BackColor = System.Drawing.Color.Orchid;
            this.tgtImgType.Controls.Add(this.buttonSaveImgType);
            this.tgtImgType.Controls.Add(this.comboBox1);
            this.tgtImgType.Location = new System.Drawing.Point(3, 3);
            this.tgtImgType.Name = "tgtImgType";
            this.tgtImgType.Size = new System.Drawing.Size(247, 103);
            this.tgtImgType.TabIndex = 1;
            this.tgtImgType.TabStop = false;
            this.tgtImgType.Text = "Image Type";
            // 
            // buttonSaveImgType
            // 
            this.buttonSaveImgType.Location = new System.Drawing.Point(7, 72);
            this.buttonSaveImgType.Name = "buttonSaveImgType";
            this.buttonSaveImgType.Size = new System.Drawing.Size(234, 29);
            this.buttonSaveImgType.TabIndex = 1;
            this.buttonSaveImgType.Text = "Save";
            this.buttonSaveImgType.UseVisualStyleBackColor = true;
            this.buttonSaveImgType.Click += new System.EventHandler(this.buttonSaveImgType_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Both",
            "PNG",
            "JPG"});
            this.comboBox1.Location = new System.Drawing.Point(6, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // OsuBgDeleterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(285, 196);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OsuBgDeleterMain";
            this.Text = "OsuBgDeleter";
            this.tabControl.ResumeLayout(false);
            this.tabDeleter.ResumeLayout(false);
            this.tabDeleter.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tgtImgType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectDir;
        private System.Windows.Forms.TextBox dirTextbox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDeleter;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.GroupBox tgtImgType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSaveImgType;
        private System.Windows.Forms.CheckBox checkboxSBFolders;
    }
}

