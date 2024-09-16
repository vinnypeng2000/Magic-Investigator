using UnityEngine;
using System.Collections;

public class AudioPlay : MonoBehaviour
{
    public GameObject button;
    public AudioSource audioSource;

    private bool trigger;
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger)
        {
            if (Input.GetKeyDown(KeyCode.E) && !audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trigger = true;
            button.SetActive(true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            button.SetActive(false);

        }
    }
}
