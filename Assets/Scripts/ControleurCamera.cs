using UnityEngine;

public class ControleurCamera : MonoBehaviour
{
    [Header("Touches")]
    [SerializeField]
    private KeyCode avancer = KeyCode.W;

    [SerializeField]
    private KeyCode reculer = KeyCode.S;

    [SerializeField]
    private KeyCode gauche = KeyCode.A;

    [SerializeField]
    private KeyCode droite = KeyCode.D;

    [SerializeField]
    private KeyCode zoomAvant = KeyCode.Z;

    [SerializeField]
    private KeyCode zoomArriere = KeyCode.X;

    [SerializeField]
    private KeyCode inclinaisonAvant = KeyCode.C;

    [SerializeField]
    private KeyCode inclinaisonArriere = KeyCode.V;

    [Header("Paramètres de déplacement")]
    [SerializeField]
    private float vitesseDeplacement;

    [SerializeField]
    private float vitesseZoom;

    [SerializeField]
    private float vitesseInclinaison;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(avancer))
        {
            transform.position += Time.deltaTime * vitesseDeplacement *
                Vector3.Scale(transform.forward, new Vector3(1.0f, 0.0f, 1.0f));
        }
        if(Input.GetKey(reculer))
        {
            transform.position -= Time.deltaTime * vitesseDeplacement *
               Vector3.Scale(transform.forward, new Vector3(1.0f, 0.0f, 1.0f));
        }


        if(Input.GetKey(droite))
        {
            transform.position += Time.deltaTime * vitesseDeplacement *
                Vector3.Scale(transform.right, new Vector3(1.0f, 0.0f, 1.0f));
        }
        if(Input.GetKey(gauche))
        {
            transform.position -= Time.deltaTime * vitesseDeplacement *
                Vector3.Scale(transform.right, new Vector3(1.0f, 0.0f, 1.0f));
        }


        if(Input.GetKey(zoomAvant))
        {
            transform.position += Time.deltaTime * vitesseZoom * transform.forward;
        }
        if(Input.GetKey(zoomArriere))
        {
            transform.position -= Time.deltaTime * vitesseDeplacement * transform.forward;
        }

        if(Input.GetKey(inclinaisonAvant))
        {
            transform.Rotate(Vector3.right, Time.deltaTime * vitesseInclinaison);

        }
        if(Input.GetKey(inclinaisonArriere))
        {
            transform.Rotate(Vector3.right, -1.0f * Time.deltaTime * vitesseInclinaison);
        }

        float angleX = Mathf.Clamp(transform.rotation.eulerAngles.x, 0.0f, 90.0f);
        transform.rotation = Quaternion.Euler(angleX, transform.rotation.y, transform.rotation.z);
    }

}
