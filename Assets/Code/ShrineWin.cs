using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrineWin : MonoBehaviour
{
    public AudioClip audio;
    public AudioClip wow;
    public ParticleSystem winner;

    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        HideUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnTriggerEnter(Collider other)
   {
        if (other.tag == "Player")
        {
         ShowUI();

        }
   }

   public void BowFunction()
   {
       gameObject.GetComponent<AudioSource>().PlayOneShot(audio);
       gameObject.GetComponent<AudioSource>().PlayOneShot(wow);     
            winner.Play();

   }

   public void HideUI()
   {
    ui.SetActive(false);
     Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
   }

   public void ShowUI()
   {
    ui.SetActive(true);

    Cursor.lockState = CursorLockMode.None;
    Cursor.visible = true;

   }

    public void PressYes()
    {
        HideUI();
        BowFunction();

    }
    
    public void PressNo()
    {
        HideUI();
    }

}