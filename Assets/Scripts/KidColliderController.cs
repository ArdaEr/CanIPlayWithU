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
            StartCoroutine(DisableInput4());
            director1.Play();
            
        }
        if (c.gameObject.tag == "King")
        {
            StartCoroutine(DisableInput20());
            director2.Play();
        }
        if (c.gameObject.tag == "Table")
        { 
            StartCoroutine(DisableInput4());
            director3.Play();
        }
        if (c.gameObject.tag == "Farmer")
        {
            StartCoroutine(DisableInput9());
            director4.Play();
        }
        if (c.gameObject.tag == "BlackSmith")
        {
            StartCoroutine(DisableInput9());
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
    IEnumerator DisableInput4()
    {
        playerInput.enabled = false;
        yield return new WaitForSecondsRealtime(4);
        playerInput.enabled = true;

    }
    IEnumerator DisableInput5()
    {
        playerInput.enabled = false;
        yield return new WaitForSecondsRealtime(5);
        playerInput.enabled = true;
    }
    IEnumerator DisableInput9()
    {
        playerInput.enabled = false;
        yield return new WaitForSecondsRealtime(9);
        playerInput.enabled = true;
    }
    IEnumerator DisableInput10()
    {
        playerInput.enabled = false;
        yield return new WaitForSecondsRealtime(10);
        playerInput.enabled = true;
    }
    IEnumerator DisableInput15()
    {
        playerInput.enabled = false;
        yield return new WaitForSecondsRealtime(15);
        playerInput.enabled = true;
    }
    IEnumerator DisableInput20()
    {
        playerInput.enabled = false;
        yield return new WaitForSecondsRealtime(20);
        playerInput.enabled = true;
    }
}
