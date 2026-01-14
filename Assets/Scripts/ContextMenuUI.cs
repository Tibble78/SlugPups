using UnityEngine;

public class ContextMenuUI : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private Vector3 offset;

    private int runs;

    void Awake()
    {
        Close();
    }

    public void Open(Vector3 worldPosition)
    {
        runs++;
        if(runs==1){
            return;
        }
        if(canvasGroup.alpha == 1)
        {
            Close(); 
            return;
        }
        transform.position = worldPosition + offset;
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;
        canvasGroup.interactable = true;
        runs = 0;
    }

    public void Close()
    {
        canvasGroup.alpha = 0;
        canvasGroup.blocksRaycasts = false;
        canvasGroup.interactable = false;
    }
}
