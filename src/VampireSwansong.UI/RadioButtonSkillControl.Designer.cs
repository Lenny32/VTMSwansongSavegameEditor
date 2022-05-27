namespace VampireSwansong.UI;

partial class RadioButtonSkillControl
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
            this.components = new System.ComponentModel.Container();
            this.radioButton = new VampireSwansong.UI.RadioButtonSkill();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Location = new System.Drawing.Point(0, 0);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(17, 16);
            this.radioButton.TabIndex = 0;
            this.radioButton.TabStop = true;
            this.radioButton.UseMnemonic = false;
            this.radioButton.UseVisualStyleBackColor = true;
            this.radioButton.Value = ((byte)(0));
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipTitle = "Set Value to";
            // 
            // RadioButtonSkillControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButton);
            this.Name = "RadioButtonSkillControl";
            this.Size = new System.Drawing.Size(20, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private RadioButtonSkill radioButton;
    private ToolTip toolTip1;
}
