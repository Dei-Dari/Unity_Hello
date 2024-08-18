using TMPro;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private TextMeshProUGUI _textMeshPro;

    private void Start()
    {
        if (PlayerPrefs.HasKey("score"))
        {
            _score = PlayerPrefs.GetInt("score");
        }
    }
    void Update()
    {
        _textMeshPro.text = _score.ToString();
        PlayerPrefs.SetInt("score", _score);
    }
}
