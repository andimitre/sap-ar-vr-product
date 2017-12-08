using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;



public class switchmath : MonoBehaviour,IVirtualButtonEventHandler {
	public int count = 0;
	private GameObject g3;
	private GameObject g2;
	private GameObject g1;

	void Awake()
	{
		//DNA=transform.Find("DNA").gameObject;
		g3 = GameObject.Find ("g3");
		g2 = GameObject.Find ("g2");
		g1 = GameObject.Find ("g1");

	}

	// Use this for initialization
	void Start () {
		//Plane3 = GameObject.Find ("Plane3");
		g3.SetActive (false); 
		g2.SetActive (false);
		g1.SetActive (true);
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour> ();   //获取VirtualButton Behaviour组件
		for (int i = 0; i < vbs.Length; ++i) {     //遍历所有组件
			vbs [i].RegisterEventHandler (this);    //对该脚本进行注册
		}//

	}

	public void OnButtonPressed( VirtualButtonAbstractBehaviour vb ) { 
		Debug.Log ("=================== button pressed ======================"); 
		count += 1;
		if ((count % 3) == 1) {
			g1.SetActive (true);
			g2.SetActive (false);
			g3.SetActive (false);
		}
		if ((count % 3) == 2) {
			g1.SetActive (false);
			g2.SetActive (true);
			g3.SetActive (false);
		}
		if ((count % 3) == 0) {
			g1.SetActive (false);
			g2.SetActive (false);
			g3.SetActive (true);
		}
		//DNA.SetActive (false);


	}
	public void OnButtonReleased( VirtualButtonAbstractBehaviour vb ) { 
		//DNA.SetActive (true);
		//DNA.transform.Rotate (new Vector3(2,Time.deltaTime * 60, 0));



	}

	// Update is called once per frame
	void Update () {

	}
}
