using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSystem : MonoBehaviour
{
    //�V�[���̐؂�ւ����s���֐����܂Ƃ߂ċL�q
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
