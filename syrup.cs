using BeanAssembly.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace BeanAssembly
{
    class syrup : MonoBehaviour
    {
        List<feature> features = new List<feature>();

        void Start()
        {
            features.Add(new ESP());
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
                features[0].activated = !features[0].activated;
            foreach (feature feat in features)
                if(feat.activated)
                    feat.Update();
        }
        void OnGUI()
        {
            //watermark
            GUI.Label(new Rect(0, 0, 200, 200), "Syrup v0.1\nESP: " + (features[0].activated ? "On" : "Off"));

            foreach (feature f in features)
            {
                if (f.activated)
                    f.OnGUI();
            }
        }
        void FixedUpdate()
        {
            foreach (feature feat in features)
                if(feat.activated)
                    feat.FixedUpdate();
        }

    }
}
