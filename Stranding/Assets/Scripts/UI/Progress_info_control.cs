﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Stranding
{
    /// <summary>
    /// used to control progress info ui
    /// </summary>
    
    public class Progress_info_control : MonoBehaviour
    {
        // player data storage game object
        public GameObject source;
        // local data storage script object
        private Data_storage data_storage;

        public GameObject LOOP_count;
        public GameObject STEP_count;

        private int loop;
        private int step;

        // Start is called before the first frame update
        void Start()
        {
            // initialize data storage
            data_storage = source.GetComponent<Data_storage>();
        }

        // Update is called once per frame
        void Update()
        {
            // pull data from data storage
            loop = data_storage.Loop;
            step = data_storage.Step;

            LOOP_count.GetComponent<Text>().text = loop.ToString();
            STEP_count.GetComponent<Text>().text = step.ToString();
        }
    }
}

