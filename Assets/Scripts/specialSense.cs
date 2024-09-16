using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class specialSense : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask normalVisionMask;
    public LayerMask senseSkillMask;
    public PostProcessVolume PostProcessVolume;
    public bool senseSkillOn = false;
    void Start()
    {
        Camera.main.cullingMask = normalVisionMask;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (!senseSkillOn)
            {
                Camera.main.cullingMask = senseSkillMask;
                senseSkillOn =!senseSkillOn;
                PostProcessVolume.enabled = true;
            }
        }

        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            if (senseSkillOn)
            {
                Camera.main.cullingMask = normalVisionMask;
                senseSkillOn = !senseSkillOn;
                PostProcessVolume.enabled = false;
            }
        }
    }
}
