using UnityEngine;

public class Faucet : MonoBehaviour
{
    private bool isOn;

    public void ToggleFaucet()
    {
        isOn = !isOn;
        Debug.Log("Faucet is now " + (isOn ? "ON" : "OFF"));

        // Play animation / sound here
    }
}
