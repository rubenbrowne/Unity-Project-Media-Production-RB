using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RecyclingBinTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject messageUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ThirdPersonController_LITE"))  // Make sure your player GameObject has the tag "Player"
        {
            audioSource.Play();
            StartCoroutine(ShowMessage());
        }
    }

    IEnumerator ShowMessage()
    {
        messageUI.SetActive(true);
        yield return new WaitForSeconds(5);  // Show the message for 5 seconds
        messageUI.SetActive(false);
    }
}