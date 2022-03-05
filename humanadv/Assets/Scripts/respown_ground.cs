using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respown_ground : MonoBehaviour
{
    //転倒を検知してキー入力により体を起こす動作を行う関数
    public GameObject gb;
    private Vector3 pos;
    public bool isRespown = false;
    public GameObject gb0, gb1, gb2, gb3, gb4, gb5, gb6, gb7, gb8, gb9, gb10;   //人型モデルの全てのボーンを取得
    public Rigidbody rb0, rb1, rb2, rb3, rb4, rb5, rb6, rb7, rb8, rb9, rb10; 
    private Quaternion rot0, rot1, rot2, rot3, rot4, rot5, rot6, rot7, rot8, rot9, rot10;
    // Start is called before the first frame update
    void Start()
    {
        //各ボーンの初期状態を記憶させる変数を用意
        rot0 = gb0.transform.rotation;
        rot1 = gb1.transform.rotation;
        rot2 = gb2.transform.rotation;
        rot3 = gb3.transform.rotation;
        rot4 = gb4.transform.rotation;
        rot5 = gb5.transform.rotation;
        rot6 = gb6.transform.rotation;
        rot7 = gb7.transform.rotation;
        rot8 = gb8.transform.rotation;
        rot9 = gb9.transform.rotation;
        rot10 = gb10.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //キー入力を検知し、体を起こす
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isRespown)
            {
                gb.transform.Translate(0, 3, 0);
                isRespown = false;
                Invoke(nameof(Reset), 0.01f);

            }
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //頭部が接地しているとき、転倒状態であると判断する
        if (collision.gameObject.CompareTag("ground"))
        {
            isRespown = true;
        }
    }

    public void Reset()
    {
        //各ボーンを初期状態として記憶した状態に戻す関数
        gb0.transform.rotation = rot0;
        gb1.transform.rotation = rot1;
        gb2.transform.rotation = rot2;
        gb3.transform.rotation = rot3;
        gb4.transform.rotation = rot4;
        gb5.transform.rotation = rot5;
        gb6.transform.rotation = rot6;
        gb7.transform.rotation = rot7;
        gb8.transform.rotation = rot8;
        gb9.transform.rotation = rot9;
        gb10.transform.rotation = rot10;
        rb0.velocity = Vector3.zero;
        rb0.angularVelocity = Vector3.zero;
        rb1.velocity = Vector3.zero;
        rb1.angularVelocity = Vector3.zero;
        rb2.velocity = Vector3.zero;
        rb2.angularVelocity = Vector3.zero;
        rb3.velocity = Vector3.zero;
        rb3.angularVelocity = Vector3.zero;
        rb4.velocity = Vector3.zero;
        rb4.angularVelocity = Vector3.zero;
        rb5.velocity = Vector3.zero;
        rb5.angularVelocity = Vector3.zero;
        rb6.velocity = Vector3.zero;
        rb6.angularVelocity = Vector3.zero;
        rb7.velocity = Vector3.zero;
        rb7.angularVelocity = Vector3.zero;
        rb8.velocity = Vector3.zero;
        rb8.angularVelocity = Vector3.zero;
        rb9.velocity = Vector3.zero;
        rb9.angularVelocity = Vector3.zero;
        rb10.velocity = Vector3.zero;
        rb10.angularVelocity = Vector3.zero;
    }
}
