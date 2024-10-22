using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PointControler : MonoBehaviour
{
    int point;
    int handledPoint;
    int handledCount;

    GameObject pointObject;

    // Start is called before the first frame update
    void Start()
    {
        pointObject = GameObject.Find("Point");
        point = 0;
        handledPoint = 100;
        handledCount = 1;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("igaguri"))
        {
            point += 10;
            if(point%handledPoint==handledCount )
            {
                point *= 3;
                handledCount++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        pointObject.GetComponent<TextMeshProUGUI>().text = "POINT:" + point.ToString();
    }
}
