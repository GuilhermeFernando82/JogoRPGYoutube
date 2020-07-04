using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryControll : MonoBehaviour {
	public static InventoryControll instance;
	private void Awake(){
		if (instance == null) {
			instance = this;
		}
	}
	// Use this for initialization
	void Start () {

	}
	public delegate void itemAlterado();
	public event itemAlterado itemAlteradoE;
	[SerializeField]
	private int QtSlot;
	public GameObject[] objetoCol;
	public GameObject heroi;
	
    public List<Itens> inventoryItens = new List<Itens> ();
	public List<Itens> inventoryItensP = new List<Itens> ();

    // Update is called once per frame
    void Update () {

	}
	public bool AdicionaItem(Itens i){
		if(inventoryItens.Count >= QtSlot){
			
			return false;
		}

		inventoryItens.Add (i);
		if (itemAlteradoE != null) {
			itemAlteradoE ();
		}
		return true;
	}
	public bool AdicionaItemP(Itens i){
		if(inventoryItensP.Count >= QtSlot){
			
			return false;
		}

		inventoryItensP.Add (i);
		if (itemAlteradoE != null) {
			itemAlteradoE ();
		}
		return true;
	}
	public void RemoveItemPerma(Itens i)
	{
		inventoryItens.Remove (i);
		if (itemAlteradoE != null) {
			itemAlteradoE ();
		}
	}
	public void RemoveItem(Itens i){
		inventoryItens.Remove (i);
		inventoryItensP.Remove (i);
		Instantiate(objetoCol[i.id], new Vector3(heroi.transform.position.x,heroi.transform.position.y,heroi.transform.position.z + 1),Quaternion.identity);
		if (itemAlteradoE != null) {
			itemAlteradoE ();
		}
	}
	public void Equipar(){
		print("Equipando");
	}
	/*public void AddIten(Itens Item){
		/*bool foundItem = false;
		foreach (Itens itemlist in inventoryItens)
			{
				if (itemlist.nameItem == Item.nameItem)
				{
					itemlist.AddItem ();
					foundItem = true;
				}
			}
			if (!foundItem) {
				inventoryItens.Add(Item);
		//}else{//
		*/	
	//	inventoryItens.Add(Item);
	//	Item.gameObject.SetActive(false);
		//}

		//} //else

//}
}
