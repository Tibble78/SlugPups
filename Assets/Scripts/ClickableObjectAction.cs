using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ClickableObjectAction : MonoBehaviour
{
    [SerializeField]
    [Header("Immediate Action")]
    private UnityEvent onClickAction;

    private Button button;

    void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(HandleClick);
    }

    void HandleClick()
    {
        onClickAction?.Invoke();
    }
}

