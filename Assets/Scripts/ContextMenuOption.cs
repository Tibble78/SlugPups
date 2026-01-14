using UnityEngine;
using UnityEngine.UI;

public class ContextMenuOption : MonoBehaviour
{
    private Button button;

    void Awake()
    {
        button = GetComponent<Button>();
    }

    public void SetAvailable(bool available)
    {
        button.interactable = available;
    }
}
