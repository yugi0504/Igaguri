using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public Camera MainCamera;
    public Camera EffectCamera;

    //変化させる瞬間
    public float transitionDuration = 2.0f;
    //カメラの初期値
    public Vector3 strtPosition = new Vector3(0, 1, 3);
    //カメラ終了地点
    public Vector3 endPosition =new Vector3 (0, 5, -10);

    public static bool isGameTimer=false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CameraTransition());
    }

    private IEnumerator CameraTransition()
    {
        MainCamera.enabled = false;
        EffectCamera.enabled = true;

        EffectCamera.transform.position = strtPosition;
        float elapsedTime = 0f;
        while (elapsedTime < transitionDuration)
        {
            EffectCamera.transform.position = Vector3.Lerp(strtPosition, endPosition, elapsedTime / transitionDuration);

            elapsedTime += Time.deltaTime;
            yield return null;
        }
        EffectCamera.enabled = false;
        MainCamera.enabled = true;

        isGameTimer = true;
    }

}
