### [Mod Hound]()

[Mod Hound](https://app.ts4modhound.com/) is a website created by [Lumpinou](https://www.patreon.com/lumpinou). It's a place where modders can list their mods, including if they were updated, if they're broken or obsolete or working fine with the current patch, and if they require other mods that are also listed on the site. Players can then have the website scan their mods folder for various things.

Mod Hound has collaborated with PlumbBuddy to incorporate these scans in PlumbBuddy. On the Mod Hound tab, you can request that PlumbBuddy send a list of your mods to Mod Hound, and Mod Hound will send back a report that you can view in the app by clicking on the various parts of the report on the left.

It will give you lists of:

* Outdated mods – mods that you need to update, based on the date of the file in your mods folder compared to the date of the file listed on Mod Hound
* Duplicate mods – files that you have two or more copies of, based on the file names
* Broken/Obsolete mods – mods the creator has indicated are broken (they will *probably* be updated at some point) or obsolete (they no longer exist in their current form, but they might have a replacement — you should check the download page)
* Incompatible mods – two or more mods that can’t be used together
* Missing Requirements – mods that are missing another mod that they need to work
* Unknown Status – mods that are listed on Mod Hound but that don’t have a current status listed by their creator
* Up to Date – mods that should be up to date according to their date of the file in your mods folder compared to the date listed on Mod Hound
* Not Tracked – mods and custom content (CC) that aren’t listed on Mod Hound

Except for duplicates, the report will only give advice about mods that the creator has listed on Mod Hound.

In addition, many of the files in the report will come with buttons to view the file in your mods folder and/or to go to the download page for the mod, or in the case of the missing requirement, to download that.

There are settings for Mod Hound, available by clicking on the gear next to the Request New Report button, and also available in PlumbBuddy settings. You can decide how long PlumbBuddy will store your reports (so you can look at them later if you need to) and which files and folders PlumbBuddy will not send to Mod Hound, and see the effects of what those exclusions are. 

It’s important to note that Mod Hound is not meant to list CC, and it has an upper limit of files that it will scan, to prevent the site from crashing. If the number of files is over that limit, PlumbBuddy won’t send them, and PlumbBuddy will advise you to add exclusions if you have over 5000 files, since that would mainly be CC.

In the settings, the symbol above the number of Packages Included will turn a warning colour if you're over the *recommended* number of files to send, and an error colour if you're over the number of files that PlumbBuddy is able to send because Mod Hound would reject them so that the site doesn't crash. You can fix this by adding Packages Exclusions. When you do that, the number on the left will go down and the number on the right (Packages Excluded) will go up, telling you how much of a difference you're making.

You add exclusions by listing your CC folders or what your CC folder names start with. For example, if all of a lot of your CC is in a folder called `CAS`, you would exclude `CAS/`. If all of your CC folders start with `CC`, you'd exclude `CC`, but that could end up excluding more than you want it to — it would look for all things that start with CC, not just the folder name.

_*Note: it’s important to use forward slashes (`/`), not backward slashes (`\`).*_

![image](/img/PB-ModHoundTab.png)
![image](/img/PB-ModHoundSettings-Casual.png)