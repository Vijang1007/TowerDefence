using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    float MoveSpeed = 0.15f;
    float MoveX = -1050f;
    float MoveY = 360f;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.isPlay == true)
        {
            //if(gameObject.transform.position.x >= -8.5)
            //{
            //    gameObject.GetComponent<SpriteRenderer>().color = new Color(255,255,255,255);
            //}
            if (MoveX < -540f)
            {
                transform.position = new Vector3(MoveX, MoveY, transform.position.z);
                MoveX += MoveSpeed;
            }
            else if (MoveX < -180f && MoveX >= -540f && MoveY > -115f)
            {
                transform.position = new Vector3(MoveX, MoveY, transform.position.z);
                MoveY -= MoveSpeed;
            }
            else if (MoveX < -180f && MoveY < 240f)
            {
                transform.position = new Vector3(MoveX, MoveY, transform.position.z);
                MoveX += MoveSpeed;
            }
            else if (MoveX < 300f && MoveX >= -180f && MoveY < 240f)
            {
                transform.position = new Vector3(MoveX, MoveY, transform.position.z);
                MoveY += MoveSpeed;
            }
            else if (MoveX < 300f)
            {
                transform.position = new Vector3(MoveX, MoveY, transform.position.z);
                MoveX += MoveSpeed;
            }
            else if (MoveX <= 300f && MoveY > 0)
            {
                transform.position = new Vector3(MoveX, MoveY, transform.position.z);
                MoveY -= MoveSpeed;
            }
            else if (MoveX < 660f)
            {
                transform.position = new Vector3(MoveX, MoveY, transform.position.z);
                MoveX += MoveSpeed;
            }
            else if (MoveY < 360f)
            {
                transform.position = new Vector3(MoveX, MoveY, transform.position.z);
                MoveY += MoveSpeed;
            }
            else
            {
                transform.position = new Vector3(MoveX, MoveY, transform.position.z);
                MoveX += MoveSpeed;
            }
            if (gameObject.transform.position.x >= 1050f)
            {
                GameObject.Destroy(gameObject);
            }
        }       
    }
}
