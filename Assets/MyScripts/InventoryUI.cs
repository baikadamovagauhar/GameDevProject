using UnityEngine;

public class InventoryUI : MonoBehaviour
{
	Inventory inventory;
	public Transform itemsParent;
	InventorySlot[] slots;
	public GameObject inventoryUI;
	public GameObject diary;
	public GameObject puzzleLayer;
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
		if (inventoryUI.activeSelf || puzzleLayer.activeSelf)
		{
			Cursor.visible = true;
		}
		else {
			Cursor.visible = false;
		}
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
