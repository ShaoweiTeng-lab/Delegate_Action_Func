using UnityEngine;
using System.Collections;

[System.Serializable]
public class PlayerModel
{    
    public CharName _CharName;

    public delegate int SkillDamageEvent(int P, int R, int Y, int B);
    public SkillDamageEvent Skill;
} 