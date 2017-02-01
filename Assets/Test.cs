using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test: MonoBehaviour {

	// Use this for initialization
	void Start () {
        //要素数が5の、int型の配列arrayを宣言し好きな値で初期化する
        int[] array = { 30, 20, 50, 10, 80 };

        //配列の各要素を順番に表示する
        for (int i = 0; i < array.Length; i++) {
            Debug.Log(array[i]);

            //配列の各要素を逆順に表示する
            for (int h = 4; h > 0; h--) {
                Debug.Log(array[h]);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}