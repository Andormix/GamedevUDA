<img width="740" height="416" alt="Screenshot 2026-02-13 222656" src="https://github.com/user-attachments/assets/3b5a91f8-e8db-4f80-a442-fad7bcae76e7" />

Recap work 2/13/2026: 
- At counter prefab we habe attached SceneObjectSO with all the info. This counter prefab have en empty Game object as point of reference to spawn objects.
- At prefab Itself to know whitch SO belongs it has SceneObject Script attached with a SceneObjectSO identifying it. (Get function also)
- Until now we have only 2 SO creted Green and Black Pot with different Name and Prefab.
- Until now when we spawn a prefab in a counter to do so we take the SceneObjectSO attached to the counter and Instanciate the SceneObjectSO.prefab
  at the empty game object (Point of reference).

![WIN_20260213_12_06_25_Pro](https://github.com/user-attachments/assets/723d50af-f465-4556-905d-9beb73602864)

