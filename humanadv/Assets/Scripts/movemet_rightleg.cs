using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemet_rightleg : MonoBehaviour
{
    //�L�[���͂��擾���A�E���𓮂����֐�
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public float speed = 2;
    bool p, q;
    void Update()
    {
        p = Input.GetKey(KeyCode.E);
        q = Input.GetKey(KeyCode.Q);
    }

    private void FixedUpdate()
    {
        //�����𓯎��ɑO�ɏo�����Ƃ������悤�ɏ������L�q����
        if (p && !q)
        {
            this.transform.Translate(speed / 50, -speed/100, 0);
        }
    }
}
