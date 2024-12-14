using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField]
    private float tocDoXe = 100f;
    [SerializeField]
    private float lucReXe = 100f;
    private float dauvaoDiChuyen;
    private float dauvaoRe;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        dauvaoDiChuyen = Input.GetAxis("Vertical");
        dauvaoRe = Input.GetAxis("Horizontal");
        DiChuyenXe();
        ReXe();
    }
    public void DiChuyenXe()
    {
        rb.AddRelativeForce(Vector3.forward * dauvaoDiChuyen * tocDoXe);
    }
    public void ReXe()
    {
        Quaternion re = Quaternion.Euler(Vector3.up*dauvaoRe*lucReXe*Time.deltaTime);
        rb.MoveRotation(rb.rotation*re);
    }
}
