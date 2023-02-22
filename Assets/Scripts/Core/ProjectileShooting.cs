using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    private float timer;
    private GameObject player;
    [Tooltip("Vertical distance checked to enable shooting projectiles to the player")]
    public float distanceCheck;
    


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Mathf.Abs(transform.position.y - player.transform.position.y);
        
        Debug.Log(distance);

        if (distance <= distanceCheck)
        {
            timer += Time.deltaTime;

            if (timer > 3)
            {
                timer = 0;
                shoot();
            }
        }


    }

    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}