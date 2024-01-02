using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;

    public TextMeshProUGUI scoreText; //reference to the score
    private int score = 0; //score starts at 0

    public void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "Stone1(Clone)" || hit.transform.name == "Stone2(Clone)" || hit.transform.name == "Stone3(Clone)") //if the raycast hits a gem
            {
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal)); //might need to change
                // Instantiate(smoke, hit.transform.position, Quaternion.identity); //might need to change
                Destroy(hit.transform.gameObject);

                //Update the score and the text
                score++;
                scoreText.text = "Score: " + score.ToString();
            }
        }
    }
}
