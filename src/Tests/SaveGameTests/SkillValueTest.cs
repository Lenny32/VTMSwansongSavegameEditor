using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VampireSwansong.Editor.Types;

namespace SaveGameTests;

[TestClass]
public class SkillValueTest
{
    [TestMethod]
    public void SkillSetter_1_Success()
    {
        SkillValue a = new (1, 0);
        a.Value.Should().Be(1);
    }
    [TestMethod]
    public void SkillSetter_2_Success()
    {
        SkillValue a = new (2, 0);
        a.Value.Should().Be(2);
    }
    [TestMethod]
    public void SkillSetter_3_Success()
    {
        SkillValue a = new (3, 0);
        a.Value.Should().Be(3);
    }
    [TestMethod]
    public void SkillSetter_4_Success()
    {
        SkillValue a = new (4, 0);
        a.Value.Should().Be(4);
    }
    [TestMethod]
    public void SkillSetter_5_Success()
    {
        SkillValue a = new (5, 0);
        a.Value.Should().Be(5);
    }


    [TestMethod]
    public void SkillSetter_Throws_TooHigh()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new SkillValue(6, 0));
    }

    [TestMethod]
    public void SkillSetter_Throws_TooHigh_OnUpdate()
    {
        SkillValue a = new SkillValue(3, 0);
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => a.Value = 6);
    }

    [TestMethod]
    public void Skill_IsUpdated_False_Success()
    {
        SkillValue a = new (3, 0);
        a.IsDirty.Should().BeFalse();
    }

    [TestMethod]
    public void Skill_IsUpdated_True_Success()
    {
        SkillValue a = new (3, 0);
        a.Value = 5;
        a.IsDirty.Should().BeTrue();
    }
}