using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;//加上 using System;
//Action 為 delegate 進階版 不用在宣告delegate 因為已經飽含在Action ，注意 : Action 放入的僅為 無回傳值 的方法
public class Action_ : MonoBehaviour
{
    public static Action action  ;//不一定用static ，static是全部腳本都放得進方法
     
    public Action<int> action2;//Action 制定放入的方法
    jason__ jason =new jason__();
    // Start is called before the first frame update
    void Start()
    {
        jason.addaaction();//外部放入方法 ，先放先執行

        action += SendMessage;
        action (); 
        action = null;//清除所有方法

        action?.Invoke();//? 判斷此委派的空引用 
        // action?.Invoke(); 
        //跟此判斷 一樣
        if (action != null)
            action.Invoke();

        action2 += SendMessage2;
        action2 (10);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SendMessage() {

        Debug.Log("SendMenage");

    }
    public  void SendMessage2(int a)
    {

        Debug.Log("SendMenage_2  : " +a);

    }
  
}
class jason__
{

    public void addaaction()
    {


        Action_.action += a;


    }
    public void a()
    {

        Debug.Log("Hellow Im jason");
    }

}

