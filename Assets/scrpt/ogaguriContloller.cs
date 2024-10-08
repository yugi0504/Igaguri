using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ogaguriContloller : MonoBehaviour
{
    private int point;
    GameObject pointObject;

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();

        // スコアの加算
           point += 10; // ポイントを加算
        
    }
    void Start()
    {
        point = 0;

        pointObject = GameObject.Find("Point");
        
        Application.targetFrameRate = 60;
        //Shoot(new Vector3(0, 200, 2000));
    }
    
    void Update()
    {
        pointObject.GetComponent<TextMeshProUGUI>().text = "POINT:" + point.ToString();
    }
}
