using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //ゴールしたかどうかを判定し、リザルト画面を表示させる関数
    public bool isGoal = false;
    public GameObject goalscene;
    void Update()
    {
        if(isGoal)
        {
            goalscene.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        //ゴールを判定する
        if (collider.gameObject.CompareTag("goal"))
        {
            isGoal = true;
        }
    }
}
