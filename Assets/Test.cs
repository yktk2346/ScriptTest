using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int mp = 53;      //魔力

    //mpを消費して魔法攻撃をする
    public void Magic(int fire) {

        //魔力の残りによって処理を変える
        if (mp > 5){
            //ifで残り魔力を確認してから、残り魔力を消費する
            this.mp -= fire;

            //mpが5以上だった場合の処理
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }else{
            //mpが5未満だった場合の処理
            Debug.Log("MPが足りないため魔法がつかえない。");
        }
    }
}


public class Test: MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Bossクラスを呼び出す
        Boss magboss = new Boss();

        //Magic関数を10回使った後、mpが5未満なら「"MPが足りないため魔法がつかえない"」と表示する
        for (int m = 0; m < 11; m++){
            //BossクラスのMagic関数に魔力の消費量を代入する(魔法攻撃用の関数を呼び出す)
            magboss.Magic(5);
        }






        //要素数が5の、int型の配列arrayを宣言し好きな値で初期化する
        int[] array = { 30, 20, 50, 10, 80 };

        //配列の各要素を順番に表示する
        for (int i = 0; i < array.Length; i++){
            Debug.Log(array[i]);
        }

            //配列の各要素を逆順に表示する
            for (int h = 4; h >= 0; h--) {
                Debug.Log(array[h]);
            }
        }
	
	// Update is called once per frame
	void Update () {
		
	}
}