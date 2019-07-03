using UnityEngine;

public class GameObjectUtils
{
    public static GameObject GetChildrenWithTag<T>(GameObject gameObject, T tag)
    {
        foreach (Transform child in gameObject.transform)
        {
            if (TagUtils.CompareGameObjectTag(child.gameObject, tag))
            {
                return child.gameObject;
            }
        }

        return null;
    }

    public static bool CompareLayerWithMask(GameObject gameObject, LayerMask mask)
    {
        return ((1 << gameObject.layer) & mask) != 0;
    }
}