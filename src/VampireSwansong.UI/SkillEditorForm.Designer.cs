namespace VampireSwansong.UI;

partial class SkillEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillEditorForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.emem_tabPage = new System.Windows.Forms.TabPage();
            this.skillEditorEmem = new VampireSwansong.UI.SkillEditor();
            this.leysha_tabPage = new System.Windows.Forms.TabPage();
            this.skillEditorLeysha = new VampireSwansong.UI.SkillEditor();
            this.galeb_tabPage = new System.Windows.Forms.TabPage();
            this.skillEditorGaleb = new VampireSwansong.UI.SkillEditor();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.emem_tabPage.SuspendLayout();
            this.leysha_tabPage.SuspendLayout();
            this.galeb_tabPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.emem_tabPage);
            this.tabControl1.Controls.Add(this.leysha_tabPage);
            this.tabControl1.Controls.Add(this.galeb_tabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1074, 487);
            this.tabControl1.TabIndex = 1;
            // 
            // emem_tabPage
            // 
            this.emem_tabPage.Controls.Add(this.skillEditorEmem);
            this.emem_tabPage.Location = new System.Drawing.Point(4, 29);
            this.emem_tabPage.Name = "emem_tabPage";
            this.emem_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.emem_tabPage.Size = new System.Drawing.Size(1066, 454);
            this.emem_tabPage.TabIndex = 0;
            this.emem_tabPage.Text = "Emem";
            this.emem_tabPage.UseVisualStyleBackColor = true;
            // 
            // skillEditorEmem
            // 
            this.skillEditorEmem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillEditorEmem.Location = new System.Drawing.Point(3, 3);
            this.skillEditorEmem.Name = "skillEditorEmem";
            this.skillEditorEmem.Size = new System.Drawing.Size(1060, 448);
            this.skillEditorEmem.TabIndex = 0;
            // 
            // leysha_tabPage
            // 
            this.leysha_tabPage.Controls.Add(this.skillEditorLeysha);
            this.leysha_tabPage.Location = new System.Drawing.Point(4, 29);
            this.leysha_tabPage.Name = "leysha_tabPage";
            this.leysha_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.leysha_tabPage.Size = new System.Drawing.Size(1066, 454);
            this.leysha_tabPage.TabIndex = 1;
            this.leysha_tabPage.Text = "Leysha";
            this.leysha_tabPage.UseVisualStyleBackColor = true;
            // 
            // skillEditorLeysha
            // 
            this.skillEditorLeysha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillEditorLeysha.Location = new System.Drawing.Point(3, 3);
            this.skillEditorLeysha.Name = "skillEditorLeysha";
            this.skillEditorLeysha.Size = new System.Drawing.Size(1060, 448);
            this.skillEditorLeysha.TabIndex = 0;
            // 
            // galeb_tabPage
            // 
            this.galeb_tabPage.Controls.Add(this.skillEditorGaleb);
            this.galeb_tabPage.Location = new System.Drawing.Point(4, 29);
            this.galeb_tabPage.Name = "galeb_tabPage";
            this.galeb_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.galeb_tabPage.Size = new System.Drawing.Size(1066, 454);
            this.galeb_tabPage.TabIndex = 2;
            this.galeb_tabPage.Text = "Galeb";
            this.galeb_tabPage.UseVisualStyleBackColor = true;
            // 
            // skillEditorGaleb
            // 
            this.skillEditorGaleb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillEditorGaleb.Location = new System.Drawing.Point(3, 3);
            this.skillEditorGaleb.Name = "skillEditorGaleb";
            this.skillEditorGaleb.Size = new System.Drawing.Size(1060, 448);
            this.skillEditorGaleb.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.slotsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // slotsToolStripMenuItem
            // 
            this.slotsToolStripMenuItem.Name = "slotsToolStripMenuItem";
            this.slotsToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.slotsToolStripMenuItem.Text = "&Slots";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt + F4";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(30, 24);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SkillEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 515);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SkillEditorForm";
            this.Text = "[Savegame Editor] Vampire the Masquerade Swansong";
            this.tabControl1.ResumeLayout(false);
            this.emem_tabPage.ResumeLayout(false);
            this.leysha_tabPage.ResumeLayout(false);
            this.galeb_tabPage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TabControl tabControl1;
    private TabPage emem_tabPage;
    private TabPage leysha_tabPage;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripMenuItem slotsToolStripMenuItem;
    private ToolStripMenuItem toolStripMenuItem1;
    private TabPage galeb_tabPage;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private SkillEditor skillEditorEmem;
    private SkillEditor skillEditorLeysha;
    private SkillEditor skillEditorGaleb;
}