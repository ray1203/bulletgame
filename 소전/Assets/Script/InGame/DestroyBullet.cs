using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour {
    public GameObject bullet;
    public ParticleSystem explosion;
    public GameObject hitArea;
    
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void explode()
    {
        if (GameObject.Find("Bullet(Clone)") != null)
        {
            GameObject.Find("justBit").GetComponent<PlayerLight>().stopSound();
                    GetComponent<AudioSource>().Play();
                    hitArea.SetActive(true);
        
                    Instantiate(hitArea, GameObject.Find("Bullet(Clone)").transform.position, Quaternion.identity);
                    Instantiate(explosion, GameObject.Find("Bullet(Clone)").transform.position, Quaternion.identity);
                    Destroy(GameObject.Find("Bullet(Clone)"));
        }
        
        
    }
    public void giveArea(GameObject ob)
    {
        hitArea = ob;
    }
    
}
