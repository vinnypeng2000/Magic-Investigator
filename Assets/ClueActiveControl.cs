using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueActiveControl : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem ThisParticle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ClueDetect")) {
            if (other.GetComponent<specialSense>().senseSkillOn)
            {
                ThisParticle.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ClueDetect"))
        {
            ThisParticle.Stop();
            
        }
    }
}
