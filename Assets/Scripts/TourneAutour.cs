
using UnityEngine;

public class TourneAutour : MonoBehaviour
{
    [SerializeField, Tooltip("Temps en annee pour faire un tour, 1 an = 1 seconde")]
    private float tempsTour;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.parent.position, Vector3.up, tempsTour * Time.deltaTime * 360.0f * ControleurTemps.Instance.RatioTemps);
    }
}
