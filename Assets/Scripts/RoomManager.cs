using UnityEngine;
using UnityEngine.UI;

public class RoomManager : MonoBehaviour
{
    public Image backgroundImage;
    public Sprite[] backgroundImages;
    public int currentRoom = 0;
    public int upperBound = 1;

    public void leftButtonClicked(){
        if(currentRoom != 0){
            currentRoom--;
            setRoom();
        }
    }
    public void rightButtonClicked(){
        if(currentRoom != upperBound){
            currentRoom++;
            setRoom();
        }
    }
    void setRoom(){
        backgroundImage.sprite = backgroundImages[currentRoom];
    }
}
