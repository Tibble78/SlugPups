using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ClickableObjectMenu : MonoBehaviour
{
    [SerializeField]
    [Header("Context Menu")]
    private ContextMenuUI contextMenu;

    private Button button;

    void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(HandleClick);
    }

    public void HandleClick()
    {
        if (contextMenu != null)
            contextMenu.Open(transform.position);
    }
}

