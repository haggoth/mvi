using UnityEngine;
using System.Collections;

public class PurchaseIcon : MonoBehaviour {
	public GameObject unit;
	private 
	// Use this for initialization
	void Start () {
		//here we should be getting the sprite from the unit assigned to this button.
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private Vector3 screenPoint;
	public void OnMouseDown(){
		Instantiate(gameObject, transform.position, transform.rotation);
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		((SpriteRenderer)GetComponent("SpriteRenderer")).sprite = ((SpriteRenderer)unit.GetComponent("SpriteRenderer")).sprite;
	}
	public void OnMouseDrag(){
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
		transform.position = curPosition;
	}
	public void OnMouseUp(){
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		GameObject unit2 = (GameObject)Instantiate(unit, Camera.main.ScreenToWorldPoint(curScreenPoint), new Quaternion());
		UnitScript script = (UnitScript)unit2.GetComponent("UnitScript");
		script.isAlive = true;
		Destroy (gameObject);
	}
	//void OnGUI(){
		/*Event e = Event.current;
		if (e.type == EventType.MouseDown){
			Debug.Log("press");
		}*/
		/*switch(e.type){
		case EventType.MouseDown:
			Instantiate(unit, Input.mousePosition, new Quaternion());
			break;
		case EventType.MouseDrag:
			break;
		case EventType.MouseUp:
			break;
		default:
			break;
		}*/
	//}
}
