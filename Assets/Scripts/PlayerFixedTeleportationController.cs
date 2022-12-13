using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZenvaVR
{
    public class PlayerFixedTeleportationController : MonoBehaviour
    {
        // current teleportation pod
        public FixedTeleportationPodController currentPod;

        // teleportation range
        public float range;

        // object that contains all the pods
        public Transform podContainer;

        void Start()
        {
            if(podContainer == null)
            {
                Debug.LogError("The object that contains all the teleport pods needs to be passed to the player");
            }

            // refresh the pods
            RefreshPods();
        }

        // move the player to the teleportation pod
        public void Teleport(FixedTeleportationPodController pod)
        {
            // teleportation pod position
            Vector3 podPos = pod.gameObject.transform.position;

            // calculate height difference between current the new pod
            float diffY = podPos.y - currentPod.gameObject.transform.position.y;

            // place the player in the position of the pod
            transform.position = new Vector3(podPos.x, transform.position.y + diffY, podPos.z);

            // save new "currentPod"
            currentPod = pod;

            // refresh the pods
            RefreshPods();
        }

        // show only the pods that you can move towards
        void RefreshPods()
        {
            // transform of the pod
            Transform pod;

            // find all the pods
            for(int i = 0; i < podContainer.childCount; i++)
            {                
                // assign pod
                pod = podContainer.GetChild(i);

                // check distance
                if (Vector3.Distance(pod.position, transform.position) <= range)
                {
                    pod.gameObject.SetActive(true);
                }
                else
                {
                    // deactivate all pods
                    pod.gameObject.SetActive(false);
                }
            }            
            
            // deactivate the current pod
            currentPod.gameObject.SetActive(false);
        }

    }
}
