using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respown_fall : MonoBehaviour
{
    //���鍂���܂ŗ��������ہA�����ʒu�Ƀ��X�|�[�������鏈�����s���֐�
    private Vector3 rpos, npos;
    public GameObject gb, gb1, gb2; //�{�[���̒��ōł������ʒu�ɂ���{�[��3���擾
    void Start()
    {
        //�����ʒu���擾
        rpos = new Vector3(this.transform.position.x, this.transform.position.y+5, this.transform.position.z);
    }

    void Update()
    {
        //���݈ʒu��y���W��-20�ȉ��ɂȂ������_�ŁA�擾����3�̃{�[���������ʒu�̐^��Ɉړ�������
        npos = this.gameObject.transform.position;
        if(npos.y <= -20)
        {
            
            gb.transform.position = rpos;
            gb1.transform.position = rpos;
            gb2.transform.position = rpos;
        }
    }
}
