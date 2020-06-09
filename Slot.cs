using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Slot : MonoBehaviour {
	public Image Icon;

	public Button RemoveBtn;
	public Itens Itens;
	// Use this for initialization
	void Start () {
		Icon = transform.GetChild(1).GetComponent<Image>();
		RemoveBtn = transform.GetChild(0).GetComponent<Button>();
	}
	public void AdicionaItem(Itens i)
	{
		Itens = i;
		Icon.sprite = Itens.ImgItem;
		Icon.enabled = true;
		RemoveBtn.interactable = true;
	}
	public void LimpaSlot()
	{
		Itens = null;
		Icon.sprite = null;
		Icon.enabled = false;
		RemoveBtn.interactable = false;
	}
	public void ChamaRemoveBtn()
	{
		InventoryControll.instance.RemoveItem (Itens);
	}
	public void usarItem()
	{
		if (Itens != null) {
			Itens.usar ();
		}
		Debug.Log("Usando item");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
