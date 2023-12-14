# HoloLensMapAPI
Simple Shareable Map API


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
