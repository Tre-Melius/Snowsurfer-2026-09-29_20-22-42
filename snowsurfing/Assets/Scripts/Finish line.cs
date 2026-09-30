using UnityEngine;

public class Finishline : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D collision)
   {
        int layerIndex = LayerMask.NameToLayer("Player");


        if (collision.gameObject.layer == layerIndex)
        {
            Debug.Log("The Player has won!");
        }
   }
}
