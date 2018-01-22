using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rend_card : MonoBehaviour {

    public GameObject[] h_obj = new GameObject[10];　//プレイヤーの手札：1~5　エネミーの手札：6~10　のオブジェクト

    // Use this for initialization
    public void rend_on(int c) //描画　ON　変数ｃ：手札の配列番号
    {
        //カードオブジェクトから表、裏の子オブジェクトにアクセスし、描画を有効化している
        h_obj[c].gameObject.transform.Find("omote").gameObject.GetComponent<Renderer>().enabled = true;
        h_obj[c].gameObject.transform.Find("ura").gameObject.GetComponent<Renderer>().enabled = true;
    }

    public void rend_off(int c) //描画　OFF　変数ｃ：手札の配列番号
    {
        //カードオブジェクトから表、裏の子オブジェクトにアクセスし、描画を無効化している
        h_obj[c].gameObject.transform.Find("omote").gameObject.GetComponent<Renderer>().enabled = false;
        h_obj[c].gameObject.transform.Find("ura").gameObject.GetComponent<Renderer>().enabled = false;
    }

}
