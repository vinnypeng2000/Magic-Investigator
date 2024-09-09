using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class specialSense : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask normalVisionMask;
    public LayerMask senseSkillMask;
    bool senseSkillOn = false;
    void Start()
    {
        Camera.main.cullingMask = normalVisionMask;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (senseSkillOn)
            {
                Camera.main.cullingMask = normalVisionMask;
                senseSkillOn =!senseSkillOn;
            }
            else
            {
                Camera.main.cullingMask = senseSkillMask;
                senseSkillOn = !senseSkillOn;
            }
        }
    }
}
