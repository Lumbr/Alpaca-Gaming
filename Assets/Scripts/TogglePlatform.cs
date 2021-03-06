﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TogglePlatform : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Button button;
    public Lever lever;
    public bool reverse;
    Animator anim;
    AudioManager audioMan;
    void Start()
    {
        audioMan = FindObjectOfType<AudioManager>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (button != null)
        {
            switch (!button.isButtonOn)
            {
                case true:
                    if (reverse)
                    {
                        GetComponent<Collider2D>().enabled = false;
                        GetComponent<SpriteRenderer>().color = new Color(123, 123, 123);
                    }
                    else
                    {
                        GetComponent<Collider2D>().enabled = true;
                        GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
                    }
                    
                    break;
                case false:
                    if (reverse)
                    {
                        GetComponent<Collider2D>().enabled = true;
                        GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
                    }
                    else
                    {
                        GetComponent<Collider2D>().enabled = false;
                        GetComponent<SpriteRenderer>().color = new Color(123, 123, 123);
                    }
                    
                    break;
            }
            if (reverse) { anim.SetBool("Enabled", !button.isButtonOn); } else { anim.SetBool("Enabled", button.isButtonOn); };
        }
        if (lever != null)
        {
            switch (!lever.isLeverOn)
            {
                case true:
                    if (reverse)
                    {
                        GetComponent<Collider2D>().enabled = false;
                        GetComponent<SpriteRenderer>().color = new Color(123, 123, 123);
                    }
                    else
                    {
                        GetComponent<Collider2D>().enabled = true;
                        GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
                    }

                    break;
                case false:
                    if (reverse)
                    {
                        GetComponent<Collider2D>().enabled = true;
                        GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
                    }
                    else
                    {
                        GetComponent<Collider2D>().enabled = false;
                        GetComponent<SpriteRenderer>().color = new Color(123, 123, 123);
                    }


                    break;
            }
            if (reverse) { anim.SetBool("Enabled", !lever.isLeverOn); } else { anim.SetBool("Enabled", lever.isLeverOn); };
        }
    }
    
    public void PlaySlide()
    {
        audioMan.sfxMan.Play(7);
    }
}
