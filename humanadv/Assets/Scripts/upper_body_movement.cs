using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upper_body_movement : MonoBehaviour
{
    //�L�[���͂ɂ�蓷�̕����̓����𐧌䂷��֐�
    void Start()
    {
        
    }
    public float speed = 2;
    bool front = false;
    bool back = false;
    void Update()
    {
        front = Input.GetKey(KeyCode.W);
        back = Input.GetKey(KeyCode.S);
    }

    void FixedUpdate()
    {
        
        if (front)
        {
            this.transform.Translate(speed/50, 0, 0);
        }
        if (back)
        {
            this.transform.Translate(-speed / 50, 0, 0);
        }
        
    }
}
