using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControleurJoueur : MonoBehaviour
{
	public float vitesse;
    public Text countText;
    public Text winText;
    private Rigidbody rb;
    private int count;
    private int total;
    
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();  
      count = 0;
      total = 0;
      SetCountText ();
      winText.text = "";

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 mouvement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(mouvement*vitesse);

    }
    public void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag ("Cible")) 
        {
              other.gameObject.SetActive (false) ;
              count = count + 1;
              total = total + 1;
              SetCountText ();
        }
        else if (other.gameObject.CompareTag ("Nible")) 
        {
              other.gameObject.SetActive (false) ;
              count = count - 1;
              total = total + 1;
              SetCountText ();
        }
    }
    
    void SetCountText (){
        countText.text = "Count: " + count.ToString ();
        if (total >=4) 
        {
            if (count >= 4)
            {
                winText.text = "You Win!";
            }
            else 
            {
                winText.text = "You Lose";
            }
        }

    }


}
