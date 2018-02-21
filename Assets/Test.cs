using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Test : MonoBehaviour {

	[DllImport("plugin")]
	private static extern int zzz();

	// Use this for initialization
	void Start () {
        int num = zzz();
        	Debug.Log(num);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
