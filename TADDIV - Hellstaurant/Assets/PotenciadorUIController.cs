using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotenciadorUIController : MonoBehaviour
{
    public GameObject icono;
    public GameObject porcionfuga;
    public GameObject porcionfaina;
    public GameObject porcionpicante;
    public GameObject cajapizza;
    public Animator anim;
    public PotenciadorUIController Instance;

    public GameObject poweruptime;

    // Start is called before the first frame update
    void Start()
    {
        anim=icono.GetComponent<Animator>();
        icono.SetActive(false);
        porcionfuga.SetActive(false);
        porcionfaina.SetActive(false);
        porcionpicante.SetActive(false);
        cajapizza.SetActive(false);
    }

    public void Salida ()
    {
        StartCoroutine(Animsalida());
    }
    private void Awake()
    {
        Instance = this;    
    }
    // Update is called once per frame
    void Update()
    {
      
    }
    IEnumerator Animsalida()
    {
        yield return new WaitForSeconds(0.1f);
        anim.SetBool("potensalida", true);
        yield return new WaitForSeconds(0.2f);
        anim.SetBool("potensalida", false);
        icono.SetActive(false);
        porcionfuga.SetActive(false);
        porcionfaina.SetActive(false);
        porcionpicante.SetActive (false);
        cajapizza.SetActive(false);

        poweruptime.SetActive(false);

    }
}
