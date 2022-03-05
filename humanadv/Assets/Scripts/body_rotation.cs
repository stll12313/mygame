using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body_rotation : MonoBehaviour
{
    //キー入力を取得し、胴をひねる処理を行う関数
    public float rotate = 5;
    public GameObject gb;
    private Vector3 axis = Vector3.up; //回転軸の方向
    private Vector3 position; //回転の中心座標
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
