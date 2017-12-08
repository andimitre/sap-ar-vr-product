using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class buscript : MonoBehaviour,IVirtualButtonEventHandler {

	private  GameObject DNA;


	// Use this for initializatio
	void Awake()
	{
		//DNA=transform.Find("DNA").gameObject;
		DNA = GameObject.Find ("Planet960Tris");

	}
	void Start () {
		DNA = GameObject.Find ("Planet960Tris");
		//DNA.SetActive (false);
		GameObject virtualButtonObject = GameObject.Find ("rotateButton");
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour> ();   //获取VirtualButton Behaviour组件
		for (int i = 0; i < vbs.Length; ++i) {     //遍历所有组件
			vbs [i].RegisterEventHandler (this);    //对该脚本进行注册
		}//
	}


	public void OnButtonPressed( VirtualButtonAbstractBehaviour vb ) { 
		Debug.Log ("=================== button pressed ======================"); 
		//DNA.SetActive (false);
		//DNA.transform.Rotate (new Vector3(2,Time.deltaTime * 60, 0));

	}
	public void OnButtonReleased( VirtualButtonAbstractBehaviour vb ) { 
		//DNA.SetActive (true);
		//DNA.transform.Rotate (new Vector3(2,Time.deltaTime * 60, 0));

		

	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
}
