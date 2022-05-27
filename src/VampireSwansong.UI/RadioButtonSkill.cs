namespace VampireSwansong.UI;

public class RadioButtonSkill : RadioButton
{
    public byte Value { get; set; }
    private bool _isChecked = false;
    protected override void OnClick(EventArgs e)
    {
        if (Checked && !_isChecked)
            Checked = false;
        else
        {
            Checked = true;
            _isChecked = false;
        }
        base.OnClick(e);
    }
}