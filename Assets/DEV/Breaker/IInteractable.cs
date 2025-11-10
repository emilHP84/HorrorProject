using UnityEngine;

public interface IInteractable
{
    public void ShowInteractOnContact(bool value);
    public void Interact(KeyCode input);
}
