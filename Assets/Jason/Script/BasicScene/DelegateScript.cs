using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void SayHiEvent();
public delegate void say(int x);
public delegate int AtkDamageEvent(int atk, int def);
 
public class DelegateScript : MonoBehaviour {
    private SayHiEvent she;//放入的方法得與宣告的得一樣 (SayHiEvent();) 所以塞入的方法()內不放入參數
    private AtkDamageEvent ade;//放入的方法得與宣告的得一樣 (AtkDamageEvent(int atk, int def);) 所以塞入的回傳數(int atk, int def)內得放2參數
    public say sayxxd;
    void Start()
    {
        /*1.*/
        //she = OneEvent1;
        //ade = TwoEvent1;
        // = 直接取代以上方法
        //she = OneEvent2;
        //ade = TwoEvent2;

        /*2.*/
        she += OneEvent1;
        ade += TwoEvent1;       

       she += OneEvent2;
        ade += TwoEvent2;

       
        //sayxxd += ad;
        //sayxxd(10);

        //sayxxd += ad2;
        //sayxxd(10);//執行所有方法
        ///*-=一次只扣除一個*/
        //she -= OneEvent2;
        //ade -= TwoEvent2;

        she();
        //Debug.Log(ade(1, 2));//+= 警告 : 回傳只傳一次(最後一個的)
    }

    void OneEvent1() {
        Debug.Log("OneEvent1()");
    }

    void OneEvent2()
    {
        Debug.Log("OneEvent2()");
    }

    int TwoEvent1(int a, int b)
    {
        Debug.Log("TwoEvent1()");
        int ret = (a + b);
        return ret;
    }

    int TwoEvent2(int a1, int a2)
    {
        Debug.Log("TwoEvent2()");
        int ret = (a1 - a2);
        return ret;
    }
    void ad(int a) {

        Debug.Log(a);
    }
    void ad2(int a)
    {

        Debug.Log(a*a);
    }
}


