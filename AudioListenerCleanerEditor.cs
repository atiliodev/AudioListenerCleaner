using UnityEngine;
using UnityEditor;

public class AudioListenerCleanerEditor
{
    [MenuItem("Tools/Clean AudioListeners")]
    private static void CleanAudioListeners()
    {
        // Encontra todos os AudioListeners na cena
        AudioListener[] listeners = GameObject.FindObjectsOfType<AudioListener>();

        if (listeners.Length == 0)
        {
            Debug.Log("Nenhum AudioListener encontrado na cena.");
            return;
        }

        // Mantém o primeiro e remove os outros
        for (int i = 1; i < listeners.Length; i++)
        {
            Object.DestroyImmediate(listeners[i]);
        }

        Debug.Log("AudioListeners extras removidos: " + (listeners.Length - 1));
    }
}
