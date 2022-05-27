using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.IO.Abstractions;
using System.IO.Abstractions.TestingHelpers;
using VampireSwansong.Editor;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using System;

namespace SaveGameTests;

[TestClass]
public class SaveGameTest
{
    [TestMethod]
    public void FileName_Regex_Success()
    {
        string[] fileNames = new[] {
            "Slot1.sav",
            "Slot1_Endgame.sav",
            "Slot1_Narrative.SC02.sav",
            "Slot1_Narrative.SC03.sav",
            "Slot1_Narrative.SC04.sav",
            "Slot1_Narrative.SC05.sav",
            "Slot1_Narrative.SC06.sav",
            "Slot1_Narrative.SC07.sav",
            "Slot1_Narrative.SC08.sav",
            "Slot1_Narrative.SC09.P1.sav",
            "Slot1_Narrative.SC09.P2.sav",
            "Slot1_Narrative.SC09.P3.sav",
            "Slot1_Narrative.SC10.Phase1.sav",
            "Slot1_Narrative.SC10.Phase2.sav",
            "Slot1_Narrative.SC10.Phase3.sav",
            "Slot1_Narrative.SC11.Enem1.sav",
            "Slot1_Narrative.SC11.Enem2.sav",
            "Slot1_Narrative.SC11.Enem3.sav",
            "Slot1_Narrative.SC12.sav",


            "Slot2_Endgame.sav",
            "Slot2_Narrative.SC02.sav",
            "Slot2_Narrative.SC03.sav",
            "Slot2_Narrative.SC04.sav",
            "Slot2_Narrative.SC05.sav",
            "Slot2_Narrative.SC06.sav",
            "Slot2_Narrative.SC07.sav",
            "Slot2_Narrative.SC08.sav",
            "Slot2_Narrative.SC09.P1.sav",
            "Slot2_Narrative.SC09.P2.sav",
            "Slot2_Narrative.SC09.P3.sav",
            "Slot2_Narrative.SC10.Phase1.sav",
            "Slot2_Narrative.SC10.Phase2.sav",
            "Slot2_Narrative.SC10.Phase3.sav",
            "Slot2_Narrative.SC11.Enem1.sav",
            "Slot2_Narrative.SC11.Enem2.sav",
            "Slot2_Narrative.SC11.Enem3.sav",
            "Slot2_Narrative.SC12.sav",
            
            "Slot3_Endgame.sav",
            "Slot3_Narrative.SC02.sav",
            "Slot3_Narrative.SC03.sav",
            "Slot3_Narrative.SC04.sav",
            "Slot3_Narrative.SC05.sav",
            "Slot3_Narrative.SC06.sav",
            "Slot3_Narrative.SC07.sav",
            "Slot3_Narrative.SC08.sav",
            "Slot3_Narrative.SC09.P1.sav",
            "Slot3_Narrative.SC09.P2.sav",
            "Slot3_Narrative.SC09.P3.sav",
            "Slot3_Narrative.SC10.Phase1.sav",
            "Slot3_Narrative.SC10.Phase2.sav",
            "Slot3_Narrative.SC10.Phase3.sav",
            "Slot3_Narrative.SC11.Enem1.sav",
            "Slot3_Narrative.SC11.Enem2.sav",
            "Slot3_Narrative.SC11.Enem3.sav",
            "Slot3_Narrative.SC12.sav"
        };


        foreach (var fileName in fileNames)
        {
            fileName.Should().MatchRegex(SaveGame.ValidFileNameRegex, Exactly.Once());
        }
    }    


