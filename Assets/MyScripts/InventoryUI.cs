using UnityEngine;

public class InventoryUI : MonoBehaviour
{
	Inventory inventory;
	public Transform itemsParent;
	InventorySlot[] slots;
	public GameObject inventoryUI;
	public GameObject diary;
    // Start is called before the first frame update
    void Start()
    {
		inventory = Inventory.instance;
		inventory.onItemChangedCallBack += UpdateUI;
		Cursor.lockState = CursorLockMode.Confined;
		slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Inventory"))
		{
			inventoryUI.SetActive(!inventoryUI.activeSelf);
			diary.SetActive(inventoryUI.activeSelf);
		}
		Cursor.visible = inventoryUI.activeSelf;
    }
	
	void UpdateUI()
	{
		for(int i = 0; i<slots.Length; i++)
		{
			if(i < inventory.items.Count)
			{
				slots[i].AddItem(inventory.items[i]);
			} else 
			{
				slots[i].ClearSlot();
			}
		}
	}
}
