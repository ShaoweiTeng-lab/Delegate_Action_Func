using UnityEngine;
using System.Collections;

public partial class GameDataManager : MonoBehaviour
{
    public static GameDataManager inst;
    public PlayerModel _Player1 = new PlayerModel();
    public PlayerModel _Player2 = new PlayerModel();

    void Awake()
    {
        inst = this;
    }

    void Start ()
    {
        SelectEvent(_Player1, CharName.CharA);
        SelectEvent(_Player2, CharName.CharB);

        print("_Player1 : " + _Player1.Skill(1, 2, 3, 4));//13
        print("_Player2 : " + _Player2.Skill(1, 2, 3, 4));//17
    }

    void SelectEvent(PlayerModel _Player, CharName _CharName)
    {
        _Player._CharName = _CharName;

        switch (_CharName)
        {
            case CharName.CharA:
                _Player.Skill = CharA_Skill;
                break;
            case CharName.CharB:
                _Player.Skill = CharB_Skill;
                break;
            default:
                Debug.Log("_CharName找不到對應類型");
                break;
        }
    }
}