    [TestMethod]
    public void Load_Single_Success()
    {
        string baseDirectory = $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Vampire\\Saved\\SaveGames";
        IFileSystem fileSystem;

        fileSystem = new MockFileSystem();
        fileSystem.Directory.CreateDirectory(baseDirectory);

        string[] files = new[] {
            "Slot1_Endgame.sav",
            "Slot1_Narrative.SC02.sav",
            "Slot1_Narrative.SC03.sav",
            "Slot1_Narrative.SC04.sav",
            "Slot1_Narrative.SC05.sav",
            "Slot1_Narrative.SC06.sav",
            "Slot1_Narrative.SC07.sav",
            "Slot1_Narrative.SC08.sav",
            "Slot1_Narrative.SC09.P1.sav",
            "Slot1_Narrative.SC09.P2.sav",
            "Slot1_Narrative.SC09.P3.sav",
            "Slot1_Narrative.SC10.Phase1.sav",
            "Slot1_Narrative.SC10.Phase2.sav",
            "Slot1_Narrative.SC10.Phase3.sav",
            "Slot1_Narrative.SC11.Enem1.sav",
            "Slot1_Narrative.SC11.Enem2.sav",
            "Slot1_Narrative.SC11.Enem3.sav",
            "Slot1_Narrative.SC12.sav",
        };

        foreach (var file in files)
        {
            fileSystem.File.Create(Path.Combine(baseDirectory, file)).Dispose();
        }

        var saveGame = new SaveGame(fileSystem);

        saveGame.Load();

        saveGame.Slots.Should().ContainSingle();
        saveGame.Slots.Should().ContainKey(1);

        saveGame.Slots.Should().BeEquivalentTo(new Dictionary<int, string[]>() {
            { 1, files }
        });

    }

    [TestMethod]
    public void Load_Two_Success()
    {
        string baseDirectory = $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Vampire\\Saved\\SaveGames";
        IFileSystem fileSystem;

        fileSystem = new MockFileSystem();
        fileSystem.Directory.CreateDirectory(baseDirectory);


        string[] files = new[] {
            "Slot{0}_Endgame.sav",
            "Slot{0}_Narrative.SC02.sav",
            "Slot{0}_Narrative.SC03.sav",
            "Slot{0}_Narrative.SC04.sav",
            "Slot{0}_Narrative.SC05.sav",
            "Slot{0}_Narrative.SC06.sav",
            "Slot{0}_Narrative.SC07.sav",
            "Slot{0}_Narrative.SC08.sav",
            "Slot{0}_Narrative.SC09.P1.sav",
            "Slot{0}_Narrative.SC09.P2.sav",
            "Slot{0}_Narrative.SC09.P3.sav",
            "Slot{0}_Narrative.SC10.Phase1.sav",
            "Slot{0}_Narrative.SC10.Phase2.sav",
            "Slot{0}_Narrative.SC10.Phase3.sav",
            "Slot{0}_Narrative.SC11.Enem1.sav",
            "Slot{0}_Narrative.SC11.Enem2.sav",
            "Slot{0}_Narrative.SC11.Enem3.sav",
            "Slot{0}_Narrative.SC12.sav"
        };

        //Create and init the basic reference test
        IDictionary<int, List<string>> saves = new Dictionary<int, List<string>>() { { 1, new() }, { 2, new() } };

        foreach (var slot in new int[] { 1, 2 })
        {
            foreach (var file in files)
            {
                var filename = string.Format(file, slot);
                fileSystem.File.Create(Path.Combine(baseDirectory, filename)).Dispose();
                saves[slot].Add(filename);
            }            
        }




        var saveGame = new SaveGame(fileSystem);

        saveGame.Load();

        saveGame.Slots.Should().ContainKeys(1, 2);
        saveGame.Slots.Should().BeEquivalentTo(saves);
    }

