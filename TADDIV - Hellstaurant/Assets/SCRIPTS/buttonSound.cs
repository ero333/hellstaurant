using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSound : MonoBehaviour
{
   public AudioSource soundPlayer;

   public void playThisSound()
   {
	   soundPlayer.Play();
   }
}
