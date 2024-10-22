using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControler : MonoBehaviour
{
    public static SceneControler Instance {  get; private set; }
    public static void GameHome()
    {
        SceneManager.LoadScene("Start");
    }
    public static void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public static void GameStart()
    {
        SceneManager.LoadScene("GameScreen");
    }
    public static void GameResult()
    {
        SceneManager.LoadScene("Result");
    }
}
