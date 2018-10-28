using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider _collider)
    {
        //_collider = 컴포넌트에 충돌한 오브젝트 정보
        if (_collider.CompareTag("Obstacle"))
        {
            Destroy(_collider.gameObject);
            
            GameManager.instance.AddScore();
            Destroy(this.gameObject);
        }

    }
}
