using UnityEngine;

public class Fridge : MonoBehaviour
{
    public ContextMenuOption openOption;
    public ContextMenuOption takeFoodOption;

    private bool hasFood = true;

    public void SetupMenu()
    {
        openOption.SetAvailable(true);
        takeFoodOption.SetAvailable(hasFood);
    }

    public void TakeFood()
    {
        hasFood = false;
        Debug.Log("Food taken");
    }
}
