Setting up PlumbBuddy is fairly straightforward. There aren't really many ways it can go wrong, but if at any point you change your mind and want to go back and change something, you can use the Previous button in the bottom left. And if you get it all set up and *then* change your mind, you can change things in Settings.

---

### Step One: The Legal Stuff

When you first install and open PlumbBuddy, the first thing you’ll see is the End User License Agreement. You have to agree to this to use PlumbBuddy. Read through it, and then click the Next button at the bottom right.

![image](/img/PB-EULA.png "An image of the top of the End User License Agreement, with the other tabs visible as a line of circles along the top")

---

### Themes

PlumbBuddy has a default light or dark theme based on your computer's settings, but you can choose from a variety of other themes that are included. Some are light mode only, some are dark mode only, and some have both — those follow your computer's settings.

On the second tab, you can pick which one you want to use. Click on them to see what they look like, and click on them again to turn them off. Pick one (or none) for now, and then click next at the bottom right. If you want to, you can change your theme later in Settings.

This guide uses the default dark mode theme, but you can use whatever you want.

![image](/img/PB-theme-choice.png "An image of some of the theme choices available in PlumbBuddy")

---

### Introductions

On the Introductions tab, you choose if you’re a Casual Player, an Enthusiast Player, or a Mod Creator. Which you choose decides what options are enabled for default for you, how much information is displayed, and what you can do with PlumbBuddy.

By default, Mod Creators will have one scan active: one telling you if you have a mod in your mods folder that no longer matches its manifest (intended to remind you to update your manifests). It’s up to YOU to decide what you want to be notified of. You will also be shown the number of packages, scripts, resources, uncompiled scripts, and python byte code files.

You can switch between types by clicking the circles at the top (blue for Casual, red for Enthusiast, or green for Creator) or by using the arrows on the sides of the picture.

Pick Mod Creator (green) and click Next at the bottom right.

![image](/img/PB-creator-Bella.png "An image of the Introductions tab in PlumbBuddy. At the top are instructions to use the circles or arrows to choose. Below is an image of Bella Goth playing a video game, with a description of an mod creator in front: 'Hey, PlumbBuddy! You should probably just default all your health scans off for me unless I turn them on for myself. You and I both know I don't actually have time to play the game. 😂 Oh, and could you unlock your Creator Tools for me? I may need to update manifests in my mods.'")

---

### Folders

The folders tab is kind of important. PlumbBuddy will auto detect this information. For most people, it's fine to glance at it, make sure it looks okay, and move on.

Everything on this tab is required for PlumbBuddy to work. PlumbBuddy *needs* to know where your game and mods and downloads folder are, and where you want Archivist to put your save file backups if you choose to use Archivist — you don't need to use Archivist if you don't want to, but you do need to set a folder path.

At the top, PlumbBuddy will show:

* Your operating system (Windows or Mac) and its language
    * PlumbBuddy will use that language if a translation in that language exists, but it will default to American English if your language isn’t included
* If it detected the game installed using the EA app
* If it detected the game installed using Steam

![image](/img/PB-folders-OS.png "An image showing that the user is using Windows and English (Canade), with a Reset Paths button below, and the EA App, with a Select button below, and a Steam symbol to the right with no button below")

If you have the game installed using both the EA app and Steam, you can pick which one is used by clicking the Select button underneath that install.

Below that, there are four boxes.

1. The top box is your User Data Folder.
    * This is where your Mods folder is.
    * It must not be named Mods itself in a folder that also contains `Options.ini`.
    * It must contain `Options.ini`.
2. The second box is your Installation Folder.
    * This is where the game is installed.
    * On Windows, it must contain `Game\Bin\TS4_x64.exe`.
    * On Mac, it must contain `Contents/MacOS/The Sims 4`.
3. The third box is your Downloads Folder.
    * By default, this is your computer's regular downloads folder, but you can change it.
    * This is used, for example, if you have a .zip file in your Mods folder and PlumbBuddy offers to move it out for you.
4. The fourth box is where Archivist will store its database, if you activate it.
    * By default, it will be a folder in your Documents folder, but you can put it anywhere you want, including an external drive or cloud storage.
        * Keep in mind that Archivist will get angry if she can't find the location your folder is in, and you may want to deactivate Archivist before removing an external drive she's using.
    * If the folder doesn’t already exist, it will be created when you turn Archivist on.

![image](/img/PB-folders-files.png "An image of the folders as described above, with a Browse button to the right end of each box")

If you change any of these and then you want to go back to the default, click Reset Path for User Data and Downloads and Archivist, under your operating system at the top, and Select for Installation Files, under EA App/Steam.

If anything shows up red here, try clicking Reset Path or Select. If you have a custom setup for the game's installation or user data folder, you may need to tell PlumbBuddy where to find it if it's not auto detected.

