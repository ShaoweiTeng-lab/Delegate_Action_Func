using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
public class deleGatetest : MonoBehaviour
{
    public delegate_Test delegate_Test_;
    
    // Start is called before the first frame update
    void Start()
    {
        delegate_Test_ += PlayerAction;
        delegate_Test_.Invoke();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerAction()
    {

        Debug.Log("Player_hI");
    }
}

public delegate void delegate_Test();
