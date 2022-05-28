using System.IO.Abstractions;
using VampireSwansong.Editor;
using VampireSwansong.Editor.Constants;

namespace VampireSwansong.UI;
public partial class SkillEditorForm : Form
{
    public SkillEditorForm()
    {
        InitializeComponent();

        KeyDown += SkillEditorForm_KeyDown;
        skillEditorEmem.Enabled = false;
        skillEditorLeysha.Enabled = false;
        skillEditorGaleb.Enabled = false;
        saveToolStripMenuItem.Enabled = false;

        var savegame = new SaveGame(new FileSystem());
        savegame.Load();

        var slotList = new ToolStripMenuItem[savegame.Slots.Count];
        for (int i = 0; i < savegame.Slots.Count; i++)
        {
            var slot = savegame.Slots.ElementAt(i);
            slotList[i] = new ToolStripMenuItem()
            {
                Name = $"slot{slot.Key}ToolStripMenuItem",
                Size = new Size(126, 26),
                Text = $"Slot&{slot.Key}",
            };
        }
        slotsToolStripMenuItem.DropDownItems.AddRange(slotList);
    }

    
    private BasicSaveGame? _saveGame;
    private string? _filePath;
    private void SetSelectedSave(string filePath)
    {
        _filePath = filePath;
        var parser = new SaveGameParser(filePath);
        _saveGame = parser.Parse();
        if (_saveGame == null)
            return;

        skillEditorEmem.Reset();
        skillEditorLeysha.Reset();
        skillEditorGaleb.Reset();


        SetEditor(_saveGame, ConstantsPlayer.Emem, skillEditorEmem);
        SetEditor(_saveGame, ConstantsPlayer.Leysha, skillEditorLeysha);
        SetEditor(_saveGame, ConstantsPlayer.Galeb, skillEditorGaleb);

        this.skillEditorEmem.Enabled = true;
        this.skillEditorLeysha.Enabled = true;
        this.skillEditorGaleb.Enabled = true;
    }
    private static void SetEditor(BasicSaveGame saveGame, string name, SkillEditor skillEditor)
    {
        var player = saveGame.Characters.FirstOrDefault(x => x.Title == name);
        if (player == null)
            return;
        skillEditor.Skills.Physical = player.Skills.Physical?.Value;
        skillEditor.Skills.Social = player.Skills.Social?.Value;
        skillEditor.Skills.Mental = player.Skills.Mental?.Value;
        skillEditor.Skills.Rhetoric = player.Skills.Rhetoric?.Value;
        skillEditor.Skills.Intimidation = player.Skills.Intimidation?.Value;
        skillEditor.Skills.Persuasion = player.Skills.Persuasion?.Value;
        skillEditor.Skills.Psychology = player.Skills.Psychology?.Value;
        skillEditor.Skills.Security = player.Skills.Security?.Value;
        skillEditor.Skills.Technology = player.Skills.Technology?.Value;
        skillEditor.Skills.Deduction = player.Skills.Deduction?.Value;
        skillEditor.Skills.Education = player.Skills.Education?.Value;
        skillEditor.AllowValueChangeEvent(true);
    }

    private static void UpdateSavegameValues(BasicSaveGame saveGame, string name, SkillEditor skillEditor)
    {
        var player = saveGame.Characters.FirstOrDefault(x => x.Title == name);
        if (player == null)
            return;
        if(player.Skills.Physical != null && skillEditor.Skills.Physical.HasValue)
            player.Skills.Physical.Value = skillEditor.Skills.Physical.Value;
        if(player.Skills.Social != null && skillEditor.Skills.Social.HasValue)
            player.Skills.Social.Value = skillEditor.Skills.Social.Value;
        if (player.Skills.Mental != null && skillEditor.Skills.Mental.HasValue)
            player.Skills.Mental.Value = skillEditor.Skills.Mental.Value;
                
        if (player.Skills.Rhetoric != null && skillEditor.Skills.Rhetoric.HasValue)
            player.Skills.Rhetoric.Value = skillEditor.Skills.Rhetoric.Value;
        if (player.Skills.Intimidation != null && skillEditor.Skills.Intimidation.HasValue)
            player.Skills.Intimidation.Value = skillEditor.Skills.Intimidation.Value;
        if (player.Skills.Persuasion != null && skillEditor.Skills.Persuasion.HasValue)
            player.Skills.Persuasion.Value = skillEditor.Skills.Persuasion.Value;
        if (player.Skills.Psychology != null && skillEditor.Skills.Psychology.HasValue)
            player.Skills.Psychology.Value = skillEditor.Skills.Psychology.Value;
        
        if (player.Skills.Security != null && skillEditor.Skills.Security.HasValue)
            player.Skills.Security.Value = skillEditor.Skills.Security.Value;
        if (player.Skills.Technology != null && skillEditor.Skills.Technology.HasValue)
            player.Skills.Technology.Value = skillEditor.Skills.Technology.Value;
        
        if (player.Skills.Deduction != null && skillEditor.Skills.Deduction.HasValue)
            player.Skills.Deduction.Value = skillEditor.Skills.Deduction.Value;
        if (player.Skills.Education != null && skillEditor.Skills.Education.HasValue)
            player.Skills.Education.Value = skillEditor.Skills.Education.Value;
    }

    

    private void SkillEditorForm_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.S)
        {
            Save();
        }
        else if (e.Control && e.KeyCode == Keys.O)
        {
            OpenFileDialog();
        }
    }

    private void SaveToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        Save();
    }
    private void Save()
    {
        if (_saveGame != null && _filePath != null)
        {
            UpdateSavegameValues(_saveGame, ConstantsPlayer.Emem, skillEditorEmem);
            UpdateSavegameValues(_saveGame, ConstantsPlayer.Leysha, skillEditorLeysha);
            UpdateSavegameValues(_saveGame, ConstantsPlayer.Galeb, skillEditorGaleb);

            var data = _saveGame.Rebuild();
            File.WriteAllBytes(_filePath, data);
        }
    }


    private void OpenToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        OpenFileDialog();
    }

    private void OpenFileDialog()
    {
        skillEditorEmem.AllowValueChangeEvent(false);
        skillEditorLeysha.AllowValueChangeEvent(false);
        skillEditorGaleb.AllowValueChangeEvent(false);


        using OpenFileDialog openFileDialog = new();
        openFileDialog.InitialDirectory = SaveGame.DefaultSaveGamesPath;
        openFileDialog.Filter = "sav files (*.sav)|*.sav";
        openFileDialog.FilterIndex = 2;
        openFileDialog.RestoreDirectory = true;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            //Get the path of specified file
            string filePath = openFileDialog.FileName;
            SetSelectedSave(filePath);
            saveToolStripMenuItem.Enabled = true;
        }
    }



    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("I did this project for fun. Check it out ", "About");
    }
}
