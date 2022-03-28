using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.InputSystem;

public class KidColliderController : MonoBehaviour
{
    public PlayableDirector director1;
    public PlayableDirector director2;
    public PlayableDirector director3;
    public PlayableDirector director4;
    public PlayableDirector director5;
    public PlayableDirector director6;

    public GameObject controlPanel;
    public PlayerInput playerInput;

    public SpriteRenderer render;

    //public PlayableDirector timeline;
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Painting")
        {
            StartCoroutine(DisableInput3());
            director1.Play();
            
        }
        if (c.gameObject.tag == "King")
        {
            StartCoroutine(DisableInput15());
            director2.Play();
        }
        if (c.gameObject.tag == "Table")
        { 
            StartCoroutine(DisableInput3());
            director3.Play();
        }
        if (c.gameObject.tag == "Farmer")
        {
            StartCoroutine(DisableInput8());
            director4.Play();
        }
        if (c.gameObject.tag == "BlackSmith")
        {
            StartCoroutine(DisableInput8());
            director5.Play();
        }
        if (c.gameObject.tag == "Water")
        {
            director6.Play();
            render.enabled = false;
            //StartCoroutine(DisableInput15());
            
        }
    }
    private void OnTriggerExit2D(Collider2D c)
    {
        if (c.gameObject.tag == "Painting")
        {
            director1.enabled = false;
        }
        if (c.gameObject.tag == "King")
        {
            director2.enabled = false;
        }
        if (c.gameObject.tag == "Table")
        {
            director3.enabled = false;
        }
        if (c.gameObject.tag == "Farmer")
        {
            director4.enabled = false;
        }
        if (c.gameObject.tag == "Farmer")
        {
            director5.enabled = false;
        }
        if (c.gameObject.tag == "Water")
        {
            director6.enabled = false;
        }
    }
    IEnumerator DisableInput3()
    {
        playerInput.enabled = false;
        yield return new WaitForSecondsRealtime(3);
        playerInput.enabled = true;

    }
    IEnumerator DisableInput8()
    {
        playerInput.enabled = false;
        yield return new WaitForSecondsRealtime(8);
        playerInput.enabled = true;
    }
    IEnumerator DisableInput15()
    {
        playerInput.enabled = false;
        yield return new WaitForSecondsRealtime(15);
        playerInput.enabled = true;
    }
}
