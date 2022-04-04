using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashScript : MonoBehaviour
{
    
    public int dash = 0;
    private void OnEnable()
    {
        dash = 1;
        Debug.Log("giriyor.");
    }
    public void Dash(Rigidbody2D rigid)
    {
        if (dash == 1)
        {
            rigid.velocity = new Vector2(105f, 20f);            
        }
    }
}
