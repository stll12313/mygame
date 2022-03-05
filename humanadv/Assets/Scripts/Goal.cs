using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //�S�[���������ǂ����𔻒肵�A���U���g��ʂ�\��������֐�
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
        //�S�[���𔻒肷��
        if (collider.gameObject.CompareTag("goal"))
        {
            isGoal = true;
        }
    }
}
