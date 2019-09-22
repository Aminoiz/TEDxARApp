using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArqScript : MonoBehaviour
{
    public Button btn;
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void BtnPressed()
    {
        anim.SetTrigger("play");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
