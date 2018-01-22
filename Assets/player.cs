using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;


public class player : MonoBehaviour {

    int credit = 30; //単位数
    public card[] hand = new card[5]; //手札
    public GameObject[] h_obj = new GameObject[5]; //手札の3Dモデル　オブジェクト
    public Material[] h_mat = new Material[4];　//カードの柄の画像

    public int search_type(int c) { //カードの種類の情報を検索
        int a = hand[c].type; //カードの種類の情報を格納した戻り値
        return a;
    }

    public void change_type(int c, int d) { //カードの種類を変更する 
        //int c:変更させる手札の番号 int d:カードのtype番号 
        //場合によってはこの関数とマテリアルを張り替えるchangeを一緒の関数にしてもいいはず
        hand[c].type = d; //カードの種類の情報を変更する
    }

    public int search_flag(int c)　{ //カードの使用済みフラグの情報を検索
        int a = hand[c].flag; //カードの種類の情報を格納した戻り値
        return a;
    }

    public void change_flag(int c, int d) { //カードの使用済みフラグを変更する
        //場合によってはこの関数とマテリアルを張り替えるchangeを一緒の関数にしてもいいはず
        hand[c].flag = d; //カードの種類の情報を変更する
    }

    public void change_texture(int c) { //カードの種類の値に合わせてテクスチャを適用する
       
       if(hand[c].type == 0){
            h_obj[c].GetComponent<Renderer>().material = h_mat[0];
        }
        
       else if (hand[c].type == 1){
            h_obj[c].GetComponent<Renderer>().material = h_mat[1];
        }

       else if (hand[c].type == 2){
            h_obj[c].GetComponent<Renderer>().material = h_mat[2];
        }

       else if (hand[c].type == 3){
            h_obj[c].GetComponent<Renderer>().material = h_mat[3];
        }
    }

}
