using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    public float score;
    public Text pointText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Score: "+score;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Coin")
        {
            score += 10;
            Destroy(collision.gameObject);
        }
    }
}
