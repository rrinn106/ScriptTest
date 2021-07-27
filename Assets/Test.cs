using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;  

    public void Magic()
    {
        if(mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }     

    }

}

public class Test : MonoBehaviour
{
    void Start()
    {

        int[] array = { 10, 20, 30, 40, 50, 60 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length - 1; 0 <= i; i--)
        {
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic(); // 関数を呼び出す
        }

    }

void Update()
    {
        
    }

}


