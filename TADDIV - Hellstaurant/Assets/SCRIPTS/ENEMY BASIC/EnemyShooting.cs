using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet; //para la balita
    public Transform bulletPos;
    public float bulletspeed = 10f;
    public Transform player;
    public Vector3 playerposition;
    private float timer;
    public Animator anim;
    public EnemyController enemyController;
    public NewBehaviourScript enemyscript;
    public static EnemyShooting instance;

    public void Awake()
    {
        instance = this;
            
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player!=null)
        {
            playerposition = player.position;
        }

        //timer += Time.deltaTime;

        //if(timer > 2)
        //{
        //   timer = 0;
        //   shoot();
        //}
    }
     public void shooting()
    {
        
    }

    void shoot()
    {
        if(bullet!=null)
        {
            anim.SetBool("Shooting", true);
            Vector3 shootdirection = (playerposition-transform.position).normalized;
            GameObject newbullet = Instantiate(bullet, transform.position, Quaternion.identity);
            Rigidbody2D bulletrb = newbullet.GetComponent<Rigidbody2D>();
            
            if (bulletrb != null )
            {
                bulletrb.velocity = shootdirection * bulletspeed;
            }
        }
    }
}
