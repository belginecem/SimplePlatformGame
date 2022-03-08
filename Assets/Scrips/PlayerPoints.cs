using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPoints : MonoBehaviour
{
    private AudioSource _audio;
    [SerializeField] private TextMeshProUGUI _text;



    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _text.text = score.totalScore.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("elmas"))
        {
            _audio.Play();
            Destroy(other.gameObject);
            score.totalScore++;
            _text.text = score.totalScore.ToString();
        }
    }

}
