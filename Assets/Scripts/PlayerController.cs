using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 10f;
	public float rotationSpeed = 10f;

	private float rotation;
	private Rigidbody rb;

	public GameObject A;
	public GameObject B;
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update ()
	{
		rotation = Input.GetAxisRaw("Horizontal");
	}

	void FixedUpdate ()
	{
		rb.MovePosition(rb.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
		Vector3 yRotation = Vector3.up * rotation * rotationSpeed * Time.fixedDeltaTime;
		Quaternion deltaRotation = Quaternion.Euler(yRotation);
		Quaternion targetRotation = rb.rotation * deltaRotation;
		rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, 50f * Time.deltaTime));
		//transform.Rotate(0f, rotation * rotationSpeed * Time.fixedDeltaTime, 0f, Space.Self);
	}
	public void Left()
	{
		transform.Translate(Vector3.forward * Time.deltaTime * rotation * rotationSpeed);
		transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed * moveSpeed);
	}

	public void Right()
	{
		transform.Translate(Vector3.forward * Time.deltaTime * rotation * rotationSpeed);
		transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * moveSpeed);
	}
}
