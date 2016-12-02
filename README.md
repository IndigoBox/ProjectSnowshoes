# Project Snowshoes
Redefining the Windows interface for everybody...and the actual word "Snowshoes" apparently.

Welcome, friends, family, colleagues, dogs that run around the studio, and random prowling bots! This is the official repository for Project Snowshoes, a project that previously had its code privately held for a year and a half. Now, anything that gets done can actually be seen here. 


## Setup & Repository Structure

Before we begin, running this project requires the latest version of Microsoft's .NET Framework. If you don't have it, running the project will likely trigger a feature install on your Windows machine.

There are two things that Project Snowshoes needs: the main program that controls and manages everything, and dependencies as well as bundled programs that get installed when the client runs through the SnowshoesInstaller (sorry, no repo for that, but I promise you are not missing much there). 

So, if you are looking for the main program code, go directly to the ProjectSnowshoes directory.
If you are looking for various other resources, go to ClientSide.

Since the process of renaming everything to work correctly is a bit tedious, you can either run the <b>Installer</b> executable in the main directory, or take to the command line directly. 

```xcopy ClientSide C:\ProjectSnowshoes\ /s /y```
will copy those files to the place Snowshoes pulls resources from (I promise, custom paths will become possible sooner or later). The conditions are to force overwriting, for if you've done this before and were not successful, or are updating. It also enables copying all subdirectories.

Then, run <b>C:\ProjectSnowshoes\System\Fonts\PSFontInstall.vbs</b> to install the required fonts for this project.

## Why, that leads into this section pretty nicely!
A huge, huge thank you to all the projects and organizations that allow this development to happen. 

- Roboto is licensed under the Apache License 2.0, and the repository for it can be found [here](https://github.com/google/roboto).
- Pacifico is licensed under the SIL Open Font License 1.1, and can be found as a webfont [here](https://www.google.com/fonts/specimen/Pacifico). 
- The project itself is compiled in Microsoft's Visual Studio using .NET Framework 4.6. 


## A little note from the editor
Just because this is going live, the craziness might not stop. If you look through the code, you might see that some of the method names and whatnot are absolutely disgusting. I know...I look back at them as well, and they are difficult to interpret. While I am actually compiling a document to decode some of the more confusing names and references used in method/instance names, etc., things will get better now that this moved on from something I do at three in the morning to becoming an official IndigoBox (/Pentelec) project that I work on at three in the morning.

Thank you for visiting, and may this be the start of an ever-developing, fun, and successful journey!
