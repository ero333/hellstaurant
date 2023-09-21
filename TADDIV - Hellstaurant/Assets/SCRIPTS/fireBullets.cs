using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBullets : MonoBehaviour
{

    public int bulletsAmount = 10;

    public float startAngle = 90f, endAngle = 270f;

    public static fireBullets instance;

    private Vector2 bulletMoveDirection;


    public void Awake()
    {
        instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Fire", 0f, 2f);
    }

    public void Fire()
    {
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle;
        
        for (int i = 0; i < bulletsAmount + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPoolScript.instance.getBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<bolloScript>().setMoveDirection(bulDir);

            angle += angleStep;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
