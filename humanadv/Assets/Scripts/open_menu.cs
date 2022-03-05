using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_menu : MonoBehaviour
{
    public GameObject gb;
    bool tf;

    void Update()
    {
        tf = Input.GetKey(KeyCode.Z);
        if (tf)
        {
            gb.SetActive(true);
        }
    }


}
