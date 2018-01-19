using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trial_script : MonoBehaviour {
    // Use this for initialization
    void Start()
    {
        GameObject j;
        GameObject k;

        int c = 0;
        int d = 0;

        j = GameObject.Find("p_tehuda");
        k = GameObject.Find("Scripts");


        j.GetComponent<player>().search_type(c);//カード　種類　探索　テスト
        j.GetComponent<player>().change_type(c, d);//カード種類切り替え　テスト
        j.GetComponent<player>().change_texture(c);//テクスチャ切り替え　テスト

        j.GetComponent<player>().search_flag(c);//カード　flag　探索　テスト
        j.GetComponent<player>().change_flag(c, 1);//カードflag切り替え　テスト

        k.GetComponent<rend_card>().rend_off(4);//描画　OFF　テスト

        k.GetComponent<rend_card>().rend_off(3);//
        k.GetComponent<rend_card>().rend_on(3);//描画　ON　テスト

    }

    // Update is called once per frame
    void Update()
    {

    }
}
