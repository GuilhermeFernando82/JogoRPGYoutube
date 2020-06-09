using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour {
	public float raio = 4.5f;
	public bool IsFucus = false;
	public bool Interagiu = false;
	// Use this for initialization
	public virtual void interactM()
	{
		Debug.Log("Interagiu com Item" + transform.name);
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(IsFucus && !Interagiu)
		{
			print("Chegou aqui");
			interactM();
			Interagiu = true;
			print("Chegou aqui");
		}
	}
	public void OnFocus(){
		print("Chegou aqui");
		IsFucus = true;
		Interagiu = false;
	}
}
