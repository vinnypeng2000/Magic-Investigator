using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderInteractable : MonoBehaviour
{
    
    public GameObject text;
    public GameObject popup;
    public bool show;
    public AudioSource sound;

    // Stpopup is called before the first frame update
    void Stpopup()
    {
        show = false;
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (show)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                popup.SetActive(!popup.activeSelf);
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            text.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                popup.SetActive(!popup.activeSelf);
                if (sound != null && !sound.isPlaying)
                {
                    sound.Play();
                }
            }
        }
        
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            text.SetActive(false);
            popup.SetActive(false);
            sound.Stop();
            show = false;
        }
    }

    void OnCollisionStay(Collision col)
    {
        show = true;
    }
}