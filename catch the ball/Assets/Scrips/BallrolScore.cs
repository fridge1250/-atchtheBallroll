using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallrolScore : MonoBehaviour
{
    [SerializeField] private int _score = 0;
    [SerializeField] private Text _textScore;
    
    void Update()
    {
        void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ballrol")
        {
            _score++;
            _textScore.text = _score.ToString();
        }
    }
    }
    
}
