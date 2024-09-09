using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monologue : MonoBehaviour
{

    public GameObject text;
    public GameObject text2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            text.SetActive(true);
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            text.SetActive(false);
        }
        StartCoroutine(SensesText());
    }

    IEnumerator SensesText()
    {
        text2.SetActive(true);
        yield return new WaitForSeconds(2);
        text2.SetActive(false);
    }
}
