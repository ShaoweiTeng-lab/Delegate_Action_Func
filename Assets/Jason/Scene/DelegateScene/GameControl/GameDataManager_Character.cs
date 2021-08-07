using UnityEngine;
using System.Collections;

public partial class GameDataManager
{
    public int CharA_Skill(int P, int R, int Y, int B)
    {
       
        return ((P + R) * 2) + Y + B;
    }

    public int CharB_Skill(int P, int R, int Y, int B)
    {
        return P + R + ((Y + B) * 2);
    }

 
}
public enum CharName
{
    Null,
    CharA,
    CharB
}
