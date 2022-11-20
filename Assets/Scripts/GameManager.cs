using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 使用 UI 物件，必須增加此處理程序

public class GameManager : MonoBehaviour
{
    GameObject car;              // 用來儲存汽車物件
    GameObject flag;             // 用來儲存旗子物件
    GameObject distance;         // 用來儲存UI文字距離物件
    GameObject score;            // 用來儲存UI文字分數物件

    void Start() // 將場景中的物件放到已宣告的各個物件中
    {
        car = GameObject.Find("car");         
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
        score = GameObject.Find("Score");
    }

    void Update()
    {
    
        // 計算旗子與汽車的距離
        float length = flag.transform.position.x - car.transform.position.x;
        // 將旗子與汽車的距離顯示在UI上面
        distance.GetComponent<Text>().text = "距離目標還有 " + length.ToString("F2") + "m";
        // 計算汽車的距離所得分數，超過旗子則0分
         float showscore = 100 / length;
         if (length >= 0)
        {
            // 將汽車的距離所得分數顯示在UI上面，小數點第0位
            score.GetComponent<Text>().text = "分數 " + showscore.ToString("F0") + "分";
        }
        else 
        {
            score.GetComponent<Text>().text = "分數 0 分";
        }

    
    }
}
