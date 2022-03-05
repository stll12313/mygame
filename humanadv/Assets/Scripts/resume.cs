using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resume : MonoBehaviour
{
    public GameObject gb;
    public void resume_game()
    {
        gb.SetActive(false);
    }
}
