using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Linq;
public class jason : MonoBehaviour
{
    Action <int >act=(x)=> { Debug.Log(x * 10); };
    Func<int, int> fnc = (x) => { return x ^ 2; };
    List<Player> allPlayer = new List<Player>();
    Player me  ;
    public Dictionary<String, Player> M_Dictionary;
    // Start is called before the first frame update
    void Start()
    {

        allPlayer = new List<Player>
        {
            new Player(15,"Jax"),
             new Player(11,"John"),
              new Player(17,"Eric")
        };
       // M_Dictionary = allPlayer.ToDictionary(playerdata => playerdata.Name );
        M_Dictionary = allPlayer.OrderBy(playerdata => playerdata.Health).ToDictionary(playerdata => playerdata.Name);
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public class Player {
        public int Health;
        public string Name;
        public Player(int Health, string Name) {

            this.Health = Health;
            this.Name = Name;

        }
        public int getHealth() {

            return 0;

        }
        public string getName()
        {

            return Name;

        }


    }
}
