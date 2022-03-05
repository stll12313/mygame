using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_leftleg : MonoBehaviour
{
    //キー入力を取得し、左足を動かす関数
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
        //両足を同時に前に出すことが無いように条件を記述する
        if (p && !q)
        {
            this.transform.Translate(-speed / 50, -speed/100, 0);
        }
    }
}
