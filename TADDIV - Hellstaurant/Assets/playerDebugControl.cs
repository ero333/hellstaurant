using System.Collections;
using System.Collections.Generic;
using Unity.Services.Analytics;
using UnityEngine;
using UnityEngine.Analytics;
using static Cinemachine.DocumentationSortingAttribute;

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


        AnalyticsService.Instance.CustomData("GameOver", new Dictionary<string, object>
            {
            { "enemy", healthController.lastAttackingEnemy },
            { "healing",  healthController.healingTimes },
            { "hit",  healthController.hit },
            { "basicoHit",  healthController.basicoHit },
            { "basicoPHit",  healthController.basicoPHit },
            { "gordoHit",  healthController.gordoHit },
            { "gordoPHit",  healthController.gordoPHit },
            { "rapidoHit",  healthController.rapidoHit },
            { "rapidoPHit",  healthController.rapidoPHit },
            { "rodeteHit",  healthController.rodeteHit },
            { "rodetePHit",  healthController.rodetePHit },
            { "arañaHit",  healthController.arañaHit },
            { "cucarachaHit",  healthController.cucarachaHit },
            { "jefeHit",  healthController.bossHit }

            });

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
