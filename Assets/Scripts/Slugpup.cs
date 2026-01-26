using UnityEngine;

public class Slugpup : MonoBehaviour
{
    [Range(0, 100)] public int hunger = 50;
    [Range(0, 100)] public int cleanliness = 50;
    [Range(0, 100)] public int mood = 50;

    public InventoryManager InventoryManager;

    public void Feed()
    {
        hunger = Mathf.Clamp(hunger + 20, 0, 100);
        mood = Mathf.Clamp(mood + 5, 0, 100);
        InventoryManager.useItem();
        Debug.Log("Fed");
    }

    public void Clean()
    {
        cleanliness = Mathf.Clamp(cleanliness + 20, 0, 100);
        mood = Mathf.Clamp(mood + 5, 0, 100);
    }

    public void Pet()
    {
        mood = Mathf.Clamp(mood + 15, 0, 100);
        Debug.Log("Pet");
    }

    public void DecayStats()
    {
        hunger = Mathf.Clamp(hunger - 10, 0, 100);
        cleanliness = Mathf.Clamp(cleanliness - 10, 0, 100);
        mood = Mathf.Clamp(mood - 5, 0, 100);
    }

    public void onPetClick(){
        if(InventoryManager.heldItem == "PetFood"){
            Feed();
        }else{
            Pet();
        }
    }
}
