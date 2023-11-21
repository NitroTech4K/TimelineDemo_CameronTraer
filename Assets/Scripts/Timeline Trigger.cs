using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; //Add this at the start to gain functions for the timeline
public class TimelineTrigger : MonoBehaviour
{

    public PlayableDirector Timeline_Event; //Name of the TimeLine slot for the script, visuble in Unity    

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) //Changed from Void Start (Doesn't start on play)
    
    
    {
        Timeline_Event.Play();   //Reference the "Timeline_Event" in here with ".play();" at the end. 
        Debug.Log("Player stepped in trigger bounds. The Timeline has be started.");
    }


    private void OnTriggerExit(Collider other)
    {
        Timeline_Event.Stop(); //Stops the timeline from playing when the player steps off the platform
        Debug.Log("Player stepped out of trigger bounds. The Timeline has been stopped");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
