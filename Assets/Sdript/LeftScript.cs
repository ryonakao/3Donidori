﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeftScript : MonoBehaviour {

	public static int left;
	public static GameObject activeleft;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//ボタンおした時
	public void Left()
	{
		//プレイヤーが左にいく
		PlayerScript.migi = false;
		//このボタンを非表示に
		gameObject.SetActive (false);
		//右のボタンを表示させる
		RightScript.activeright.SetActive (true);

	}
}
