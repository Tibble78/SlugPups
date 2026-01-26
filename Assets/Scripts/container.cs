using UnityEngine;

public class container : MonoBehaviour
{
    public bool isOpen = false;

    public void click(){
        isOpen = !isOpen;
    }
}
