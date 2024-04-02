using UnityEngine;

[CreateAssetMenu(fileName = "MainSetting", menuName = "Main Setting", order = 51)]
public class MainSettings : ScriptableObject
{
    [Header("WORDS")]
    public int RepeatCount;
}
