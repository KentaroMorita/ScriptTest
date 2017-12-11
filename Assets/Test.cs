using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int[] array = {1,2,3,4,5};

		int i;
		for (i = 0; i < array.Length; i++) {	//配列arrayを順番に表示
			Debug.Log (array [i]);
		}

		for (i = 0; i < array.Length; i++) {	//配列arrayを逆順に表示
			Debug.Log (array [array.Length-1 - i]);
		}


		//--------発展課題------------
		boss mob = new boss();
		for (i = 0; i < 11; i++) {		//mobが魔法を11回使う
			Debug.Log (i + 1 + "回目の魔法");
			mob.Magic();
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class boss{
	private int hp = 100;
	private int mp = 53;
	private int power = 25;


	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}

	public void Magic(){	//魔法攻撃をするMagic関数
		if (this.mp > 5) {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp);

		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}
