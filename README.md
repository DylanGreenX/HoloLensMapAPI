# HoloLensMapAPI
Shareable Map API
# Project File Structure
Due to the large amount of files in the project, I wanted to highlight the locations that key Prefabs, Textures, and Scripts are located.

The majority of the core contents are in the 'assets/app' folder.

Prefabs: 
'assets/app/prefabs'

Materials: 
'assets/app/materials'

Scripts:
'assets/app/materials'

#Prefabs

Popup_Menu:

<img width="156" alt="image" src="https://github.com/DylanGreenX/HoloLensMapAPI/assets/97126306/22fd3e0e-225a-47ff-a434-9ea5039ec7d3">

This menu style is used multiple times throughout the project. It creates a simple 3-button menu that can be changed for user purposes.

PLT_Menu:

<img width="54" alt="image" src="https://github.com/DylanGreenX/HoloLensMapAPI/assets/97126306/4e1f9e13-6f94-46be-b79b-c3623af2f699">

This is an extension to the Popup_menu prefab. While everything can be replicated with the Popup_Menu prefab, this will help speed up project development if the goal is to replicate our Map API.

Friendly_Sticker:

<img width="62" alt="image" src="https://github.com/DylanGreenX/HoloLensMapAPI/assets/97126306/46875b26-20aa-450f-99e1-797de542d4e7">

Friendly_Sticker creates a sticker object with a Photon Unity Networking component (Necessary for shared experiences) and the CopyObjectonClick script, which allows it to be duplicated.

Enemy_Sticker:

<img width="70" alt="image" src="https://github.com/DylanGreenX/HoloLensMapAPI/assets/97126306/5d64172e-d0ba-4e9a-86bc-3f154da85a89">

Enemy_Sticker creates a sticker object with a Photon Unity Networking component (Necessary for shared experiences) and the CopyObjectonClick script, which allows it to be duplicated.

# Script Details 
## CopyObjectOnClick

Note: Ensure the Photon Unity Networking (PUN) package is imported into your project before using this script.

### Usage
1. Attach the `CopyObjectOnClick` script to a GameObject in your scene.
2. Assign the `objectToCopy` and `copiedObjectPrefab` variables in the Inspector.
3. Assign a `DeleteObjectTracker` script to the `deleteObjectTracker` variable.
4. Call the `CopyObject` method to create a copy of the specified object.

### Public Variables
- **objectToCopy**: The GameObject to be copied.
- **copiedObjectPrefab**: The prefab of the object to be instantiated as a copy.
- **deleteObjectTracker**: The DeleteObjectTracker script managing the list of created objects.

### Prviate Variables
- **copiedObject**: The reference to the instantiated copied object.

### Public Methods
**`CopyObject()`:** Creates a copy of the specified object using Photon Networking and applies custom transformations. The copied object is added to the createdObjects list in the DeleteObjectTracker.

## DeleteObjectTracker

### Usage
1. Attach the `DeleteObjectTracker` script to a GameObject in your scene.
2. Use the `createdObjects` list to track GameObjects created during runtime.
3. Call the `DeleteMostRecentObject` method to delete the most recently created object.
4. Call the `DeleteAllClones` method to delete all created objects.

### Public Variables
- **createdObjects**: A list of GameObjects created during runtime.

### Public Methods
**`DeleteMostRecentObject()`:** Deletes the most recently created object from the createdObjects list.
**`DeleteAllClones()`:** Deletes all objects in the createdObjects list.

## ResetSize 

### Usage
1. Attach the `ResetSize` script to a GameObject in your scene.
2. The script will automatically capture the initial scale during the `Start` phase.
3. Call the `ResetToInitialTransform` method to reset the GameObject's scale to its initial size.

### Private Variables
- **initialRotation**: Stores the initial rotation of the GameObject.
- **initialScale**: Stores the initial scale of the GameObject.

### Public Methods
- **`ResetToInitialTransform()`:** Resets the scale of the GameObject to its initial size.
  
## Transform Active State

### Usage
1. Attach the `ToggleActiveState` script to a GameObject in your scene.
2. Assign the target GameObject to the `objectToToggle` variable in the Inspector.
3. Call the `ToggleObjectActiveState` method to toggle the active state of the GameObject.

### Public Variables
- **objectToToggle**: The GameObject whose active state will be toggled.

### Public Methods 
- **`ToggleObjectActiveState()`:** Toggles the active state of the objectToToggle. If it is currently active, it will be deactivated, and vice versa.
  
## Transform Synchronizer

### Usage
1. Attach the `TransformSynchronizer` script to a GameObject in your scene.
2. Assign the source and target transforms in the Inspector.
3. Call the `SynchronizeTransform` method to synchronize the transforms.
   
### Public Variables
- **sourceTransform:** The transform whose properties will be copied.
- **targetTransform:** The transform that will receive the copied properties.
  
### Public Methods
- **`SynchronizeTransform()`:** Copies the position, rotation, and scale from the `sourceTransform` to the `targetTransform`.


# UML Diagram
<img width="985" alt="image" src="https://github.com/DylanGreenX/HoloLensMapAPI/assets/97126306/113a7d3e-ad6d-436d-b90d-501c5e536fb9">

