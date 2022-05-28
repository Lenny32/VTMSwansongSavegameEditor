namespace VampireSwansong.UI;

public delegate void ValueEventHandler(string sender, byte value);
public partial class SkillSetEditor : UserControl
{
    public event ValueEventHandler? ValueChanged;

    public virtual new bool Enabled { get => base.Enabled; set => Status(value); }

    private void Status(bool enabled)
    {
        foreach (var item in _radioButtons)
        {
            item.Checked = false;
            item.Enabled = enabled;
        }
        base.Enabled = enabled;
    }

    public string Title
    {
        get
        {
            return lblText.Text;
        }
        set
        {
            lblText.Text = value;
        }
    }
    private byte? _value = null;
    public byte? Value
    {
        get => _value;
        set
        {
            if (value == null)
            {
                Enabled = false;
                return;
            }

            Enabled = true;
            if (value < 0 || value > 5)
                return;
            
            _value = value;

            _ = _radioButtons.All(x => x.Checked = x.Value <= value.Value);
        }
    }

    private readonly RadioButtonSkill[] _radioButtons;

    public SkillSetEditor()
    {
        InitializeComponent();
        _radioButtons = new RadioButtonSkill[]
        {
            rbZero.Button, rbOne.Button, rbTwo.Button, rbThree.Button, rbFour.Button, rbFive.Button
        };

        rbZero.Button.CheckedChanged += CheckedChanged;
        rbOne.Button.CheckedChanged += CheckedChanged;
        rbTwo.Button.CheckedChanged += CheckedChanged;
        rbThree.Button.CheckedChanged += CheckedChanged;
        rbFour.Button.CheckedChanged += CheckedChanged;
        rbFive.Button.CheckedChanged += CheckedChanged;
    }

    private bool _locked = false;
    private readonly object _locker = new ();
    private void CheckedChanged(object? sender, EventArgs e)
    {
        lock (_locker)
        {
            if (_locked) return;
            if (_locked == false)
                _locked = true;
        }

        if (sender is not RadioButtonSkill rb) return;

        ValueChanged?.Invoke(Title, rb.Value);
        _locked = false;
    }
}
