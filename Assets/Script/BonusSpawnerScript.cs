using UnityEngine;
using System.Collections;
using System;

public class BonusSpawnerScript : MonoBehaviour {
    public GameObject spawnLeft;
    public GameObject spawnRight;
    public GameObject coin3;
    public GameObject coin10;
    public GameObject cap100;
    public GameObject cap300;
    public GameObject coin1;
    public bool Dropnow;
    public int DropTypeCheck;
    bool firstdrop = true;
    public bool BonusTextActivate = false;
    void Start() {
    }
    void Update() {
        if (firstdrop == true) {
            //StartCoroutine(drop(10, 40));
            firstdrop = false;
            BonusTextActivate = false;
        }
    }
    //droptype おっきい方 300 小さい方1
    //Convert.ToInt32(var, 2);で２進数から１０進数
    public void InitBonusdrop(string droptype,int[] amount) {
        int num16 = Convert.ToInt32(droptype, 2);
        if (num16 / 16 == 1) {
            StartCoroutine (drop (3001,amount[0]));
            num16 -= 16;
        }
        if (num16 / 8 == 1) {
            StartCoroutine (drop (1001,amount[1]));
            num16 -= 8;
        }
        if (num16 / 4 == 1) {
            StartCoroutine( drop (100,amount[2]));
            num16 -= 4;
        }
        if (num16 / 2 == 1) {
            StartCoroutine(drop (30,amount[3]));
            num16 -= 2;
        }
        if (num16 / 1 == 1) {
            StartCoroutine(drop(10, amount[4]));
            num16 -= 1;
        }
    }
    //droptypeで落ちる奴決める コルーチンで
    //1桁目0 コイン 1桁目1 カプセル
     public IEnumerator drop(int droptype, int amount) {
        GameObject DropTyp;
        Dropnow = true;
        DropTyp = coin1;//なにか入れないとダメだから
        if (droptype == 10) {
            DropTyp = coin1;
        }
        if (droptype == 30) {
            DropTyp = coin3;
        }
        if (droptype == 100) {
            DropTyp = coin10;
        }
        if (droptype == 1001) {
            DropTyp = cap100;
        }
        if (droptype == 3001) {
            DropTyp = cap300;
        }
        for (int i = 0; i < amount; i++) {
            if (i % 2 == 0) {
                Instantiate(DropTyp, spawnLeft.transform.position, spawnLeft.transform.rotation);
                yield return new WaitForSeconds(0.1f);
            }
            else if (i%2==1){
                Instantiate(DropTyp, spawnRight.transform.position, spawnRight.transform.rotation);
                yield return new WaitForSeconds(0.1f);
            }
        }
        BonusTextActivate = true;
        Dropnow = false;
    }
}
