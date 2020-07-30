using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walkingfx : MonoBehaviour
{
    public AudioClip grassFX;
    public AudioClip rockFX;
    public GameObject player;
    private string surface;
    private RaycastHit hit;
    // Start is called before the first frame update
    public void Walking()
    {
        bool inground = player.GetComponent<PlayerController>().Grounded();
        if(inground)
       
        Debug.Log("isgrounded running");
        {
                //RaycastHit hit;
                if(Physics.Raycast(transform.position, Vector3.down, out hit ))
            {
                var floortag = hit.collider.gameObject.tag;
                if (floortag == "grass")
                    {
                        GetComponent<AudioSource>().PlayOneShot(grassFX);
                        Debug.Log("grass running");
                    }
                else if (floortag == "stone")
                    {
                        GetComponent<AudioSource>().PlayOneShot(rockFX);
                        Debug.Log("stone running");
                    }
            }
        }
    }
}
