using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.UI;
public class lamda : MonoBehaviour
//https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/operators/lambda-expressions
{   //任何 Lambda 運算式可轉換成委派型別。 Lambda 運算式可以轉換成的委派型別，是由其參數和傳回值的型別所定義。 如果 Lambda 運算式不會傳回值，則其可轉換成其中一個 Action 委派型別；否則可轉換成其中一個 Func 委派型別。 
    //優點 不用在寫void 呼叫,在{} 完成
    //沒有傳入參數時用空括號()表示
    /*
        只有一個參數時可以不用括號，複數個參數都要加上括號
        可以不用明確指定型別
        可以明確指定型別，明確指定型別時一定要加上括號
        沒有傳入參數時用空括號()表示 
        
        非委派型別不可加入{}
    */
    // Start is called before the first frame update
    //可放在未執行區域 定義內容
    Func<int, int, int> func__ = (a, b) => { return a * b; };
    List<int> lamdalist;
    Action<int> ActionLamada_ = xx => { Debug.Log("ActionLamada_ : " + xx); };
    Button btn;
    void Start()
    {   //(a ,b)代表 func 的輸入參數 ， 回傳 a+b
        //Func 版Lamada           (傳入值)=>{執行完內容  最後回傳值}
        Func<int, int, int> func = (a, b) => { return a + b; };
        int get = func(5, 10);
        Debug.Log("get : " + get);//15

        func = (a, b) => { return a * b; };
        int get2 = func(5, 10);
        Debug.Log("get2 :  " + get2);//50

        int get3 = func__(11, 5);
        Debug.Log("get3 :  " + get3);//55

        //Action 版Lamada           (傳入值(任變數名稱))=>{執行內容}
        Action<int> ActionLamada = (xx) => { Debug.Log("ActionLamada : " + xx); };
        ActionLamada += aa;
        ActionLamada(10);// ActionLamada : 10
        //Action 版Lamada     ()無傳入值 => {值型內容}
        Action ActionLamada00 = () => { Debug.Log("ActionLamada 00 "); };
        ActionLamada00();//ActionLamada 00

        ActionLamada_(15);//ActionLamada_ 15

        lamdalist = new List<int>() { 1, 2, 3 };

        lamdalist.ForEach(i => {
            Debug.Log("List [i] : " + i);

        });
        //onclick 本身就是 unity event 所以用addlistener可以定義  
        btn.onClick.AddListener(() => X1());
        //btn.onClick.AddListener(() => { Debug.Log("hellow world"); });
        // btn.onClick?.Invoke(); //? 判斷此event的空引用 
        //跟此判斷 一樣
        if (btn.onClick != null)
            btn.onClick.Invoke();

        X1();
        Debug.Log(GetReturnBool());
    }
    void aa(int x) {
        Debug.Log("aa : " + x);
    }
    # region    非委派型別
    // Update is called once per frame
    //不能放入大括弧
    void X1() => Debug.Log("Hellow World");
    # region 有return 類
    bool GetReturnBool() => 10 > 5;
    GameObject GetGameObject() => Instantiate(Resources.Load("Prefeb") as GameObject, Vector3.zero, Quaternion.identity);
    #endregion

    # region 沒有return 類
    int IntergerGet => 10 - 5;
    bool NotReturnBool => 10 > 5;
    #endregion
    #endregion
    //c# 9.0 後版本
    //Func<int, int, int> constant = (_, _) => 10; //error

}
