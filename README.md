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


## Suggestions
Feel free to suggest features by creating an issue, any idea is welcome !
