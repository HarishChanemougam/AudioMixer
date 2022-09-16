using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class EntityInteraction : MonoBehaviour
{
    [SerializeField] InputActionReference _clickInput;

    [SerializeField] TextMeshProUGUI _focusName;
    [SerializeField] Image _cursor;

    [SerializeField] Sprite _emptyCursor;
    [SerializeField] Color _emptyColor;

    [SerializeField] Sprite _lockedCursor;
    [SerializeField] Color _lockedColor;

    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 2f);
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, 2f))
        {
            if (hitInfo.collider.TryGetComponent<IUsable>(out var RedButton))
            {
                RedButton.use();
            }

            else if (hitInfo.collider.TryGetComponent<IUsable>(out var GreenButton))
            {
                GreenButton.use();
            }
        }
    }
}
