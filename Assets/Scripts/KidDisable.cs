using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidDisable : MonoBehaviour
{
    [SerializeField] GameObject kid;
    // Start is called before the first frame update
    void OnEnable()
    {
        kid.SetActive(false);
    }
}
