using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sangue : MonoBehaviour {

	public float VidaDoPersonagem;
	public Texture Sangue1,Contorno;
	public GameObject hud;
	public int VidaCheia = 100;
	public static Sangue instance;
	private void Awake(){
		if (instance == null) {
			instance = this;
		}
	}
	void Start (){
		VidaDoPersonagem = VidaCheia;
	}
	void Update (){
		/*if (VidaDoPersonagem >= VidaCheia) {
			VidaDoPersonagem = VidaCheia;
		} else if (VidaDoPersonagem <= 0) {
			VidaDoPersonagem = 0;
		}*/
		if (VidaDoPersonagem <= 0) {
			Application.LoadLevel("GameOver");
		}
	}
	void OnGUI (){
		GUI.DrawTexture (new Rect (Screen.width / 25, Screen.height / 15, Screen.width / 5.5f/VidaCheia*VidaDoPersonagem, Screen.height / 25), Sangue1);
		GUI.DrawTexture (new Rect (Screen.width / 40, Screen.height / 40, Screen.width / 5, Screen.height / 8), Contorno);
	}

}
