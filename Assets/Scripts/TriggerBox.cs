using UnityEngine;
using System.Collections;

public class TriggerBox : MonoBehaviour
{
    public GameObject text;
    public GameObject button;
    public GameObject text2;

    private bool trigger;
    void Start()
    {
        trigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                text.SetActive(!text.activeSelf);
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
            trigger = false;
            button.SetActive(false);
            if(text.activeInHierarchy == true)
            {
                text.SetActive(false);
            }

            if (text2 != null)
            {
                StartCoroutine(SensesText());
            }
        }

    }

    IEnumerator SensesText()
    {
        text2.SetActive(true);
        yield return new WaitForSeconds(2);
        text2.SetActive(false);
    }
}
