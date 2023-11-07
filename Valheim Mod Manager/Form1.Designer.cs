
namespace Valheim_Mod_Manager
{
    partial class frm_ValheimModManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ValheimModManager));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_BepinExVersion = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_UpdateBepinEx = new System.Windows.Forms.Button();
            this.btn_UpdateMods = new System.Windows.Forms.Button();
            this.btn_Disable = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_EditConfig = new System.Windows.Forms.Button();
            this.btn_DeleteConfig = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbox_ConfigEditor = new System.Windows.Forms.TextBox();
            this.btn_ConfigEditor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbox_BepinExLocation = new System.Windows.Forms.GroupBox();
            this.Txt_BepiExLocation = new System.Windows.Forms.TextBox();
            this.btn_BepinExLocation = new System.Windows.Forms.Button();
            this.Lbl_BepinExLocation = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnRefreshMods = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpbox_BepinExLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(346, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.lbl_BepinExVersion);
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Controls.Add(this.btn_UpdateBepinEx);
            this.tabPage1.Controls.Add(this.btnRefreshMods);
            this.tabPage1.Controls.Add(this.btn_UpdateMods);
            this.tabPage1.Controls.Add(this.btn_Disable);
            this.tabPage1.Controls.Add(this.btn_Remove);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(338, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mods";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "$ver";
            // 
            // lbl_BepinExVersion
            // 
            this.lbl_BepinExVersion.AutoSize = true;
            this.lbl_BepinExVersion.Location = new System.Drawing.Point(27, 12);
            this.lbl_BepinExVersion.Name = "lbl_BepinExVersion";
            this.lbl_BepinExVersion.Size = new System.Drawing.Size(84, 13);
            this.lbl_BepinExVersion.TabIndex = 7;
            this.lbl_BepinExVersion.Text = "BepinEx Version";
            this.lbl_BepinExVersion.Click += new System.EventHandler(this.lbl_BepinExVersion_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(7, 37);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(325, 319);
            this.checkedListBox1.TabIndex = 6;
            // 
            // btn_UpdateBepinEx
            // 
            this.btn_UpdateBepinEx.Location = new System.Drawing.Point(257, 7);
            this.btn_UpdateBepinEx.Name = "btn_UpdateBepinEx";
            this.btn_UpdateBepinEx.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateBepinEx.TabIndex = 5;
            this.btn_UpdateBepinEx.Text = "Update";
            this.btn_UpdateBepinEx.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateMods
            // 
            this.btn_UpdateMods.Location = new System.Drawing.Point(257, 368);
            this.btn_UpdateMods.Name = "btn_UpdateMods";
            this.btn_UpdateMods.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateMods.TabIndex = 5;
            this.btn_UpdateMods.Text = "Update";
            this.btn_UpdateMods.UseVisualStyleBackColor = true;
            // 
            // btn_Disable
            // 
            this.btn_Disable.Location = new System.Drawing.Point(88, 368);
            this.btn_Disable.Name = "btn_Disable";
            this.btn_Disable.Size = new System.Drawing.Size(75, 23);
            this.btn_Disable.TabIndex = 4;
            this.btn_Disable.Text = "Disable";
            this.btn_Disable.UseVisualStyleBackColor = true;
            this.btn_Disable.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(7, 368);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 4;
            this.btn_Remove.Text = "Delete";
            this.btn_Remove.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Controls.Add(this.btn_EditConfig);
            this.tabPage2.Controls.Add(this.btn_DeleteConfig);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(338, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(7, 7);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(325, 354);
            this.treeView1.TabIndex = 3;
            // 
            // btn_EditConfig
            // 
            this.btn_EditConfig.Location = new System.Drawing.Point(257, 367);
            this.btn_EditConfig.Name = "btn_EditConfig";
            this.btn_EditConfig.Size = new System.Drawing.Size(75, 23);
            this.btn_EditConfig.TabIndex = 2;
            this.btn_EditConfig.Text = "Edit";
            this.btn_EditConfig.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteConfig
            // 
            this.btn_DeleteConfig.Location = new System.Drawing.Point(6, 367);
            this.btn_DeleteConfig.Name = "btn_DeleteConfig";
            this.btn_DeleteConfig.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteConfig.TabIndex = 1;
            this.btn_DeleteConfig.Text = "Delete";
            this.btn_DeleteConfig.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.grpbox_BepinExLocation);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(338, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbox_ConfigEditor);
            this.groupBox1.Controls.Add(this.btn_ConfigEditor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 44);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtbox_ConfigEditor
            // 
            this.txtbox_ConfigEditor.Location = new System.Drawing.Point(102, 13);
            this.txtbox_ConfigEditor.Name = "txtbox_ConfigEditor";
            this.txtbox_ConfigEditor.Size = new System.Drawing.Size(184, 20);
            this.txtbox_ConfigEditor.TabIndex = 0;
            // 
            // btn_ConfigEditor
            // 
            this.btn_ConfigEditor.Location = new System.Drawing.Point(292, 11);
            this.btn_ConfigEditor.Name = "btn_ConfigEditor";
            this.btn_ConfigEditor.Size = new System.Drawing.Size(25, 23);
            this.btn_ConfigEditor.TabIndex = 2;
            this.btn_ConfigEditor.Text = "...";
            this.btn_ConfigEditor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Config Editor";
            // 
            // grpbox_BepinExLocation
            // 
            this.grpbox_BepinExLocation.Controls.Add(this.Txt_BepiExLocation);
            this.grpbox_BepinExLocation.Controls.Add(this.btn_BepinExLocation);
            this.grpbox_BepinExLocation.Controls.Add(this.Lbl_BepinExLocation);
            this.grpbox_BepinExLocation.Location = new System.Drawing.Point(6, 6);
            this.grpbox_BepinExLocation.Name = "grpbox_BepinExLocation";
            this.grpbox_BepinExLocation.Size = new System.Drawing.Size(326, 44);
            this.grpbox_BepinExLocation.TabIndex = 3;
            this.grpbox_BepinExLocation.TabStop = false;
            // 
            // Txt_BepiExLocation
            // 
            this.Txt_BepiExLocation.Location = new System.Drawing.Point(102, 13);
            this.Txt_BepiExLocation.Name = "Txt_BepiExLocation";
            this.Txt_BepiExLocation.Size = new System.Drawing.Size(184, 20);
            this.Txt_BepiExLocation.TabIndex = 0;
            // 
            // btn_BepinExLocation
            // 
            this.btn_BepinExLocation.Location = new System.Drawing.Point(292, 11);
            this.btn_BepinExLocation.Name = "btn_BepinExLocation";
            this.btn_BepinExLocation.Size = new System.Drawing.Size(25, 23);
            this.btn_BepinExLocation.TabIndex = 2;
            this.btn_BepinExLocation.Text = "...";
            this.btn_BepinExLocation.UseVisualStyleBackColor = true;
            // 
            // Lbl_BepinExLocation
            // 
            this.Lbl_BepinExLocation.AutoSize = true;
            this.Lbl_BepinExLocation.Location = new System.Drawing.Point(6, 16);
            this.Lbl_BepinExLocation.Name = "Lbl_BepinExLocation";
            this.Lbl_BepinExLocation.Size = new System.Drawing.Size(90, 13);
            this.Lbl_BepinExLocation.TabIndex = 1;
            this.Lbl_BepinExLocation.Text = "BepinEx Location";
            // 
            // btnRefreshMods
            // 
            this.btnRefreshMods.Location = new System.Drawing.Point(176, 368);
            this.btnRefreshMods.Name = "btnRefreshMods";
            this.btnRefreshMods.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshMods.TabIndex = 5;
            this.btnRefreshMods.Text = "Refresh";
            this.btnRefreshMods.UseVisualStyleBackColor = true;
            // 
            // frm_ValheimModManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_ValheimModManager";
            this.Text = "Simple Mod Manager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbox_BepinExLocation.ResumeLayout(false);
            this.grpbox_BepinExLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_UpdateMods;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_EditConfig;
        private System.Windows.Forms.Button btn_DeleteConfig;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbox_ConfigEditor;
        private System.Windows.Forms.Button btn_ConfigEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbox_BepinExLocation;
        private System.Windows.Forms.TextBox Txt_BepiExLocation;
        private System.Windows.Forms.Button btn_BepinExLocation;
        private System.Windows.Forms.Label Lbl_BepinExLocation;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_Disable;
        private System.Windows.Forms.Label lbl_BepinExVersion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_UpdateBepinEx;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnRefreshMods;
    }
}

