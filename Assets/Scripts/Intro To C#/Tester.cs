using UnityEngine;
using System.Collections;

public class Tester : MonoBehaviour {

	int[] data;

	void Start () {
		data = dataValueFeed (data);
		for (int i = 0; i < data.Length; i++) {
			print (data [i]);
		}
	}

	int[] dataValueFeed(int[] data){
		data = new int[10];
		for (int i = 0; i < data.Length; i++) {
			data [i] = Random.Range (0, 100);
			}
		return data;
	}


	void Update () {
	
	}
}
