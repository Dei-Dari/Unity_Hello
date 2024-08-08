using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    [SerializeField] private GameObject _volume;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Slider _volumeSlider;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            _volume.SetActive(!_volume.activeSelf);
        }
        _audioSource.volume = _volumeSlider.value;
    }
}
