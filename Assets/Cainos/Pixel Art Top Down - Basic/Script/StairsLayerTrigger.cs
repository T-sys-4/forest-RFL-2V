using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class StairsLayerTrigger : MonoBehaviour
    {
        public Direction direction;

        [Space]
        public string layerUpper;
        public string sortingLayerUpper;

        [Space]
        public string layerLower;
        public string sortingLayerLower;

        //private void OnTriggerEnter2D(Collider2D other)
        //{
        //    if (!other.CompareTag("Player")) return;

        //    switch (direction)
        //    {
        //        case Direction.North:
        //            if (other.transform.position.y > transform.position.y)
        //                SetLayerAndSortingLayer(other.gameObject, layerUpper, sortingLayerUpper);
        //            break;

        //        case Direction.South:
        //            if (other.transform.position.y < transform.position.y)
        //                SetLayerAndSortingLayer(other.gameObject, layerUpper, sortingLayerUpper);
        //            break;

        //        case Direction.West:
        //            if (other.transform.position.x < transform.position.x)
        //                SetLayerAndSortingLayer(other.gameObject, layerUpper, sortingLayerUpper);
        //            break;

        //        case Direction.East:
        //            if (other.transform.position.x > transform.position.x)
        //                SetLayerAndSortingLayer(other.gameObject, layerUpper, sortingLayerUpper);
        //            break;
        //    }
        //}

        //private void OnTriggerExit2D(Collider2D other)
        //{
        //    if (!other.CompareTag("Player")) return;

        //    switch (direction)
        //    {
        //        case Direction.North:
        //            if (other.transform.position.y < transform.position.y)
        //                SetLayerAndSortingLayer(other.gameObject, layerLower, sortingLayerLower);
        //            break;

        //        case Direction.South:
        //            if (other.transform.position.y > transform.position.y)
        //                SetLayerAndSortingLayer(other.gameObject, layerLower, sortingLayerLower);
        //            break;

        //        case Direction.West:
        //            if (other.transform.position.x > transform.position.x)
        //                SetLayerAndSortingLayer(other.gameObject, layerLower, sortingLayerLower);
        //            break;

        //        case Direction.East:
        //            if (other.transform.position.x < transform.position.x)
        //                SetLayerAndSortingLayer(other.gameObject, layerLower, sortingLayerLower);
        //            break;
        //    }
        //}

        //private void OnTriggerEnter2D(Collider2D other)
        //{
        //    Debug.Log("ENTER triggered by: " + other.name);

        //    if (!other.CompareTag("Player"))
        //    {
        //        Debug.Log("Not player, ignoring.");
        //        return;
        //    }

        //    Debug.Log("Player entered stairs trigger.");

        //    SetLayerAndSortingLayer(other.gameObject, layerUpper, sortingLayerUpper);
        //}

        //private void OnTriggerExit2D(Collider2D other)
        //{
        //    Debug.Log("EXIT triggered by: " + other.name);

        //    if (!other.CompareTag("Player"))
        //    {
        //        Debug.Log("Not player, ignoring.");
        //        return;
        //    }

        //    Debug.Log("Player exited stairs trigger.");

        //    SetLayerAndSortingLayer(other.gameObject, layerLower, sortingLayerLower);
        //}

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.CompareTag("Player")) return;

            bool goingUp = false;

            switch (direction)
            {
                case Direction.North:
                    goingUp = other.transform.position.y > transform.position.y;
                    break;

                case Direction.South:
                    goingUp = other.transform.position.y < transform.position.y;
                    break;

                case Direction.West:
                    goingUp = other.transform.position.x < transform.position.x;
                    break;

                case Direction.East:
                    goingUp = other.transform.position.x > transform.position.x;
                    break;
            }

            if (goingUp)
                SetLayerAndSortingLayer(other.gameObject, layerUpper, sortingLayerUpper);
            else
                SetLayerAndSortingLayer(other.gameObject, layerLower, sortingLayerLower);
        }



        //private void SetLayerAndSortingLayer(GameObject target, string layerName, string sortingLayerName)
        //{
        //    int layerID = LayerMask.NameToLayer(layerName);


        //    if (layerID == -1)
        //    {
        //        Debug.LogError("Layer does not exist: " + layerName);
        //        return;
        //    }

        //    target.layer = layerID;

        //    SpriteRenderer[] renderers = target.GetComponentsInChildren<SpriteRenderer>();
        //    foreach (SpriteRenderer sr in renderers)
        //    {
        //        sr.sortingLayerName = sortingLayerName;
        //    }
        //}

        //private void SetLayerAndSortingLayer(GameObject target, string layerName, string sortingLayerName)
        //{
        //    Debug.Log("Switching to layer: " + layerName +
        //              " | Sorting layer: " + sortingLayerName);


        //    int id = LayerMask.NameToLayer(layerName);
        //    Debug.Log("Layer ID for New Layer 3: " + LayerMask.NameToLayer("New Layer 3"));

        //    if (id == -1)
        //    {
        //        Debug.LogError("Layer does not exist: " + layerName);
        //        return;
        //    }

        //    target.layer = id;

        //    SpriteRenderer[] renderers = target.GetComponentsInChildren<SpriteRenderer>();
        //    foreach (SpriteRenderer sr in renderers)
        //    {
        //        sr.sortingLayerName = sortingLayerName;
        //    }
        //}

        private void SetLayerAndSortingLayer(GameObject target, string layerName, string sortingLayerName)
        {
            Debug.Log("Raw layer string: [" + layerName + "]");
            Debug.Log("Length: " + layerName.Length);

            int id = LayerMask.NameToLayer(layerName);

            Debug.Log("Resolved ID: " + id);

            if (id < 0)
            {
                Debug.LogError("Layer does not exist: [" + layerName + "]");
                return;
            }

            target.layer = id;

            foreach (SpriteRenderer sr in target.GetComponentsInChildren<SpriteRenderer>())
            {
                sr.sortingLayerName = sortingLayerName;
            }
        }

        public enum Direction
        {
            North,
            South,
            West,
            East
        }
    }
}

