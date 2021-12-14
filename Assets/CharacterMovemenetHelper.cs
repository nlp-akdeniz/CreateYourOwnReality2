using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;
public class CharacterMovemenetHelper : MonoBehaviour
{
    // Start is called before the first frame update
    private XROrigin m_XROrigin ;
    private CharacterController CharacterController;
    private CharacterControllerDriver driver;



    void Start()
    {
        m_XROrigin = GetComponent<XROrigin>();
        CharacterController = GetComponent<CharacterController>();    
        driver = GetComponent<CharacterControllerDriver>();    
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCharacterController();
    }

    /// <summary>
    /// Updates the <see cref="CharacterController.height"/> and <see cref="CharacterController.center"/>
    /// based on the camera's position.
    /// </summary>
    protected virtual void UpdateCharacterController()
    {
        if (m_XROrigin == null || CharacterController == null)
            return;

        var height = Mathf.Clamp(m_XROrigin.CameraInOriginSpaceHeight, driver.minHeight,driver.maxHeight);

        Vector3 center = m_XROrigin.CameraInOriginSpacePos;
        center.y = height / 2f + CharacterController.skinWidth;

        CharacterController.height = height;
        CharacterController.center = center;
    }
}
