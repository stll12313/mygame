using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion_jump : MonoBehaviour
{
    //キー入力を取得し、ジャンプ処理を行う関数
    public Rigidbody rb;
    public float force = 50;
    private bool isGround;
    void Start()
    {
        
    }

    void Update()
    {
        if (isGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isGround = false;
                rb.AddForce(0, force, 0, ForceMode.Impulse);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //足が接地しているかの判定を行う
        if (collision.gameObject.CompareTag("ground"))
        {
            isGround = true;
        }
    }
}
