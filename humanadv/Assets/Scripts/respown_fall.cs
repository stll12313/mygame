using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respown_fall : MonoBehaviour
{
    //ある高さまで落下した際、初期位置にリスポーンさせる処理を行う関数
    private Vector3 rpos, npos;
    public GameObject gb, gb1, gb2; //ボーンの中で最も高い位置にあるボーン3つを取得
    void Start()
    {
        //初期位置を取得
        rpos = new Vector3(this.transform.position.x, this.transform.position.y+5, this.transform.position.z);
    }

    void Update()
    {
        //現在位置のy座標が-20以下になった時点で、取得した3つのボーンを初期位置の真上に移動させる
        npos = this.gameObject.transform.position;
        if(npos.y <= -20)
        {
            
            gb.transform.position = rpos;
            gb1.transform.position = rpos;
            gb2.transform.position = rpos;
        }
    }
}
