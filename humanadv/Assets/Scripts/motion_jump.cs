using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion_jump : MonoBehaviour
{
    //�L�[���͂��擾���A�W�����v�������s���֐�
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
        //�����ڒn���Ă��邩�̔�����s��
        if (collision.gameObject.CompareTag("ground"))
        {
            isGround = true;
        }
    }
}
