using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_leftleg : MonoBehaviour
{
    //�L�[���͂��擾���A�����𓮂����֐�
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public float speed = 2;
    bool p, q;
    void Update()
    {
        p = Input.GetKey(KeyCode.Q);
        q = Input.GetKey(KeyCode.E);
    }

    private void FixedUpdate()
    {
        //�����𓯎��ɑO�ɏo�����Ƃ������悤�ɏ������L�q����
        if (p && !q)
        {
            this.transform.Translate(-speed / 50, -speed/100, 0);
        }
    }
}
