using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
        public class DialogueBaseClass : MonoBehaviour
    {
        public bool finished{ get; private set;}
        protected IEnumerator WriteText(string input, Text textHolder, float delay)
        {
            for(int i=0; i < input.Length; i++)
            {
                textHolder.text += input[i]; 
                yield  return new WaitForSeconds(delay);
            }

            finished = true;
        }
    }
}

