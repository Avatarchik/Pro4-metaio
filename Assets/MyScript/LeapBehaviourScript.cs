using UnityEngine;
using System.Collections;
using Leap;

public class LeapBehaviourScript : MonoBehaviour {

  Controller controller = new Controller();

  public int FingerCount;
  public GameObject[] FingerObjects;

  public GameObject FrontMost;

  void Start()
  {
  }

  void Update()
  {
    Frame frame = controller.Frame();
    FingerCount = frame.Fingers.Count;

    InteractionBox interactionBox = frame.InteractionBox;
    Pointable pointable = frame.Pointables.Frontmost;

	//Debug.Log(interactionBox.NormalizePoint(pointable.TipPosition));

    Vector normalizedPosition = interactionBox.NormalizePoint(pointable.TipPosition );
    normalizedPosition *= 200;
    normalizedPosition.z = -normalizedPosition.z;
    FrontMost.transform.localPosition = ToVector3( normalizedPosition );
 
    /*
    for ( int i = 0; i < FingerObjects.Length; i++ ) {
      var leapFinger = frame.Fingers[i];
      var unityFinger = FingerObjects[i];
      SetVisible( unityFinger, leapFinger.IsValid );
      if ( leapFinger.IsValid ) {
        Vector normalizedPosition = interactionBox.NormalizePoint(leapFinger.TipPosition );
        normalizedPosition *= 10;
        normalizedPosition.z = -normalizedPosition.z;
        unityFinger.transform.localPosition = ToVector3( normalizedPosition );
      }
    }
    */
  }

  void SetVisible( GameObject obj, bool visible )
  {
    foreach( Renderer component in obj.GetComponents<Renderer>() ) {
      component.enabled = visible;
    }
  }

  Vector3 ToVector3( Vector v )
  {
    return new UnityEngine.Vector3( v.x, v.y, v.z );
  }
}