using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PointControler : MonoBehaviour
{
    int point;

    GameObject pointObject;

    // Start is called before the first frame update
    void Start()
    {
        pointObject = GameObject.Find("Point");
        point = 0;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("igaguri"))
        {
            point += 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        pointObject.GetComponent<TextMeshProUGUI>().text = "POINT:" + point.ToString();
    }
}
