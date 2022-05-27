namespace VampireSwansong.UI;
public partial class RadioButtonSkillControl : UserControl
{
    public RadioButtonSkillControl()
    {
        InitializeComponent();
    }

    public RadioButtonSkill Button => radioButton;
    public byte Value { get => radioButton.Value; set => SetValue(value); }
    public bool Checked { get => radioButton.Checked; set => radioButton.Checked = value; }

    private void SetValue(byte value)
    {
        radioButton.Value = value;
        toolTip1.SetToolTip(this.radioButton, $"{value}");
    }
}
