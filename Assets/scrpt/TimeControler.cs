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
        //������
        time = 0.0f;
        //�Q�[���̍ĊJ
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //���Ԃ̉��Z
        time += Time.deltaTime;
        //�����̍X�V
        timer.GetComponent<TextMeshProUGUI>().text ="TimeLimit:"+ time.ToString("f2");
    }
}
