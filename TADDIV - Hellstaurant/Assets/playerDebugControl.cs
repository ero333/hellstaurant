using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDebugControl : MonoBehaviour
{

    public PlayerHealthController healthController;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GameOver.enemy =" + healthController.lastAttackingEnemy);
        Debug.Log("GameOver.healing =" + healthController.healingTimes);
        Debug.Log("GameOver.hit =" + healthController.hit);
        Debug.Log("GameOver.basicoHit =" + healthController.basicoHit);
        Debug.Log("GameOver.basicoPHit =" + healthController.basicoPHit);
        Debug.Log("GameOver.gordoHit =" + healthController.gordoHit);
        Debug.Log("GameOver.gordoPHit =" + healthController.gordoPHit);
        Debug.Log("GameOver.rapidoHit =" + healthController.rapidoHit);
        Debug.Log("GameOver.rapidoPHit =" + healthController.rapidoPHit);
        Debug.Log("GameOver.rodeteHit =" + healthController.rodeteHit);
        Debug.Log("GameOver.rodetePHit =" + healthController.rodetePHit);
        Debug.Log("GameOver.arañaHit =" + healthController.arañaHit);
        Debug.Log("GameOver.cucarachaHit =" + healthController.cucarachaHit);
        Debug.Log("GameOver.jefeHit =" + healthController.bossHit);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
