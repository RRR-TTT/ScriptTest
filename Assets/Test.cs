using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = { 1, 2, 3, 4, 5 };
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}
		for (int i = array.Length - 1; i >= 0; i--) {
			Debug.Log (array [i]);
		}
		Boss Burn = new Boss();

		for (int i = 0; i < 10; i++) {
			Burn.Magic ();
		}
		Burn.Magic ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Boss {
	int mp = 53;

	public void Magic(){
		if (mp - 5 < 0) {
			Debug.Log ("MPが足りないため魔法が使えない。");
		} else {
			mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");
		}
	}
}