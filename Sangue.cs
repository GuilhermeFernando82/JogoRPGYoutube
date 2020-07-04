using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sangue : MonoBehaviour {

	public float VidaDoPersonagem;
	public Texture Sangue1,Contorno;
	public GameObject hud;
	public int VidaCheia = 100;
	public Text life;
	public Text exp;
	public Text nivel;
	public Text Atk;
	public float experience = 0;
	public float lvll;
	public GameObject IconSkill1;
	public GameObject IconSkill2;
	public static Sangue instance;
	private void Awake(){
		if (instance == null) {
			instance = this;
		}
	}
	void Start (){
		VidaDoPersonagem = VidaCheia;
		IconSkill1.gameObject.SetActive(false);
		IconSkill2.gameObject.SetActive(false);
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
		DontDestroyOnLoad(this.gameObject);
		life.text = VidaDoPersonagem.ToString();
		exp.text = experience.ToString();
		if(experience > 100)
		{
			lvll += 1;
			nivel.text = lvll.ToString(); 
			experience = 0;
		}
		if(lvll == 1){
			IconSkill1.gameObject.SetActive(true);
		}
		if(lvll == 2){
			IconSkill2.gameObject.SetActive(true);
		}
		
	}
	void OnGUI (){
		GUI.DrawTexture (new Rect (Screen.width / 25, Screen.height / 15, Screen.width / 5.5f/VidaCheia*VidaDoPersonagem, Screen.height / 25), Sangue1);
		GUI.DrawTexture (new Rect (Screen.width / 40, Screen.height / 40, Screen.width / 5, Screen.height / 8), Contorno);
	}

}
