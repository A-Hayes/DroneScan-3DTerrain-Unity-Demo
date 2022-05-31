# DroneScan-3DTerrain-Unity-Demo
Unity demo of naivgable 3d landscape created from aerial drone scans.

Created as a semester-long project for GEOG-352, this demo serves to show a small-scale attempt at the creation of virtually explorable landscapes created from aerial drone scans of real locations. It was created as part of a project to examine the viability of that and similar methods for surveying and site examination, a matter that the Texas DPS has been looking into in recent years.  

Process: The aerial imagery and heightmap data from the drone scan of a bridge and nearby terrain were composited together by team members into a 3D model of the area. While the goal was to have the imagery overlaid onto this model to more accurately reflect the location, we were unable to do so without licensing expensive software that was out of scope for the project, so the result is a default white surface for the purposes of this demo. The model was then passed to me, and I was tasked with processing the model, creating a first-person 'player' that could navigate the input terrain, as well as adding a basic vehicle that could be used to traverse larger areas. While free-to-use version of said objects were available, they required refactoring/recoding to work properly with the project, as they were created before Unity switched to using exclusively C# for scripting. 

Run Info: Download & extract all files, and run 'Bridge Terrain Explorer.exe' in the 'Playable Demonstration' folder. Move in the demo with WASD, car controls are the same, enter/exit the car with 'e'.