![image](/img/PB-folders-error.png "An image of an invalid Download Folder path, with 'Bruh... there's not even a folder there' in red at the bottom")

Once you’ve checked these or changed them, click Next at the bottom right.

![image](/img/PB-folder-mac.png "An image of a Mac user's folder settings")
![image](/img/PB-folder-windows.png "An image of a Windows user's folder settings")

---

### Mod Health

Almost done!

This tab will tell PlumbBuddy some key things that you want it to tell *you*. It's where you choose which scans you want enabled in Mod Health.

Most scan will start out disabled. Mod Creators will have one scan active: one telling you if you have a mod in your mods folder that no longer matches its manifest (intended to remind you to update your manifests). It’s up to YOU to decide what you want to be notified of. You can choose to enable all, disable all, or pick and choose.

To see all scans in a category, click the symbol at the right of each bar to open a dropdown menu.

1. The top bar is for game options. Click the gear and enable or disable options such as an alert if mods or script mods are disabled, or the mod list is enabled.
2. The second bar is for basic installation errors (files too deep, zip files, etc.) and error files. Click the file icon to enable or disable these.
3. The third bar is for missing encouraged mods, like MCCC. Click the box to enable or disable these.
4. The fourth box is for PlumbBuddy’s suggestions based on its analysis of your mods folder — you should clear your cache, or information it learns from manifested mods, such as multiple versions of the same mod or multiple ‘pick one’ files. Click the refresh symbol to enable or disable these.

You can disable all scans in one section by clicking on the X on the right of the bar.

You can read more about the various Mod Health scans on the [Mod Health](https://plumbbuddy.app/text-guides/enthusiast-mod-health) page.

Once you've made your decisions, click Next on the bottom right.

![image](/img/PB-Setup-ModHealth-creator.png "An image of the Mod Health settings as described above: four bars, the top three empty and the bottom one with one coloured bubble representing an active Mod Health scan. At the right of each bar is an x for removing all scans and a symbol to click to open a dropdown menu. At the bottom are Enable All, Disable All, and Set Default buttons.")

---

### PlumbBuddy Settings

Here are certain things that PlumbBuddy does by default that you can turn off, and things it doesn't do for you by default that you can turn on, and where you set your default creator name(s) that will auto populate in your manifests.

At the top is an empty bar. Type in your creator name and hit enter. If you typically work with a team and want to have each person listed, you can type them all in and hit enter after each one. You can remove any that aren't working on a particular mod in that mod's manifest.

Below that are a series of toggles:

* You can turn on auto checking for PlumbBuddy updates, which is off by default.
    * This would make sure that you always know if your PlumbBuddy app has all the latest features and bug fixes.
![image](/img/auto-check-for-updates.png "Automatically check for updates")
* You can turn on offering to help you find mod update news after you’ve updated your game.
![image](/img/offer-mod-news.png "Offer to help find mod update news when the game is patched")
* You can turn off the global manifest package.
    * This is a file that will be created in your Mods folder which makes the information PlumbBuddy has about the mods installed in your Mods folder available so that other mods can make use of it.
![image](/img/generate-global-manifest.png "Generate global manifest package")
* You can turn on PlumbBuddy having an icon in the system tray on Windows.
![image](/img/show-icon-tray.png "Show an icon in the system tray")
* You can turn off having PlumbBuddy store a mod's hash once it has been manifested.
    * This is to assist you and players by having PlumbBuddy keep a background record that you've manifested a mod before even if the current version you're manifesting doesn't contain a manifest.
![image](/img/auto-catalog.png "Automatically catalog mod manifests when composition succeeds")
* You can turn off PlumbBuddy recording inside the manifest that you've previously manifested the mod, if you're manifesting a mod with the same name and creators but without an existing manifest. 
    * This will ensure that if you update a mod and another mod lists it as a requirement in that mod's manifest, it will continue to count for the mod that was required before.
    * If this is off and you manifest a mod without its previous manifest included, then PlumbBuddy will think that the requirements are not met.
![image](/img/auto-subsume.png "Automatically subsume identically credited single-file mods when initializing a manifest")

The last two toggles are a backup system for manifest hashes and it's probably best to leave them on.

Once you’ve made a decision, click Finish on the bottom right.

![image](/img/PB-PBsettings-creator.png "An image of the PlumbBuddy app settings, with 'Automatically check for updates' and 'Offer to find mod update news when the game is patched' toggled off,  'Generate global manifest package' toddled on, 'Show an icon in the system tray' toggled off, and 'Automatically catalog manifests when composition succeeds' and 'Automatically subsume identically credited single-file mods when initializing a manifest' toggled off")

And we're done!

---

Once you've finished the basic setup, PlumbBuddy will begin scanning your Mods folder for any issues. 

While that finishes, you might want to head over to [User Interface Overview](https://plumbbuddy.app/text-guides/creator-ui) to see what's happening.