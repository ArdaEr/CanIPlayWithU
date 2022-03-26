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
    public GameObject controlPanel;
    public PlayerInput playerInput;

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
            StartCoroutine(DisableInput6());
            director2.Play();
        }
        if (c.gameObject.tag == "Table")
        {
            StartCoroutine(DisableInput6());
            director3.Play();
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
    }
    IEnumerator DisableInput3()
    {
        playerInput.enabled = false;
        yield return new WaitForSecondsRealtime(3);
        playerInput.enabled = true;

    }
    IEnumerator DisableInput6()
    {
        playerInput.enabled = false;
        yield return new WaitForSecondsRealtime(6);
        playerInput.enabled = true;
    }
}
