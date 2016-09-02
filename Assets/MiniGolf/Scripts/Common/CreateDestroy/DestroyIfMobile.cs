using System.Collections;
using UnityEngine;

/// <summary>
/// Destroy if mobile.
/// </summary>
public class DestroyIfMobile : MonoBehaviour
{
    void Start()
    {
        if (Misc.isMobilePlatform())
        {
            Destroy(gameObject);
        }
    }
}
