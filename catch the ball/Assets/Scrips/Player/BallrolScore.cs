using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallrolScore : MonoBehaviour
{
    [SerializeField] private int _score = 0;
    public Text _textScore;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ballroll")
        {
            _score++;
        }
    }
    
    void Update()
    {
        _textScore.text = _score.ToString();
    }

    
    
}
