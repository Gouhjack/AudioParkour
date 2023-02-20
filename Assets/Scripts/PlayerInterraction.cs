using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInterraction : MonoBehaviour
{
    [SerializeField] private float _maxDistance;
    [SerializeField] private IUsable _target;
    [SerializeField] private Image crosshair;


    void Start()
    {
        
    }

    
    void Update()
    {
        FindTarget();

        UseTarget();
        Debug.Log(_target);
        ChangeCrossHairState();
    }


    private void FindTarget()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, _maxDistance))
        {
            // Si l'objet touch� contient un composant impl�mentant l'interface IUsable, l'assigner � la variable _target
            _target = hit.collider.gameObject.GetComponent<IUsable>();
            Debug.Log("Yahoo");
            

        }
        else
        {
            // Si aucun objet n'est touch�, assigner la variable _target � null
            _target = null;
        }
    }




    private void UseTarget()
    {
        if (Input.GetButtonDown("Use"))
        {
            FindTarget();
        }
    }
    private void ChangeCrossHairState()
    {

            if (_target != null)
            {
                crosshair.color = Color.red;
            Debug.Log("rouge");
            }
            else
            {
                crosshair.color = Color.white;
            Debug.Log("bleu");
        }
        }


    }



