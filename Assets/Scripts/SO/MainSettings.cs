using System;
using UnityEngine;

[CreateAssetMenu(fileName = "MainSetting", menuName = "Main Setting", order = 51)]
public class MainSettings : ScriptableObject
{
    [Header("WORDS")]
    [SerializeField] private int _repeatCount;
    [SerializeField] private byte _revertChance;

    public int RepeatCount
    {
        get => _repeatCount;
        set => _repeatCount = value >= 0 ? value : 0;
    }

    public byte RevertChance
    {
        get => _revertChance;
        set => _revertChance = Math.Clamp(value, (byte)0, (byte)10);
    }
}
