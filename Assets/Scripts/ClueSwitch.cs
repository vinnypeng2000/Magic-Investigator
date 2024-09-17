using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject PreviousClue;
    GameObject NextClue;
    public bool clueSwitched = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchClue()
    {
        if (!clueSwitched)
        {
            clueSwitched=true;
            if(PreviousClue){
                PreviousClue.SetActive(false);
            }
            if(NextClue){
                NextClue.SetActive(true);
            }
        }
    }
}