    [TestMethod]
    public void ReadCurrentSlotNumber_Sucess()
    {
        string baseDirectory = $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Vampire\\Saved\\SaveGames";
        IFileSystem fileSystem;

        var beginingOfFile = new byte[] { 0x04, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x53, 0x6C, 0x6F, 0x74, 0x33, 0x5F, 0x4E, 0x61, 0x72, 0x72, 0x61, 0x74, 0x69, 0x76, 0x65, 0x2E, 0x53, 0x43, 0x30, 0x31, 0x00, 0x30, 0x61, 0x34, 0x80, 0x9E, 0x3D, 0xDA, 0x08, 0x0E, 0x00, 0x00, 0x00, 0x53, 0x43, 0x30, 0x31, 0x5F, 0x50, 0x72, 0x69, 0x6E, 0x63, 0x65, 0x5F, 0x50, 0x00, 0x1B, 0x00, 0x00, 0x00, 0x33, 0x4F, 0x75, 0x74, 0x66, 0x69, 0x74, 0x73, 0x4D, 0x61, 0x77, 0x6C, 0x61, 0x41, 0x72, 0x74, 0x69, 0x66, 0x61, 0x63, 0x74, 0x73, 0x50, 0x61, 0x63, 0x6B };

        string filename = "Slot3.sav";

        fileSystem = new MockFileSystem(new Dictionary<string, MockFileData>()
        {
            { filename, new MockFileData(beginingOfFile) }    
        }, baseDirectory);
        fileSystem.Directory.CreateDirectory(baseDirectory);

        var saveGame = new SaveGame(fileSystem);
        var slotnumber = saveGame.ReadSlotNumber(filename);


        Assert.AreEqual(3, slotnumber);
    }

    [TestMethod]
    public void WriteCurrentSlotNumber_Sucess()
    {
        string baseDirectory = $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Vampire\\Saved\\SaveGames";
        IFileSystem fileSystem;

        var beginingOfFile = new byte[] { 0x04, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x53, 0x6C, 0x6F, 0x74, 0x33, 0x5F, 0x4E, 0x61, 0x72, 0x72, 0x61, 0x74, 0x69, 0x76, 0x65, 0x2E, 0x53, 0x43, 0x30, 0x31, 0x00, 0x30, 0x61, 0x34, 0x80, 0x9E, 0x3D, 0xDA, 0x08, 0x0E, 0x00, 0x00, 0x00, 0x53, 0x43, 0x30, 0x31, 0x5F, 0x50, 0x72, 0x69, 0x6E, 0x63, 0x65, 0x5F, 0x50, 0x00, 0x1B, 0x00, 0x00, 0x00, 0x33, 0x4F, 0x75, 0x74, 0x66, 0x69, 0x74, 0x73, 0x4D, 0x61, 0x77, 0x6C, 0x61, 0x41, 0x72, 0x74, 0x69, 0x66, 0x61, 0x63, 0x74, 0x73, 0x50, 0x61, 0x63, 0x6B };

        string filename = "Slot3.sav";

        fileSystem = new MockFileSystem(new Dictionary<string, MockFileData>()
        {
            { filename, new MockFileData(beginingOfFile) }
        }, baseDirectory);
        fileSystem.Directory.CreateDirectory(baseDirectory);

        var saveGame = new SaveGame(fileSystem);
        saveGame.ChangeSlotNumber(filename, 1);

        var file = fileSystem.Directory.EnumerateFiles(baseDirectory).FirstOrDefault();
        var data = fileSystem.File.ReadAllBytes(file);

        var c = (char)data[12];
        

        Assert.AreEqual('1', c);
    }


    [TestMethod]
    public void Duplicate_Slot_Sucess()
    {
        string baseDirectory = $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Vampire\\Saved\\SaveGames";
        IFileSystem fileSystem;

        var save3_sav = new byte[] { 0x04, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x53, 0x6C, 0x6F, 0x74, 0x33, 0x5F, 0x4E, 0x61, 0x72, 0x72, 0x61, 0x74, 0x69, 0x76, 0x65, 0x2E, 0x53, 0x43, 0x30, 0x31, 0x00, 0x30, 0x61, 0x34, 0x80, 0x9E, 0x3D, 0xDA, 0x08, 0x0E, 0x00, 0x00, 0x00, 0x53, 0x43, 0x30, 0x31, 0x5F, 0x50, 0x72, 0x69, 0x6E, 0x63, 0x65, 0x5F, 0x50, 0x00, 0x1B, 0x00, 0x00, 0x00, 0x33, 0x4F, 0x75, 0x74, 0x66, 0x69, 0x74, 0x73, 0x4D, 0x61, 0x77, 0x6C, 0x61, 0x41, 0x72, 0x74, 0x69, 0x66, 0x61, 0x63, 0x74, 0x73, 0x50, 0x61, 0x63, 0x6B };

        fileSystem = new MockFileSystem(new Dictionary<string, MockFileData>()
        {
            { "Slot3.sav", new MockFileData(save3_sav) }
        }, baseDirectory);
        
        fileSystem.Directory.CreateDirectory(baseDirectory);

        var saveGame = new SaveGame(fileSystem);
        saveGame.Load();
        saveGame.DuplicateSlot(3, 1);

        var file = fileSystem.Directory.EnumerateFiles(baseDirectory).FirstOrDefault(x=> x.Contains("Slot1.sav"));
        file.Should().NotBeNull();
        
        var data = fileSystem.File.ReadAllBytes(file);
        var c = (char)data[12];
        c.Should().Be('1');
    }
    
