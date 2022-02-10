﻿# Triggerable - Unity
_The package is an extraction and refactor of the system created for the [GMTK 2021](https://rikoo.itch.io/late-gmtk-2021)_

## Contributors
- [Benoit Lemoine](https://github.com/benoitLemoine)
- [Jean-Baptiste Leonelli](https://github.com/jb106)
- [Erik Kubiak](https://github.com/ErikRikoo)

## Installation
To install this package you can do one of this:
- Using Package Manager Window
    - Opening the Package Manager Window: Window > Package Manager
    - Wait for it to load
    - Click on the top left button `+` > Add package from git URL
    - Copy paste the [repository link](https://github.com/ErikRikoo/com.rikoo.triggerable)
    - Press enter

- Modifying manifest.json file
Add the following to your `manifest.json` file (which is under your project location in `Packages` folder)
```json
{
  "dependancies": {
    ...
    "com.rikoo.interface-utilities": "https://github.com/ErikRikoo/com.rikoo.interface-utilities.git",
    "com.rikoo.triggerable": "https://github.com/ErikRikoo/com.rikoo.triggerable",
    ...
  }
}
```

## Updating
Sometimes Unity has some hard time updating git dependencies so when you want to update the package, 
follow this steps:
- Go into `package-lock.json` file (same place that `manifest.json` one)
- It should look like this:
```json
{
  "dependencies": {
    ...
    "com.rikoo.triggerable": {
      "version": "https://github.com/ErikRikoo/com.rikoo.triggerable",
      "depth": 0,
      "source": "git",
      "dependencies": {},
      "hash": "hash-number-there"
    },
    ...
}
```
- Remove the _"com.rikoo.triggerable"_ and save the file
- Get back to Unity
- Let him refresh
- Package should be updated

## Contents
This package allows you to easily setup Trigger -> Action systems. 
Like a Pressure Plate which would trigger the opening of a door.
It is splitted into three parts:
- Triggers
- Actions
- Collider Filters

### Triggers
This part is all about detecting an object into a trigger with some special conditions 
if needed. Then it will run the given **Action**.
- **Minimum Count Trigger** will allow you to trigger an action if a minimum number 
of elements are in the trigger.

### Actions
This is all the **Actions** that can be run after a trigger.
- **Multiple Triggerable** allows you to run multiple actions at once.
- **Logging ...** is there just to print some message in the console.
- **Animator Triggerable** will allow you to change a particular parameter of an animator.
You will have it for:
  - The float
  - The bool
  - the int
- **Transition Triggerable** are all about smoothing some value into another. For now, you have:
  - **Position** that will smooth from a start position to an End.

### Collider Filters
You will find a Collider Filter in each Trigger instance. 
It will allow you to check the in element and know if you want to trigger or not.
We can split into two parts:
- Simple
- Multiple

The **Simple** contains:
- **Direct Bool Filter** that will just always says that the element is valid if set to true
or invalid if set to false.
- **Layer Filter** will filter according to a given Physic Layer.
- **Tag Filter** will do the same but on object tags.
- **Collider With Component** allows you with inheritance to check if the element 
has a particular component.


## Suggestions
Feel free to suggest features by creating an issue, any idea is welcome !
