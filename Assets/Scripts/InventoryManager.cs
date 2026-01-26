using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public string heldItem = "";
    public Image heldItemImage;

    public bool addItem(string item){
        if (heldItem == ""){
            heldItem = item;
            heldItemImage.color = new Color(1,1,1,1);
            return true;
        }else{
            return false;
        }
    }
    public void useItem(){
        heldItem = "";
        heldItemImage.color = new Color(1,1,1,0);
    }
}
