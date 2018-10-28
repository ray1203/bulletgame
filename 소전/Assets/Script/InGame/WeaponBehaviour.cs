using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WeaponBehaviour : MonoBehaviour
{
    //카메라 정보
    [SerializeField]
    Transform cameraTransform;

    //총구 위치
    public Transform fireTransform;
    //총알 오브젝트
    public GameObject bulletPrefab;
    //발사 딜레이
    public float fireDelay = 1f;
    //현재 딜레이 시간
    public float currentDelay = 0f;
    //총알 속도
    public float speed = 10f;
    //총알 데미지
    public int damage = 1;
    public Slider fire;
    
   
    void Update()
    {
        currentDelay -= Time.deltaTime;

        if (currentDelay < 0 && Input.GetMouseButtonDown(0))
        {

            if (GameObject.FindWithTag("particle") != null)
            {
                Destroy(GameObject.FindWithTag("particle"));
            }
            //오브젝트를 생성
            GameObject g = Instantiate(bulletPrefab);
            g.transform.position = fireTransform.position;

            //GetComponent<컴포넌트 이름>();
            Bullet bullet = g.GetComponent<Bullet>();
            
            //요거 요
            bullet.SetBullet(this,speed, fireDelay, damage, cameraTransform);
            
            //요거 요

            currentDelay = fireDelay;
            GameObject.Find("justBit").GetComponent<PlayerLight>().giveLight(GameObject.FindGameObjectWithTag("light"));
        }
        fire.value = currentDelay/fireDelay;
    }


    public void ResetDelay() {
        currentDelay = 0;
    }

}
