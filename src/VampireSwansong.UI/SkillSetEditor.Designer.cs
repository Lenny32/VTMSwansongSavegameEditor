namespace VampireSwansong.UI;

partial class SkillSetEditor
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
            this.rbZero = new VampireSwansong.UI.RadioButtonSkillControl();
            this.rbOne = new VampireSwansong.UI.RadioButtonSkillControl();
            this.rbTwo = new VampireSwansong.UI.RadioButtonSkillControl();
            this.rbThree = new VampireSwansong.UI.RadioButtonSkillControl();
            this.rbFour = new VampireSwansong.UI.RadioButtonSkillControl();
            this.rbFive = new VampireSwansong.UI.RadioButtonSkillControl();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbZero
            // 
            this.rbZero.AutoSize = true;
            this.rbZero.Checked = false;
            this.rbZero.Location = new System.Drawing.Point(111, 18);
            this.rbZero.Name = "rbZero";
            this.rbZero.Size = new System.Drawing.Size(20, 19);
            this.rbZero.TabIndex = 0;
            this.rbZero.Value = ((byte)(0));
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Checked = false;
            this.rbOne.Location = new System.Drawing.Point(137, 18);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(20, 19);
            this.rbOne.TabIndex = 1;
            this.rbOne.Value = ((byte)(1));
            // 
            // rbTwo
            // 
            this.rbTwo.AutoSize = true;
            this.rbTwo.Checked = false;
            this.rbTwo.Location = new System.Drawing.Point(163, 18);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(20, 19);
            this.rbTwo.TabIndex = 2;
            this.rbTwo.Value = ((byte)(2));
            // 
            // rbThree
            // 
            this.rbThree.AutoSize = true;
            this.rbThree.Checked = false;
            this.rbThree.Location = new System.Drawing.Point(189, 18);
            this.rbThree.Name = "rbThree";
            this.rbThree.Size = new System.Drawing.Size(20, 19);
            this.rbThree.TabIndex = 3;
            this.rbThree.Value = ((byte)(3));
            // 
            // rbFour
            // 
            this.rbFour.AutoSize = true;
            this.rbFour.Checked = false;
            this.rbFour.Location = new System.Drawing.Point(215, 18);
            this.rbFour.Name = "rbFour";
            this.rbFour.Size = new System.Drawing.Size(20, 19);
            this.rbFour.TabIndex = 4;
            this.rbFour.Value = ((byte)(4));
            // 
            // rbFive
            // 
            this.rbFive.AutoSize = true;
            this.rbFive.Checked = false;
            this.rbFive.Location = new System.Drawing.Point(241, 18);
            this.rbFive.Name = "rbFive";
            this.rbFive.Size = new System.Drawing.Size(20, 19);
            this.rbFive.TabIndex = 5;
            this.rbFive.Value = ((byte)(5));
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(3, 14);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(90, 23);
            this.lblText.TabIndex = 5;
            this.lblText.Text = "Skill Name";
            // 
            // SkillSetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbZero);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.rbFive);
            this.Controls.Add(this.rbFour);
            this.Controls.Add(this.rbThree);
            this.Controls.Add(this.rbTwo);
            this.Controls.Add(this.rbOne);
            this.Name = "SkillSetEditor";
            this.Size = new System.Drawing.Size(262, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private RadioButtonSkillControl rbZero;
    private RadioButtonSkillControl rbOne;
    private RadioButtonSkillControl rbTwo;
    private RadioButtonSkillControl rbThree;
    private RadioButtonSkillControl rbFour;
    private RadioButtonSkillControl rbFive;
    private Label lblText;
}
