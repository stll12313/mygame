using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSystem : MonoBehaviour
{
    //シーンの切り替えを行う関数をまとめて記述
    public void StartStage1()
    {
        SceneManager.LoadScene("stage1");
    }
    public void StartStage2()
    {
        SceneManager.LoadScene("stage2");
    }
    public void StartStage3()
    {
        SceneManager.LoadScene("stage3");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void goinst()
    {
        SceneManager.LoadScene("instruction");
    }
    public void Return()
    {
        SceneManager.LoadScene("title");
    }
}
