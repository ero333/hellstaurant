using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class achievementManager : MonoBehaviour
{
    static achievementManager variable;

    [Header("VARIABLES LOGROS")]

    public GameObject popupNewGame;




    void Awake()
    {
        if (variable != null)
        {
            Destroy(this.gameObject);
        }

        else
        {
            variable = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("partidasCreadas") >= 1)
        {
            if (popupNewGame != null)
            {
                StartCoroutine(newGameAchievement());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator newGameAchievement()
    {
        popupNewGame.SetActive(true);
        yield return new WaitForSeconds(3);
        popupNewGame.SetActive(false);
    }
}
