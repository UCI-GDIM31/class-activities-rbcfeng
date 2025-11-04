using UnityEngine;
using UnityEngine.UIElements;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _playertransform;

    public void EnableChase(Transform player)
    {
        enabled = true;
        _playertransform = player;
    }

    public void DisableChase()
    {
        enabled = false;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _playertransform.position, _speed * Time.deltaTime);
    }









}
