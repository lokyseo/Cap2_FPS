﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_Shot : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("마우스 클릭");
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hitData;

            if (Physics.Raycast(ray, out hitData))
            {
                Debug.Log(hitData.transform.name);
            }
        }

       
    }
    /*
    void Fire()
    {
        aimControl.Fire();
        if (fireTime >= fireRate) // 연사속도 시간을 넘으면
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position,  // 에임 정확도에 따라 레이를 쏨
                Camera.main.transform.forward + // 현재 카메라가 보는 방향을 시작점으로 에임의 정확도 범위 중 랜덤한 위치로 발사
                new Vector3(Random.Range(-aimControl.accuracy, aimControl.accuracy), Random.Range(-aimControl.accuracy, aimControl.accuracy), 0f),
                out hit, range))
            {
                if (hit.transform.tag == "Head") // 머리에 맞으면 2배의 데미지
                {
                    BotControl bot = hit.transform.gameObject.GetComponent<BotControl>();
                    bot.Damaged(10);
                }
                else if (hit.transform.gameObject.tag == "Bot") // 몸통일 경우 일반 데미지
                {
                    BotControl bot = hit.transform.gameObject.GetComponent<BotControl>();
                    bot.Damaged(5);
                }
            }
            Instantiate(bulletEffect, hit.point * 1.001f, Quaternion.LookRotation(hit.normal)); // 총 맞은 위치 표현
            GameObject effect_L = Instantiate(shootEffect, shootPoint_L); // 좌우 총 이펙트
            GameObject effect_R = Instantiate(shootEffect, shootPoint_R);

            Destroy(effect_L, 0.1f); Destroy(effect_R, 0.1f); // 이펙트 삭제
            currentBullet--; // 총알 감소
            fireTime = 0f;
        }
    }
    */
}
