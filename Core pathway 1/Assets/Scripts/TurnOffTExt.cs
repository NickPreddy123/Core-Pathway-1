using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffTExt : MonoBehaviour
{
    // The time in seconds to wait before disabling the game object
    public float waitTime = 10f;

    // The game object to disable
    public GameObject gameObjectToDisable;

    // Start is called before the first frame update
    void Start()
    {
        // Start the coroutine that waits for waitTime seconds and then disables the game object
        StartCoroutine(WaitAndDisableGameObject());
    }

    IEnumerator WaitAndDisableGameObject()
    {
        // Wait for waitTime seconds
        yield return new WaitForSeconds(waitTime);

        // Disable the game object
        gameObjectToDisable.SetActive(false);
    }

}
