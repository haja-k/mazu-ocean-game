using UnityEngine;

public class keyboard : MonoBehaviour {

    void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.F1.ToString())))
        {
            Debug.Log("Space key is pressed.");
        }
    }
}
