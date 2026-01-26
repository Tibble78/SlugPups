using UnityEngine;
using UnityEngine.UI;

public class clickableItem : MonoBehaviour
{
    public string itemName;
    public container location;
    public InventoryManager InventoryManager;
    public Image itemImage;

    public void click(){
        if(location.isOpen){
            if(InventoryManager.addItem(itemName)){
                GameObject.Destroy(gameObject);
            }
        }
    }

    void Update(){
        if(location.isOpen){
            itemImage.raycastTarget = true;
            itemImage.color = new Color(1,1,1,1);
        }else{
            itemImage.raycastTarget = false;
            itemImage.color = new Color(1,1,1,0);
        }
    }
}
