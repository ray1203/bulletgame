using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour {
    float timer = 0.5f;
    bool flag = true;
    GameObject _light;
    public float lightDelay = 2.0f;
    // Use this for initialization
    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update () {
        if (flag)
        {
            timer += Time.deltaTime;
            if (timer >= lightDelay)
            {
                playerLight();
                timer = 0.0f;
            }
        }


        
    }
    public void playerLight()
    {

        try
        {
            if (!flag)
            {
                GetComponent<AudioSource>().Play();
                _light.SetActive(true);
            }
            if (flag)
            {
                _light.SetActive(false);
            }

            flag = !flag;
        }
        catch (Exception)
        {

        };
        
        
    }
    public void giveLight(GameObject l)
    {
        _light = l;
        _light.SetActive(false);
    }
}
