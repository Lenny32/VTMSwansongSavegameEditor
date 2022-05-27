namespace VampireSwansong.UI;

partial class SkillEditor
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.skillSecurity = new VampireSwansong.UI.SkillSetEditor();
            this.skillPhysical = new VampireSwansong.UI.SkillSetEditor();
            this.skillSocial = new VampireSwansong.UI.SkillSetEditor();
            this.skillMental = new VampireSwansong.UI.SkillSetEditor();
            this.skillRhetoric = new VampireSwansong.UI.SkillSetEditor();
            this.skillTechnology = new VampireSwansong.UI.SkillSetEditor();
            this.skillEducation = new VampireSwansong.UI.SkillSetEditor();
            this.skillPersuasion = new VampireSwansong.UI.SkillSetEditor();
            this.skillPsychology = new VampireSwansong.UI.SkillSetEditor();
            this.lblTitleDialog = new System.Windows.Forms.Label();
            this.lblTitleExploration = new System.Windows.Forms.Label();
            this.skillIntimidation = new VampireSwansong.UI.SkillSetEditor();
            this.skillDeduction = new VampireSwansong.UI.SkillSetEditor();
            this.lblTitleKnowledge = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.skillSecurity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.skillPhysical, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.skillSocial, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.skillMental, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.skillRhetoric, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.skillTechnology, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.skillEducation, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.skillPersuasion, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.skillPsychology, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTitleDialog, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitleExploration, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.skillIntimidation, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.skillDeduction, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTitleKnowledge, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1033, 372);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // skillSecurity
            // 
            this.skillSecurity.Location = new System.Drawing.Point(347, 85);
            this.skillSecurity.Name = "skillSecurity";
            this.skillSecurity.Size = new System.Drawing.Size(321, 72);
            this.skillSecurity.TabIndex = 14;
            this.skillSecurity.Title = "Security";
            // 
            // skillPhysical
            // 
            this.skillPhysical.Location = new System.Drawing.Point(3, 3);
            this.skillPhysical.Name = "skillPhysical";
            this.skillPhysical.Size = new System.Drawing.Size(321, 38);
            this.skillPhysical.TabIndex = 0;
            this.skillPhysical.Title = "Physical";
            // 
            // skillSocial
            // 
            this.skillSocial.Location = new System.Drawing.Point(347, 3);
            this.skillSocial.Name = "skillSocial";
            this.skillSocial.Size = new System.Drawing.Size(321, 38);
            this.skillSocial.TabIndex = 1;
            this.skillSocial.Title = "Social";
            // 
            // skillMental
            // 
            this.skillMental.Location = new System.Drawing.Point(691, 3);
            this.skillMental.Name = "skillMental";
            this.skillMental.Size = new System.Drawing.Size(321, 38);
            this.skillMental.TabIndex = 2;
            this.skillMental.Title = "Mental";
            // 
            // skillRhetoric
            // 
            this.skillRhetoric.Location = new System.Drawing.Point(3, 85);
            this.skillRhetoric.Name = "skillRhetoric";
            this.skillRhetoric.Size = new System.Drawing.Size(321, 72);
            this.skillRhetoric.TabIndex = 3;
            this.skillRhetoric.Title = "Rhetoric";
            // 
            // skillTechnology
            // 
            this.skillTechnology.Location = new System.Drawing.Point(347, 163);
            this.skillTechnology.Name = "skillTechnology";
            this.skillTechnology.Size = new System.Drawing.Size(321, 72);
            this.skillTechnology.TabIndex = 7;
            this.skillTechnology.Title = "Technology";
            // 
            // skillEducation
            // 
            this.skillEducation.Location = new System.Drawing.Point(691, 163);
            this.skillEducation.Name = "skillEducation";
            this.skillEducation.Size = new System.Drawing.Size(321, 72);
            this.skillEducation.TabIndex = 8;
            this.skillEducation.Title = "Education";
            // 
            // skillPersuasion
            // 
            this.skillPersuasion.Location = new System.Drawing.Point(3, 241);
            this.skillPersuasion.Name = "skillPersuasion";
            this.skillPersuasion.Size = new System.Drawing.Size(321, 72);
            this.skillPersuasion.TabIndex = 9;
            this.skillPersuasion.Title = "Persuasion";
            // 
            // skillPsychology
            // 
            this.skillPsychology.Location = new System.Drawing.Point(3, 319);
            this.skillPsychology.Name = "skillPsychology";
            this.skillPsychology.Size = new System.Drawing.Size(321, 72);
            this.skillPsychology.TabIndex = 10;
            this.skillPsychology.Title = "Psychology";
            // 
            // lblTitleDialog
            // 
            this.lblTitleDialog.AutoSize = true;
            this.lblTitleDialog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleDialog.Location = new System.Drawing.Point(3, 54);
            this.lblTitleDialog.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTitleDialog.Name = "lblTitleDialog";
            this.lblTitleDialog.Size = new System.Drawing.Size(70, 28);
            this.lblTitleDialog.TabIndex = 11;
            this.lblTitleDialog.Text = "Dialog";
            // 
            // lblTitleExploration
            // 
            this.lblTitleExploration.AutoSize = true;
            this.lblTitleExploration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleExploration.Location = new System.Drawing.Point(347, 54);
            this.lblTitleExploration.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTitleExploration.Name = "lblTitleExploration";
            this.lblTitleExploration.Size = new System.Drawing.Size(112, 28);
            this.lblTitleExploration.TabIndex = 12;
            this.lblTitleExploration.Text = "Exploration";
            // 
            // skillIntimidation
            // 
            this.skillIntimidation.Location = new System.Drawing.Point(3, 163);
            this.skillIntimidation.Name = "skillIntimidation";
            this.skillIntimidation.Size = new System.Drawing.Size(321, 72);
            this.skillIntimidation.TabIndex = 4;
            this.skillIntimidation.Title = "Intimidation";
            // 
            // skillDeduction
            // 
            this.skillDeduction.Location = new System.Drawing.Point(691, 85);
            this.skillDeduction.Name = "skillDeduction";
            this.skillDeduction.Size = new System.Drawing.Size(321, 72);
            this.skillDeduction.TabIndex = 5;
            this.skillDeduction.Title = "Deduction";
            // 
            // lblTitleKnowledge
            // 
            this.lblTitleKnowledge.AutoSize = true;
            this.lblTitleKnowledge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleKnowledge.Location = new System.Drawing.Point(691, 54);
            this.lblTitleKnowledge.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTitleKnowledge.Name = "lblTitleKnowledge";
            this.lblTitleKnowledge.Size = new System.Drawing.Size(110, 28);
            this.lblTitleKnowledge.TabIndex = 13;
            this.lblTitleKnowledge.Text = "Knowledge";
            // 
            // SkillEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SkillEditor";
            this.Size = new System.Drawing.Size(1033, 372);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private SkillSetEditor skillPhysical;
    private SkillSetEditor skillSocial;
    private SkillSetEditor skillMental;
    private SkillSetEditor skillRhetoric;
    private SkillSetEditor skillIntimidation;
    private SkillSetEditor skillDeduction;
    private SkillSetEditor skillTechnology;
    private SkillSetEditor skillEducation;
    private SkillSetEditor skillPersuasion;
    private SkillSetEditor skillPsychology;
    private Label lblTitleDialog;
    private Label lblTitleExploration;
    private Label lblTitleKnowledge;
    private SkillSetEditor skillSecurity;
}
