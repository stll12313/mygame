using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body_rotation : MonoBehaviour
{
    //�L�[���͂��擾���A�����Ђ˂鏈�����s���֐�
    public float rotate = 5;
    public GameObject gb;
    private Vector3 axis = Vector3.up; //��]���̕���
    private Vector3 position; //��]�̒��S���W
    void Update()
    {
        position = gb.transform.position;
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            this.transform.RotateAround(position, axis, -rotate);
        }
        else if (Input.GetMouseButton(1))
        {
            this.transform.RotateAround(position, axis, rotate);
        }
    }
}
