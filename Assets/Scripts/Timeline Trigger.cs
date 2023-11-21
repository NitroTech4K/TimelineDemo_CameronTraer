using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; //Add this at the start to gain functions for the timeline
public class TimelineTrigger : MonoBehaviour
{

    public PlayableDirector Timeline_Event; //Name of the TimeLine slot for the script, visuble in Unity    

    // Start is called before the first frame update
    void Start()
    {
        Timeline_Event.Play();   //Reference the "Timeline_Event" in here with ".play();" at the end. 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
