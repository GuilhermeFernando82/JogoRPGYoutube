using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; 
[CustomEditor(typeof(visaovilao))]
public class Mostra_FOV : MonoBehaviour
{
    // Start is called before the first frame update
    public visaovilao fovM;

   private void OnSceneGUI()
   {
       
        Handles.color = Color.black;
	    Handles.DrawWireArc(fovM.transform.position, Vector2.up, Vector2.up,360,fovM.fov);
        Vector3 vA = -fovM.DirFAngle(fovM.fov / 2);
        Vector3 vB = fovM.DirFAngle(fovM.fov / 2);
        
        Handles.DrawLine(fovM.transform.position, fovM.transform.position + vA * fovM.raioVisao);
        Handles.DrawLine(fovM.transform.position, fovM.transform.position + vB * fovM.raioVisao);
   }
}
