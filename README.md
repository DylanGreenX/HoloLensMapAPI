# HoloLensMapAPI
Simple Shareable Map API



# Script Details 

## <u> ResetSize Script Documentation</u>

### Usage

1. Attach the `ResetSize` script to a GameObject in your scene.
2. The script will automatically capture the initial scale during the `Start` phase.
3. Call the `ResetToInitialTransform` method to reset the GameObject's scale to its initial size.

## Private Variables

**initialRotation**: Stores the initial rotation of the GameObject.
**initialScale**: Stores the initial scale of the GameObject.

## Public Methods

- **'ResetToInitialTransform()':** Resets the scale of the GameObject to its initial size.
  
##  <u> Transform Active State <\u>

## Usage
1. Attach the `ToggleActiveState` script to a GameObject in your scene.
2. Assign the target GameObject to the `objectToToggle` variable in the Inspector.
3. Call the `ToggleObjectActiveState` method to toggle the active state of the GameObject.

## Public Variables

- **objectToToggle**: The GameObject whose active state will be toggled.

## Public Methods 

- **'ToggleObjectActiveState()':** Toggles the active state of the objectToToggle. If it is currently active, it will be deactivated, and vice versa.
  
## <u>  Transform Synchronizer <\u>

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
