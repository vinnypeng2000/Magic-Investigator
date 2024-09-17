using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueActiveControl : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem ThisParticle;
    public bool ParticleActive = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ThisParticle.isPlaying){
            if(!ParticleActive){
                ThisParticle.Stop();
            }
        }else{
            if(ParticleActive){
                ThisParticle.Play();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ClueDetect")) {
            if (other.GetComponent<specialSense>().senseSkillOn)
            {
                ThisParticle.Play();
                ParticleActive = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ClueDetect"))
        {
            ThisParticle.Stop();
            ParticleActive = false;
            
        }
    }
}