    [TestMethod]
    public void Duplicate_WithTwo_Slot_Sucess()
    {
        string baseDirectory = $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Vampire\\Saved\\SaveGames";
        IFileSystem fileSystem;

        var save3_sav = new byte[] { 0x04, 0x00, 0x00, 0x00, 0x15, 0x00, 0x00, 0x00, 0x53, 0x6C, 0x6F, 0x74, 0x33, 0x5F, 0x4E, 0x61, 0x72, 0x72, 0x61, 0x74, 0x69, 0x76, 0x65, 0x2E, 0x53, 0x43, 0x30, 0x31, 0x00, 0x30, 0x61, 0x34, 0x80, 0x9E, 0x3D, 0xDA, 0x08, 0x0E, 0x00, 0x00, 0x00, 0x53, 0x43, 0x30, 0x31, 0x5F, 0x50, 0x72, 0x69, 0x6E, 0x63, 0x65, 0x5F, 0x50, 0x00, 0x1B, 0x00, 0x00, 0x00, 0x33, 0x4F, 0x75, 0x74, 0x66, 0x69, 0x74, 0x73, 0x4D, 0x61, 0x77, 0x6C, 0x61, 0x41, 0x72, 0x74, 0x69, 0x66, 0x61, 0x63, 0x74, 0x73, 0x50, 0x61, 0x63, 0x6B };
        var Slot3_Narrative_SC01_sav = new byte[] { 0x04, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x00, 0x53, 0x6C, 0x6F, 0x74, 0x33, 0x00, 0xD0, 0xB1, 0x9A, 0xBE, 0x9F, 0x3D, 0xDA, 0x08, 0x0E, 0x00, 0x00, 0x00, 0x53, 0x43, 0x30, 0x31, 0x5F, 0x50, 0x72, 0x69, 0x6E, 0x63, 0x65, 0x5F, 0x50, 0x00, 0x1B, 0x00, 0x00, 0x00, 0x33, 0x4F, 0x75, 0x74, 0x66, 0x69, 0x74, 0x73, 0x4D, 0x61, 0x77, 0x6C, 0x61, 0x41, 0x72, 0x74, 0x69, 0x66, 0x61, 0x63, 0x74, 0x73, 0x50, 0x61, 0x63, 0x6B };

        fileSystem = new MockFileSystem(new Dictionary<string, MockFileData>()
        {
            { "Slot3.sav", new MockFileData(save3_sav) },
            { "Slot3_Narrative.SC01.sav", new MockFileData(Slot3_Narrative_SC01_sav) }
        }, baseDirectory);

        fileSystem.Directory.CreateDirectory(baseDirectory);

        var saveGame = new SaveGame(fileSystem);
        saveGame.Load();
        saveGame.DuplicateSlot(3, 1);


        /////////////
        var file = fileSystem.Directory.EnumerateFiles(baseDirectory).FirstOrDefault(x => x.Contains("Slot1.sav"));
        file.Should().NotBeNull();

        var data = fileSystem.File.ReadAllBytes(file);
        var c = (char)data[12];
        c.Should().Be('1');

        /////////////
        file = fileSystem.Directory.EnumerateFiles(baseDirectory).FirstOrDefault(x => x.Contains("Slot1_Narrative.SC01.sav"));
        file.Should().NotBeNull();

        data = fileSystem.File.ReadAllBytes(file);
        c = (char)data[12];
        c.Should().Be('1');
    }    
}
