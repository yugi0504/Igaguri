using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControler : MonoBehaviour
{

    public void GameHome()
    {
        SceneManager.LoadScene("Start");
    }
    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameStart()
    {
        SceneManager.LoadScene("GameScreen");
    }
    public void GameResult()
    {
        SceneManager.LoadScene("Result");
    }
}
