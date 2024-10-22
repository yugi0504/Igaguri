using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultScore : MonoBehaviour
{
    public GameObject resultScore;
    
    void Update()
    {
        resultScore.GetComponent<TextMeshProUGUI>().text = "Score:" + ogaguriContloller.point.ToString();
    }
}
