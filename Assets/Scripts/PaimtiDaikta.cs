using UnityEngine;
using System.Collections;



public class PaimtiDaikta : MonoBehaviour
{
    
    public Transform carryLocation; // this is empty gameobject as a child of player, object will be carried on this position
    Transform LaikykDaiktas = null;

    void Start()
    {

    }

    void Update()
    {

        // L spaudziamas norint ismesti laikoma daikt
        if (Input.GetKey(KeyCode.L))
        {
            if (LaikykDaiktas != null)
            {
                // daiktas panaikinamas kaip child
                LaikykDaiktas.parent = null;

                //nustatomos koordinates kai daiktas ismetamas
                LaikykDaiktas.position = transform.GetComponent<SpriteRenderer>().bounds.min;
                
                            //cia kad kardas, kai ismetamas butu pradines savo pozicijos, kad nepasismeigtum
                        LaikykDaiktas.localScale = new Vector3(1, 1, 1);
                
               
                // paleisti reference
                LaikykDaiktas = null;
            }
        }
    }


    void OnTriggerEnter2D(Collider2D LaikysimasDaiktas)
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
       
        { 
            // jeigu tagas yra "Daiktas" ir zmogeliukas nieko nelaiko, tai daiktas bus paimtas
            if (LaikysimasDaiktas.CompareTag("Daiktas")   && LaikykDaiktas == null || LaikysimasDaiktas.CompareTag("Griovejas") && LaikykDaiktas == null)
            {
                // referenceas i susidurta daikta
                LaikykDaiktas = LaikysimasDaiktas.transform;

                // nustattoma kuriojen pozicijoje bus daiktas (gerai veikia tik su kardu, o ka su kitais daiktais??)
                transform.localScale = new Vector3(transform.localScale.x, 1.7f, 1);

                LaikykDaiktas.position = new Vector3(carryLocation.position.x + 0.2f, carryLocation.position.y, 1);


                // daiktas padaromas zmogeliuko child, kad judetu kartu
                LaikykDaiktas.parent = transform;
            }
    }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))

        {
            // jeigu tagas yra "Daiktas" ir zmogeliukas nieko nelaiko, tai daiktas bus paimtas
            if (LaikysimasDaiktas.CompareTag("Daiktas") && LaikykDaiktas == null || LaikysimasDaiktas.CompareTag("Griovejas") && LaikykDaiktas == null)
            {
                // referenceas i susidurta daikta
                LaikykDaiktas = LaikysimasDaiktas.transform;

                // nustattoma kuriojen pozicijoje bus daiktas (gerai veikia tik su kardu, o ka su kitais daiktais??)
                transform.localScale = new Vector3(-transform.localScale.x, 1.7f, 1);

                LaikykDaiktas.position = new Vector3(carryLocation.position.x + 0.2f, carryLocation.position.y, 1);


                // daiktas padaromas zmogeliuko child, kad judetu kartu
                LaikykDaiktas.parent = transform;
            }
        }
    }
}

