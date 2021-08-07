using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;//加上 using System;
public class func_ : MonoBehaviour
{   //Func 為 delegate 進階版 不用在宣告delegate 因為已經飽含在 Func ，注意 : Func 放入的僅為 有回傳值之引數
    // Start is called before the first frame update

    //Func<   引數,回傳值 > ，沒規定引數多少  最後一個為回傳值
    public Func<int, bool, bool> Func1;
    public Func<bool, Product> Func2;
    
    void Start()
    {
        Func1 += A;
        bool get = Func1.Invoke(11, true);//得用回傳值類型接
        Debug.Log(get);
        //Func1 = null; 清除func
        Func2 += AddProduct;
        Product product_ = Func2(true);//接class
        product_.Dothing();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    bool A(int int_, bool Bool_) {

        if (Bool_ &&  int_>10)
        {

            return true;
        }
        else {
            return false;

        }
       
    }
    Product AddProduct(bool Bool) {
        if (Bool)
        {
            Debug.Log("Addproduct");
            return new Product();

        }
        else {

            return null;
        }

    }
    public class Product {


        public void Dothing() {
            Debug.Log("Use");

        }
    }
}
