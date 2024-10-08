using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeControler : MonoBehaviour
{
    
    float time;
    float timeLimit = 10.0f;

    GameObject timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer");
        //初期化
        time = 0.0f;
        //ゲームの再開
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //時間の加算
        time += Time.deltaTime;
        //文字の更新
        timer.GetComponent<TextMeshProUGUI>().text ="TimeLimit:"+ time.ToString("f2");
    }
}
