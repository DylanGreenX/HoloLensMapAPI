# HoloLensMapAPI
Shareable Map API



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
**CopyObject()':** Creates a copy of the specified object using Photon Networking and applies custom transformations. The copied object is added to the createdObjects list in the DeleteObjectTracker.

## DeleteObjectTracker

### Usage
1. Attach the `DeleteObjectTracker` script to a GameObject in your scene.
2. Use the `createdObjects` list to track GameObjects created during runtime.
3. Call the `DeleteMostRecentObject` method to delete the most recently created object.
4. Call the `DeleteAllClones` method to delete all created objects.

### Public Variables
- **createdObjects**: A list of GameObjects created during runtime.

### Public Methods
**DeleteMostRecentObject()':** Deletes the most recently created object from the createdObjects list.
**DeleteAllClones()':** Deletes all objects in the createdObjects list.

## ResetSize 

### Usage
1. Attach the `ResetSize` script to a GameObject in your scene.
2. The script will automatically capture the initial scale during the `Start` phase.
3. Call the `ResetToInitialTransform` method to reset the GameObject's scale to its initial size.

### Private Variables
- **initialRotation**: Stores the initial rotation of the GameObject.
- **initialScale**: Stores the initial scale of the GameObject.

### Public Methods
- **'ResetToInitialTransform()':** Resets the scale of the GameObject to its initial size.
  
## Transform Active State

### Usage
1. Attach the `ToggleActiveState` script to a GameObject in your scene.
2. Assign the target GameObject to the `objectToToggle` variable in the Inspector.
3. Call the `ToggleObjectActiveState` method to toggle the active state of the GameObject.

### Public Variables
- **objectToToggle**: The GameObject whose active state will be toggled.

### Public Methods 
- **'ToggleObjectActiveState()':** Toggles the active state of the objectToToggle. If it is currently active, it will be deactivated, and vice versa.
  
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






<img width="1382" alt="image" src="https://github.com/DylanGreenX/HoloLensMapAPI/assets/97126306/732b209d-b7c6-42d4-a477-50f01eb0b746">
