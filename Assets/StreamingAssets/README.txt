1. The different between Update, FixedUpdate, and LateUpdate, and when we should use each.
A: 
Update: Called every frame. Usually used for inputs cause it depends on the PC frame rate.
FixedUpdate: Called at a certain frame rate. Usually used for physical things.
LateUpdate: Called after Update function. Used for camera movement avoiding camera shaking.

2. What the StreamingAssets folder is used for.
A: Won't be packaged in Builds. We can put videos or pictures in it if we want.

3. "special folder"
A: 
Editor: Add functionality to Unity during development, but if we build the scripts in Editor it will occur errors.
Resources: We can load things in Resources Folder. We can have many Resources Folder but shouldn't use the same name for these things.
Plugins: Scripts won't be compiled in Plugins Folder.

4. Scripts Execution Order
A:
It's in "Project Settings" => "Script Execution Order". That's the order what unity execute scripts, and if we have something
needed to be executed before other scripts, we can add something and change it. But normally we don't change it.